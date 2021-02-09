using NML.Parser.Objects.Values;

namespace NML.Parser.Visitors
{
	public interface IValueVisitor<T>
	{
		public T Visit(CalculatedValue value);

		public T Visit(DataValue value);

		public T Visit(ConditionalValue value);

		public T Visit(VariableValue value);

		public T Visit(ConcatValue value);
	}
}
