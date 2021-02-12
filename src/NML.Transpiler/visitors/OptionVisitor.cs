using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using NML.Parser;
using NML.Parser.Contexts;
using NML.Parser.Objects;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace NML.Transpiler.Visitors
{
	/// <summary>
	/// Visits options and translates into elements that are used by the element visitor.
	/// </summary>
	public class OptionVisitor : IOptionVisitor<IElement>
	{
		private readonly ValueVisitor valueVisitor;
		private readonly PageContext pageContext;
		public OptionVisitor(PageContext pageContext, ValueVisitor valueVisitor)
		{
			this.pageContext = pageContext;
			this.valueVisitor = valueVisitor;
		}

		public IElement? Visit(ImportOptions options)
		{
			if(options == null) throw new ArgumentNullException(nameof(options), "Provided import options are empty");
			if(pageContext == null) throw new ArgumentNullException(nameof(pageContext), "Provided page context is empty");

			string importText = "";
			var path = pageContext[options.IsFromSpecified ? options.FromDestination : options.ElementName]?.ToString();
			if(string.IsNullOrWhiteSpace(path))
			{
				throw new ArgumentNullException(
					nameof(options),
					$"Cannot find value ({(options.IsFromSpecified ? options.FromDestination : options.ElementName)}) in page headers"
				);
			}

			bool takeCertainElement = false;
			if(!path.EndsWith(".nml"))
			{
				if(!options.IsFromSpecified)
					path += ".nml";
				else if(options.ElementName.EndsWith(".nml"))
					path += options.ElementName;
				else
					path = $"{path}{options.ElementName}.nml";
			}
			else {
				takeCertainElement = true;
			}
			if(File.Exists(path))
				importText = File.ReadAllText(path);
			else
			{
				HttpClient client = new();
				try
				{
					var resource = client.GetStringAsync(path).GetAwaiter().GetResult();

					if (!string.IsNullOrWhiteSpace(resource))
						importText = resource;
				}
				catch(Exception) { }
			}

			try {
				NMLDocument document = NMLDocumentLoader.Load(importText);
				if(!takeCertainElement) return document.FirstOrDefault();
				return document.FirstOrDefault(options.ElementName);
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			return null;
		}

		public IElement? Visit(ConditionalOptions options)
		{
			Type? objectType = null;
			string compareToString = string.Empty;
			if(options.CompareToTokens is ConcatValue concat)
			{
				objectType = typeof(string);
				compareToString = valueVisitor.Visit(concat);
			}
			else if(options.CompareToTokens is DataValue data)
			{
				objectType = data.DataType;
				compareToString = data.Value.ToString();
			}

			string castedProperty =
				objectType == typeof(int) ? $"(int){options.Property}"
				: objectType == typeof(bool) ? $"(bool){options.Property}"
				: $"{options.Property}.ToString()";

			string conditionString = $"(page, parent) => {castedProperty} {options.CompareTokens} {compareToString}";

			var scriptOptions = ScriptOptions.Default.AddReferences(typeof(PageContext).Assembly).AddImports("System", "NML.Parser.Contexts");
			var condition = CSharpScript.EvaluateAsync<Func<PageContext, ElementContext, bool>>(conditionString, scriptOptions).GetAwaiter().GetResult();

			if(condition(pageContext, options.Element.Context))
				return options.Element;
			return null;
		}
	}
}