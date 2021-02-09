using System.Collections.Generic;
using System.Linq;
using NML.Parser.Contexts;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Elements
{
	public class SelectElement : NamedElement, IElement, IElementOptions
	{
		public SelectElement()
		{
			Attributes = new List<IValue>();
			Children = new List<IElement>();
			Current = null;
			Identifier = "select";
		}

		public override string Accept(IElementVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}
