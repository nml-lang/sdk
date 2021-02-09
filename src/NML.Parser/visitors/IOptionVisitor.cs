using NML.Parser.Objects.Options;

namespace NML.Parser.Visitors
{
	public interface IOptionVisitor<T>
	{
		public T? Visit(ConditionalOptions value);

		public T? Visit(ImportOptions value);
	}
}
