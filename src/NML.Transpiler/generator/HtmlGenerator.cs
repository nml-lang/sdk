using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NML.Parser.Contexts;

namespace NML.Transpiler.Generators
{
	public class HtmlGenerator : IGenerator
	{
		private static Func<StringBuilder, string?, StringBuilder> Append = (StringBuilder builder, string? value) => builder.Append(value);
		public static void SetFormatting(bool format)
		{
			if(format)
				Append = (StringBuilder builder, string? value) => builder.AppendLine(value);
			else if(!format)
				Append = (StringBuilder builder, string? value) => builder.Append(value);
		}

		/// <summary>
		/// Create the base body tag with provided options and child element/objects.
		/// </summary>
		public string CreateBaseElement(PageContext pageOptions, IEnumerable<string> childObjs)
		{
			StringBuilder builder = new StringBuilder();

			Append(builder, "<html>");
			Append(builder, "<head>");

			var title = pageOptions["title"];
			if(title != null)
				Append(builder, $"<title>{title}</title>");

			Append(builder, "</head>");
			Append(builder, $"<body>");

			foreach (var child in childObjs) Append(builder, child);

			Append(builder, "</body>");
			Append(builder, "</html>");

			return builder.ToString();
		}

		/// <summary>
		/// Create a html tag from provided id, attributes and child element/objects.
		/// In format &lt;{<paramref name="id" />} {<paramref name="attrs" />}&gt; if no elements/objects provided.
		/// Otherwise in normal html format &lt;{<paramref name="id" />} {<paramref name="attrs" />}&gt;&lt;/{<paramref name="id" />}&gt;
		/// </summary>
		public string CreateElement(string id, IEnumerable<string> text, IEnumerable<string> attrs, IEnumerable<string> childObjs)
		{
			StringBuilder builder = new();

			string htmlId = GetHtmlElementNameFromId(id);

			builder.Append($@"<{htmlId} {string.Join(' ', attrs)}");

			if (text.Any() || childObjs.Any()) Append(builder, ">");
			else
			{
				builder.Append(" />");
				return builder.ToString();
			}

			foreach (var item in text) Append(builder, item);
			foreach (var item in childObjs) Append(builder, item);

			Append(builder, $"</{htmlId}>");

			return builder.ToString();
		}

		public string CreateAttribute(string name, string value)
		{
			if(name == "text") return value;
			return $@"{GetHtmlAttrFromId(name)}=""{value}""";
		}

		public static string GetHtmlAttrFromId(string identifier) => identifier switch
		{
			"tags" => "class",
			_ => identifier,
		};

		public static string GetHtmlElementNameFromId(string identifier) => identifier switch
		{
			"link" => "a",
			"description" => "figcaption",
			_ => identifier,
		};
	}
}