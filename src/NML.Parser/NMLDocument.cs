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
			Declarations = new List<HeaderValue>();
			Variables = new List<HeaderValue>();
			Children = new List<IElement>();
			Context = new PageContext();
		}

		public NMLDocument(IElement element)
		{
			if(element.Attributes.Count > 0 && element.Attributes.All(o => o.GetType() == typeof(HeaderValue)))
			{
				Declarations = element.Attributes.Cast<HeaderValue>().Where(o => o.Type == HeaderValue.HeaderType.Declare).ToList();
				Variables = element.Attributes.Cast<HeaderValue>().Where(o => o.Type == HeaderValue.HeaderType.Set).ToList();
			}
			else
			{
				Declarations = new List<HeaderValue>();
				Variables = new List<HeaderValue>();
			}

			Children = element.Children;
			Context = new PageContext();
		}

		public ICollection<HeaderValue> Declarations { get; init; }
		public ICollection<HeaderValue> Variables { get; init; }
		public ICollection<IElement> Children { get; init; }

		public readonly PageContext Context;

		public string Accept(IElementVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}