using System.Collections.Generic;
using System.Linq;
using NML.Parser.Contexts;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Parser.Objects
{
	public class NMLDocument
	{
		public NMLDocument()
		{
			Attributes = new List<HeaderValue>();
			Children = new List<IElement>();
			Context = new PageContext();
		}

		public NMLDocument(IElement element)
		{
			if(element.Attributes.Count > 0 && element.Attributes.All(o => o.GetType() == typeof(HeaderValue)))
				Attributes = element.Attributes.Cast<HeaderValue>().ToList();
			else
				Attributes = new List<HeaderValue>();
			Children = element.Children;
			Context = new PageContext();
		}

		public ICollection<HeaderValue> Attributes { get; init; }
		public ICollection<IElement> Children { get; init; }

		public readonly PageContext Context;

		public string Accept(IElementVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}