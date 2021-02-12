using System.Collections.Generic;
using NML.Parser.Contexts;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Elements
{
	public class Element : IElement
	{
		public Element()
		{
			Attributes = new List<IValue>();
			Children = new List<IElement>();
			Context = null;
		}

		public ICollection<IValue> Attributes { get; init; }
		public ICollection<IElement> Children { get; init; }
		public ElementContext Context { get; set; }

		public string Accept(IElementVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}

		public object Clone()
		{
			return new Element
			{
				Attributes = new List<IValue>(Attributes),
				Children = new List<IElement>(Children),
				Context = new ElementContext(Context),
			};
		}
	}
}
