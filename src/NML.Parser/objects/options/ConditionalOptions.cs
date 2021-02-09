using System;
using System.Collections.Generic;
using NML.Parser.Contexts;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace NML.Parser.Objects.Options
{
	public class ConditionalOptions : IOptions
	{
		public string Property;
		public string CompareTokens;
		public IValue CompareToTokens;

		public IElement Element { get; set; }

		public IElement Accept(IOptionVisitor<IElement> visitor) => visitor.Visit(this);
	}
}
