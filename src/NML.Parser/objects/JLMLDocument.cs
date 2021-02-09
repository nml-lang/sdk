using System.Collections.Generic;
using NML.Parser.Contexts;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Parser.Objects
{
	public class NMLDocument : IElement
	{
		public NMLDocument()
		{
			Attributes = new List<IValue>();
			Children = new List<IElement>();
			current = new ElementContext(this);
		}

		public NMLDocument(IElement element)
		{
			Attributes = element.Attributes;
			Children = element.Children;
			current = new ElementContext(this);
		}

		public ICollection<IValue> Attributes { get; init; }
		public ICollection<IElement> Children { get; init; }

		private ElementContext current;
		public ElementContext Current { get => current; set => current = value; }

		public string Accept(IElementVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}

		public object Clone()
		{
			throw new System.NotImplementedException();
		}
	}
}