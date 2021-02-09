using System;
using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Values
{
	public class ConditionalValue : IValue
	{
		public string Attribute { get; set; }

		public IElement Element { get; set; }

		public Func<NMLDocument, object> Condition { get; set; }

		public string Accept(IValueVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}
