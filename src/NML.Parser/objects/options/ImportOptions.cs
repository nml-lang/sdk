using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Options
{
	public class ImportOptions : IOptions
	{
		public string ElementName { get; init; }
		public string FromDestination { get; init; }
		public bool IsFromSpecified { get; init; }

		public IElement Element { get; set; }

		public IElement Accept(IOptionVisitor<IElement> visitor) => visitor.Visit(this);
	}
}
