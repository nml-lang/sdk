using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Values
{
	public class HeaderValue : IValue
	{
		public HeaderType Type { get; set; }

		public string Attribute { get; set; }

		public IElement Element { get; set; }

		public object Value { get; set; }

		public string Accept(IValueVisitor<string> visitor)
		{
			throw new System.NotImplementedException("Header value cannot be visited");
		}

		public enum HeaderType
		{
			Declare,
			Set,
		}
	}
}