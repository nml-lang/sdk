using System;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Values
{
	public class VariableValue : DataValue
	{
		public new Type DataType { get; } = typeof(object);

		public override string Accept(IValueVisitor<string> visitor) => visitor.Visit(this);
	}
}