using System.Collections.Generic;
using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Values
{
	public class ConcatValue : IValue
	{
		public string Attribute { get; set; }

		public IElement Element { get; set; }

		public List<object> Values { get; init; }

		public string Accept(IValueVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}