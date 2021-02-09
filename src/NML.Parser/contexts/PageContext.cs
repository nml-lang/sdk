using System.Collections.Generic;

namespace NML.Parser.Contexts
{
	/// <summary>
	/// Context class for the base page.
	/// Automatically created and assigned on parsing
	/// </summary>
	public class PageContext
	{
		private readonly Dictionary<string, object> props;

		public PageContext()
		{
			props = new Dictionary<string, object>
			{
				{ "width", 1920 }
			};
		}

		public PageContext(Dictionary<string, object> pairs)
		{
			props = pairs;
		}

		/// <summary>
		/// Query for a given property.
		/// Searches through the page properties set by either a set declaration or preset
		/// </summary>
		/// <param name="name">Name of property to be looking for</param>
		/// <returns>The searched for property object or null if not found</returns>
		public object? this[string name]
		{
			get {
				// All page properties have to be lower case to avoid null returns
				string lowerName = name.ToLower();

				if(!props.ContainsKey(lowerName)) return null;
				return props.GetValueOrDefault(lowerName);
			}
			set {
				// All page properties have to be lower case to avoid null returns
				string lowerName = name.ToLower();

				if (!props.ContainsKey(lowerName)) return;
				var val = props.GetValueOrDefault(lowerName);

				if(value == null) return;
				props[lowerName] = value.ToString();
			}
		}

		/// <summary>
		/// Adds a range of properties to the context
		/// </summary>
		/// <param name="objects"></param>
		public void AddRange(Dictionary<string, string> pairs)
		{
			foreach (var item in pairs)
			{
				props.Add(item.Key, item.Value);
			}
		}
	}
}
