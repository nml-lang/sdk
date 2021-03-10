using System.Collections.Generic;
using System.Linq;
using System.Text;
using NML.Parser.Contexts;
using NML.Transpiler.Generators;
using NML.Parser.Objects.Values;
using NML.Parser.Visitors;

namespace NML.Transpiler.Visitors
{
	/// <summary>
	/// Visits values and translates it into html for elements to use
	/// </summary>
	public class ValueVisitor : IValueVisitor<string>
	{
		private readonly IGenerator generator;

		public ValueVisitor(IGenerator generator)
		{
			this.generator = generator;
		}

		public string Visit(DataValue value)
		{
			return generator.CreateAttribute(value.Attribute, value.Value.ToString());
		}

		public string Visit(CalculatedValue value)
		{
			return generator.CreateAttribute(value.Attribute, 5.ToString());
		}

		public string Visit(ConditionalValue value)
		{
			var conditionedValue = value.Condition(ElementVisitor.BaseScript);
			return generator.CreateAttribute(value.Attribute, conditionedValue.ToString());
		}

		public string Visit(VariableValue value)
		{
			return generator.CreateAttribute(value.Attribute, GetValue(value).ToString());
		}

		public string Visit(ConcatValue value)
		{
			string?[] builder = new string[value.Values.Count];
			for (int i = 0; i < value.Values.Count; i++)
			{
				object? listValue = value.Values[i];
				if(listValue is null) continue;
				string id = listValue.ToString();
				if(TryGetValue(value.Element.Context, id, out object? val))
					builder[i] = val?.ToString();
				else
					builder[i] = id;
			}

			if(string.IsNullOrEmpty(value.Attribute))
				return string.Join(null, builder);
			return generator.CreateAttribute(value.Attribute, string.Join(" ", builder));
		}

		private object? GetValue(DataValue value)
		{
			if(value == null) throw new System.ArgumentNullException(nameof(value), "Provided data value is null");
			string valueId = value.Value.ToString();
			return ElementVisitor.BaseScript.Context[valueId] ?? value.Element.Context[valueId];
		}
		private bool TryGetValue(ElementContext current, string id, out object? value)
		{
			value = null;
			if(string.IsNullOrEmpty(id)) return false;

			value = ElementVisitor.BaseScript.Context[id] ?? current[id];
			return value != null;
		}
	}
}