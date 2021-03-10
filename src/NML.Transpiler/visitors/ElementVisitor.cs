using System;
using System.Collections.Generic;
using System.Linq;
using NML.Parser.Contexts;
using NML.Parser.Objects;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;
using NML.Transpiler.Generators;

namespace NML.Transpiler.Visitors
{
	/// <summary>
	/// Visits elements and translates it into html
	/// </summary>
	public class ElementVisitor : IElementVisitor<string>
	{
		private readonly ValueVisitor valueVisitor;
		private readonly OptionVisitor optionVisitor;

		private readonly IGenerator generator;

		public static NMLDocument BaseScript { get; private set; }

		public ElementVisitor(IGenerator generator)
		{
			this.generator = generator;

			valueVisitor = new ValueVisitor(generator);
			optionVisitor = new OptionVisitor(valueVisitor);
		}

		public string Visit(NMLDocument value)
		{
			BaseScript = value;

			// Get values that could only be attributes in html
			IEnumerable<string> objList = ResolveChildElementsOptions(value.Children).Select(o => o.Accept(this));

			return generator.CreateBaseElement(value.Context, objList);
		}

		public string Visit(Element value)
		{
			IEnumerable<string> textList = value.Attributes.Where(o => o.Attribute == "text").Select(o => o.Accept(valueVisitor));
			IEnumerable<string> attrList = value.Attributes.Where(o => o.Attribute != "text").Select(o => o.Accept(valueVisitor));

			// Get values that could only be attributes in html
			IEnumerable<string> objList = ResolveChildElementsOptions(value.Children).Select(o => o.Accept(this));

			return generator.CreateElement("div", textList, attrList, objList);
		}

		public string Visit(NamedElement value)
		{
			IEnumerable<string> textList = value.Attributes.Where(o => o.Attribute == "text").Select(o => o.Accept(valueVisitor));
			IEnumerable<string> attrList = value.Attributes.Where(o => o.Attribute != "text").Select(o => o.Accept(valueVisitor));

			// Get values that could only be attributes in html
			IEnumerable<string> objList = ResolveChildElementsOptions(value.Children).Select(o => o.Accept(this));

			return generator.CreateElement(value.Name, textList, attrList, objList);
		}

		public string Visit(SelectElement value)
		{
			IEnumerable<string> textList = value.Attributes.Where(o => o.Attribute == "text").Select(o => o.Accept(valueVisitor));
			IEnumerable<string> attrList = value.Attributes
				.Where(o => o.Attribute != "text" && o.GetType() != typeof(ListValue))
				.Select(o => o.Accept(valueVisitor));

			// Select element can only have options as children to all others are ignored
			IEnumerable<string> objList = ResolveChildElementsOptions(
				value.Children.Where(o => o is NamedElement nEl && nEl.Name.Equals("option", StringComparison.OrdinalIgnoreCase))
			).Select(o => o.Accept(this)).ToList();

			return generator.CreateElement("select", textList, attrList, objList);
		}

		public string Visit(ImageElement value)
		{
			NamedElement? source = null;
			var sourceList = value.Children
				.Where(o => o is NamedElement nEl && nEl.Name.Equals("source", StringComparison.OrdinalIgnoreCase))
				.Cast<NamedElement>();
			foreach (var item in sourceList)
			{
				if(item.ConditionalOptions != null)
				{
					// condition is true if not null
					var conditionElement = optionVisitor.Visit(item.ConditionalOptions);
					if (conditionElement != null) source = item;
				}
				else
				{
					source = item;
				}
			}

			if(source != null)
			{
				var src = source.Attributes
					.Where(o => o is DataValue data && data.Attribute.Equals("src", StringComparison.OrdinalIgnoreCase))
					.Cast<DataValue>().First();

				value.Attributes.Add(src);
			}

			IEnumerable<string> textList = value.Attributes.Where(o => o.Attribute == "text").Select(o => o.Accept(valueVisitor));
			IEnumerable<string> attrList = value.Attributes.Where(o => o.Attribute != "text" && o.GetType() != typeof(ListValue)).Select(o => o.Accept(valueVisitor));

			NamedElement? description = value.Children
				.Where(o => o is NamedElement nEl && nEl.Name.Equals("description", StringComparison.OrdinalIgnoreCase))
				.Cast<NamedElement>().FirstOrDefault();

			var imgElement = generator.CreateElement("img", textList, attrList, Enumerable.Empty<string>());
			if(description == null) return imgElement;

			List<string> objList = new()
			{
				imgElement,
				description.Accept(this),
			};

			return generator.CreateElement("figure", textList, Enumerable.Empty<string>(), objList);
		}

		/// <summary>
		/// Resolves child element import, condition and loop options.
		/// When using a loop option child element does not need to be resolved further
		/// </summary>
		private List<IElement> ResolveChildElementsOptions(IEnumerable<IElement> elements)
		{
			var elementList = new List<IElement>();
			foreach (var el in elements)
			{
				if(el is not IElementOptions element)
				{
					elementList.Add(el);
					continue;
				}

				if (element.ImportOptions is not null)
				{
					var import = optionVisitor.Visit(element.ImportOptions);
					element.LoadImport(import);
				}

				if (element.LoopOptions is null && element.ConditionalOptions is null)
				{
					elementList.Add(element);
				}


				if (element.LoopOptions is not null)
				{
					var listValue = element.Context[element.LoopOptions.ListRef];
					if(listValue is not null && listValue is IEnumerable<object> list)
					{
						foreach (var item in list)
						{
							if(element.Clone() is not IElement loopElement) continue;
							loopElement.Context[element.LoopOptions.ValueRef] = new DataValue {
								Attribute = element.LoopOptions.ValueRef,
								DataType = item.GetType(),
								Value = item,
							};

							elementList.Add(loopElement);
						}
					}
				}

				if (element.ConditionalOptions is not null)
				{
					var conditionElement = optionVisitor.Visit(element.ConditionalOptions);
					if(conditionElement != null) elementList.Add(conditionElement);
				}
			}

			return elementList;
		}
	}
}
