using System;
using System.Collections.Generic;
using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Values
{
	public class DataValue : IValue
	{
		public string Attribute { get; set; }

		public IElement Element { get; set; }

		public Type DataType { get; init; }
		public object Value { get; init; }

		public virtual string Accept(IValueVisitor<string> visitor)
		{
			return visitor.Visit(this);
		}
	}
}
