using System;
using System.Linq;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using NML.Parser.Generated;
using NML.Parser.Objects.Values;

namespace NML.Parser.Parsers
{
	/// <summary>
	/// Visitor for NML values/attributes.
	/// Parses NML values/attributes using antlr
	/// </summary>
	public class ValueVisitor : NMLBaseVisitor<IValue>
	{
		public override IValue VisitPair([NotNull] NMLParser.PairContext context)
		{
			IValue datavalue;
			var value = context.value();

			var list = value.list();
			var concat = value.concat();

			if(list != null) datavalue = list.Accept(this);
			else if(concat != null) datavalue = concat.Accept(this);
			else datavalue = value.Accept(this);

			datavalue.Attribute = context.key().GetTextValue();

			return datavalue;
		}

		public override IValue VisitValue([NotNull] NMLParser.ValueContext context)
		{
			ITerminalNode @string = context.STRING();
			ITerminalNode identif = context.IDENTIFIER();
			ITerminalNode propert = context.PROPERTY_NAME();
			ITerminalNode integer = context.NUMBER();
			ITerminalNode literal = context.LITERAL();

			if(@string != null) return GetDataValueFromNode(@string, typeof(string));
			if(integer != null) return GetDataValueFromNode(integer, typeof(int));
			if(literal != null) return GetDataValueFromNode(literal, typeof(bool));
			if(identif != null) return new VariableValue { Value = identif.GetTextValue() };
			if(propert != null) return new VariableValue { Value = propert.GetTextValue() };

			return context.Accept(this);
		}

		public override ConcatValue VisitConcat([NotNull] NMLParser.ConcatContext context)
		{
			var children = context.children.Skip(2).Take(context.ChildCount - 3).Where(o => o.GetText() != ",");

			return new ConcatValue
			{
				Values = children.Select(o => o.GetTextValue() as object).ToList(),
			};
		}

		public override ListValue VisitList([NotNull] NMLParser.ListContext context)
		{
			var children = context.children.Skip(1).Take(context.ChildCount - 2).Where(o => o.GetText() != ",");
			return new ListValue
			{
				Values = children.Select(o => o.GetTextValue() as object).ToList(),
			};
		}

		public override HeaderValue VisitAssignheader([NotNull] NMLParser.AssignheaderContext context)
		{
			var attrName = context.IDENTIFIER();
			var value = context.STRING();
			return new HeaderValue
			{
				Type = HeaderValue.HeaderType.Declare,
				Attribute = attrName.GetTextValue(),
				Value = value.GetTextValue(),
			};
		}

		public override HeaderValue VisitSetheader([NotNull] NMLParser.SetheaderContext context)
		{
			var attrName = context.PROPERTY_NAME();
			var value = context.STRING();
			return new HeaderValue
			{
				Type = HeaderValue.HeaderType.Set,
				Attribute = attrName.GetTextValue(),
				Value = value.GetTextValue(),
			};
		}

		public static DataValue GetDataValueFromNode(ITerminalNode node, [NotNull] Type type)
		{
			var value = Convert.ChangeType(node.GetTextValue(), type);
			return new DataValue { DataType = type, Value = value };
		}
	}
}
