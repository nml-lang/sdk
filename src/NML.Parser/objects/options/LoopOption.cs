using System;
using NML.Parser.Objects.Elements;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Options
{
	public class LoopOptions : IOptions
	{
		public string ListRef { get; init; }
		public string ValueRef { get; init; }
		public IElement Element { get; set; }

		public IElement Accept(IOptionVisitor<IElement> visitor) => throw new NotSupportedException("Loop options cannot be translated");
	}
}
