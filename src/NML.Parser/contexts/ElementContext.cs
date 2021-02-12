using System;
using System.Collections.Generic;
using System.Linq;
using NML.Parser.Objects.Elements;
using NML.Parser.Objects.Values;

namespace NML.Parser.Contexts
{
	/// <summary>
	/// Context class for a given element.
	/// Automatically created and assigned on parsing
	/// </summary>
	public class ElementContext
	{
#nullable enable
		public readonly ElementContext? Parent;
		public readonly Dictionary<string, IValue> Attr;

		/// <summary>
		/// Create a context from the given element and optionally a parent.
		/// While parent is optional it is recommanded for property quering
		/// </summary>
		/// <param name="element">The element a context needs to be created from</param>
		/// <param name="parent">The parent of the given element</param>
		public ElementContext(IElement element, IElement? parent = null)
		{
			Attr = element.Attributes.ToDictionary(k => k.Attribute);
			Parent = parent?.Context;
		}

		/// <summary>
		/// Create a copy of the given context
		/// </summary>
		/// <param name="context">Context to be cloned</param>
		public ElementContext(ElementContext context)
		{
			Parent = context.Parent;
			Attr = new Dictionary<string, IValue>(context.Attr);
		}

		/// <summary>
		/// Query for a given property.
		/// Searches through this and parent elements
		/// </summary>
		/// <param name="name">Name of property to be looking for</param>
		/// <returns>The searched for property object or null if not found</returns>
		/// <exception cref="ArgumentNullException">Thrown when parent is needed but is null</exception>
		public object? this[string name]
		{
			get
			{
				if(string.IsNullOrEmpty(name)) return null;
				ElementContext context = this;

				if(name.Contains("."))
				{
					string[] nameParts = name.Split(".");
					for (int i = 0; i < nameParts.Length - 1; i++)
					{
						if(nameParts[i] == "parent")
							context = context.Parent ?? throw new ArgumentNullException(nameof(context.Parent), "Parent of context is null while it used in defining");
					}
					name = nameParts[^1];
				}
				if(context == null) return null;

				IValue? value = context.Attr.GetValueOrDefault(name);
				if (value is DataValue dataValue)
					return dataValue.Value;
				else if (value is ListValue listValue)
					return listValue.Values;
				else if(value is null && Parent is not null)
					return context.Parent[name];

				return null;
			}
			set
			{
				if(value is not IValue valueObject) return;
				Attr[name] = valueObject;
			}
		}
	}
}
