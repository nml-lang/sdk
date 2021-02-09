using NML.Parser.Objects;
using NML.Parser.Objects.Elements;

namespace NML.Parser.Visitors
{
	public interface IElementVisitor<T>
	{
		public T Visit(NMLDocument value);

		public T Visit(Element value);

		public T Visit(NamedElement value);

		public virtual T Visit(SelectElement value) => Visit(value as NamedElement);

		public virtual T Visit(ImageElement value) => Visit(value as NamedElement);

	}
}
