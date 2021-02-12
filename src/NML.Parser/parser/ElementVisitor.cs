using System;
using System.Linq;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using NML.Parser.Contexts;
using NML.Parser.Generated;
using NML.Parser.Objects;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Options;
using NML.Parser.Objects.Values;

namespace NML.Parser.Parsers
{
	public class DocumentVisitor : Generated.NMLBaseVisitor<NMLDocument>
	{
		private readonly ElementVisitor elementVisitor = new();
		private readonly ValueVisitor valueVisitor = new();

		public override NMLDocument VisitNml([NotNull] NMLParser.NmlContext context)
		{
			NMLDocument document;

			var headerContext = context.headers();
			if (headerContext != null)
				document = headerContext.Accept(this);
			else
				document = new NMLDocument();

			var elementContexts = context.element();
			for (int i = 0; i < elementContexts.Length; i++)
			{
				var child = elementContexts[i].Accept(elementVisitor);
				document.Children.Add(child);
			}

			return document;
		}

		public override NMLDocument VisitHeaders([NotNull] NMLParser.HeadersContext context)
		{
			var declareHeaders = context.assignheader();
			var setHeaders = context.setheader();

			NMLDocument baseScript = new();

			for (int i = 0; i < declareHeaders.Length; i++)
			{
				if (declareHeaders[i].Accept(valueVisitor) is HeaderValue value)
					baseScript.Attributes.Add(value);
			}

			for (int i = 0; i < setHeaders.Length; i++)
			{
				if(setHeaders[i].Accept(valueVisitor) is HeaderValue value)
					baseScript.Attributes.Add(value);
			}

			return baseScript;
		}
	}

	public class ElementVisitor : Generated.NMLBaseVisitor<IElement>
	{
		private readonly ValueVisitor valueVisitor = new();
		private readonly OptionVisitor optionVisitor = new();

		private IElement? currentElement = null;

		public override IElement VisitElement([NotNull] NMLParser.ElementContext context)
		{
			IElement element = GetNamedElementOrDefault(context.elementkey());

			NMLParser.PairContext[] pairContext = context.pair();
			for (int i = 0; i < pairContext.Length; i++)
			{
				var value = pairContext[i].Accept(valueVisitor);
				value.Element = element;
				element.Attributes.Add(value);
			}

			element.Context = new ElementContext(element, currentElement);

			currentElement = element;
			NMLParser.ElementContext[] elementContext = context.element();
			for (int i = 0; i < elementContext.Length; i++)
				element.Children.Add(elementContext[i].Accept(this));

			return element;
		}

		public override IElement VisitElementkey([NotNull] NMLParser.ElementkeyContext context)
		{
			NMLParser.WithContext withContext = context.with();
			NMLParser.WhenContext whenContext = context.when();
			NMLParser.LoopContext loopContext = context.loop();

			ImportOptions? with = null;
			ConditionalOptions? when = null;
			LoopOptions? loop = null;

			if(withContext != null) with = withContext.Accept(optionVisitor) as ImportOptions;
			if(whenContext != null) when = whenContext.Accept(optionVisitor) as ConditionalOptions;
			if(loopContext != null) loop = loopContext.Accept(optionVisitor) as LoopOptions;

			ITerminalNode[] ids = context.IDENTIFIER();

			string? identifier = ids.Length > 1 ? ids[1].GetTextValue() : null;
			NamedElement element = GetNamedElement(ids[0].GetTextValue(), identifier, with, when, loop);

			if(element.ImportOptions != null)		element.ImportOptions.Element = element;
			if(element.ConditionalOptions != null)	element.ConditionalOptions.Element = element;
			if(element.LoopOptions != null)			element.LoopOptions.Element = element;

			return element;
		}

		public override IElement VisitErrorNode(IErrorNode node)
		{
			return base.VisitErrorNode(node);
		}

		public override IElement VisitTerminal(ITerminalNode node)
		{
			return base.VisitTerminal(node);
		}

		private IElement GetNamedElementOrDefault(NMLParser.ElementkeyContext context)
		{
			IElement key;
			if (context == null)
				key = new Element();
			else
				key = context.Accept(this);

			return key;
		}

		private static NamedElement GetNamedElement(string name, string? identifier, ImportOptions? with, ConditionalOptions? when, LoopOptions? loop)
		{
			if(Enum.TryParse(name, true, out ElementName elementName))
			{
				return elementName switch
				{
					ElementName.Select => new SelectElement { Identifier = identifier, ImportOptions = with, ConditionalOptions = when, LoopOptions = loop },
					ElementName.Image => new ImageElement { Identifier = identifier, ImportOptions = with, ConditionalOptions = when, LoopOptions = loop },
					_ => throw new NotSupportedException($"{name} element is not supported"),
				};
			}
			else
			{
				return new NamedElement
				{
					Name = name,
					Identifier = identifier,
					ImportOptions = with,
					ConditionalOptions = when,
					LoopOptions = loop,
				};
			}
		}

	}
}