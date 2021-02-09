using System.Collections.Generic;
using NML.Parser.Contexts;

namespace NML.Transpiler.Generators
{
	public interface IGenerator
	{
		public string CreateBaseElement(PageContext pageOptions, IEnumerable<string> childObjs);
		public string CreateElement(string id, IEnumerable<string> text, IEnumerable<string> attrs, IEnumerable<string> childObjs);
		public string CreateAttribute(string name, string value);
	}
}