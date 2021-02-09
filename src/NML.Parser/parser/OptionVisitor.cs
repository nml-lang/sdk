using System;
using System.Collections.Generic;
using System.Linq;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using NML.Parser.Generated;
using NML.Parser.Objects;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace NML.Parser.Parsers
{
	public class OptionVisitor : Generated.NMLBaseVisitor<IOptions>
	{
		private readonly ValueVisitor valueVisitor = new();
		public override ConditionalOptions VisitWhen([NotNull] NMLParser.WhenContext context)
		{
			string property = context.PROPERTY_NAME().GetTextValue();
			string[] splitProperty = property.Split('.');
			property = $"{splitProperty[0]}[\"{string.Join('.', splitProperty[1..])}\"]";

			string compareTokens = context.COMPARE_TOKENS().GetTextValue();

			DataValue? codedValue = null;

			if (context.STRING() is not null)	codedValue = ValueVisitor.GetDataValueFromNode(context.STRING(), typeof(string));
			if (context.NUMBER() is not null)	codedValue = ValueVisitor.GetDataValueFromNode(context.NUMBER(), typeof(int));
			if (context.LITERAL() is not null)	codedValue = ValueVisitor.GetDataValueFromNode(context.LITERAL(), typeof(bool));


			IValue comparableTokens;
			if(context.concat()?.Accept(valueVisitor) is ConcatValue concatValue) comparableTokens = concatValue;
			else if(codedValue != null) comparableTokens = codedValue;
			else throw new ArgumentNullException(nameof(comparableTokens), "No values to compare to");

			return new ConditionalOptions
			{
				Property = property,
				CompareTokens = compareTokens,
				CompareToTokens = comparableTokens,
			};
		}

		public override ImportOptions VisitWith([NotNull] NMLParser.WithContext context)
		{
			var ids = context.IDENTIFIER();

			ITerminalNode elementName = ids[0];
			ITerminalNode fromDestination = ids.Length > 1 ? ids[1] : null;

			return new ImportOptions
			{
				ElementName = elementName.GetTextValue(),
				FromDestination = fromDestination?.GetTextValue(),
				IsFromSpecified = fromDestination != null,
			};
		}

		public override LoopOptions VisitLoop([NotNull] NMLParser.LoopContext context)
		{
			var ids = context.IDENTIFIER();

			ITerminalNode loopIdentifier = ids[0];
			ITerminalNode loopProperty = ids.Length > 1 ? ids[1] : context.PROPERTY_NAME();

			return new LoopOptions
			{
				ListRef = loopProperty.GetTextValue(),
				ValueRef = loopIdentifier.GetTextValue(),
			};
		}
	}
}
