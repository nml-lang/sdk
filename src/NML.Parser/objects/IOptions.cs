using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Options
{
	public interface IOptions
	{
		public IElement Element { get; set; }

		public IElement Accept(IOptionVisitor<IElement> visitor);
	}
}