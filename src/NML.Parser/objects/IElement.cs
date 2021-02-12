using System;
using System.Collections.Generic;
using NML.Parser.Contexts;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Parser.Objects.Elements
{
	public interface IElement : ICloneable
	{
		public ElementContext Context { get; set; }

		public ICollection<IValue> Attributes { get; init; }
		public ICollection<IElement> Children { get; init; }

		public string Accept(IElementVisitor<string> visitor);
	}

	public interface IElementOptions : IElement, ICloneable
	{
		#nullable enable

		// Options when element has import
		public ImportOptions? ImportOptions { get; set; }

		// Options when element has a condition
		public ConditionalOptions? ConditionalOptions { get; set; }

		// Options when element has a condition
		public LoopOptions? LoopOptions { get; set; }

		public void LoadImport(IElement importedElement);
	}
}