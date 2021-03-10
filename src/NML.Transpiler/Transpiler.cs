using NML.Parser;
using NML.Parser.Contexts;
using NML.Transpiler.Generators;
using NML.Transpiler.Visitors;
using NML.Parser.Objects;

namespace NML.Transpiler
{
	/// <summary>
	/// A transpiler for the hypertext markup language
	/// </summary>
	public class Transpiler : IScriptable
	{
		/// <summary>
		/// Sets wether the transpiled document needs to be formatted (e.g. new lines between lines)
		/// </summary>
		/// <param name="format">True is the document needs to formatted. False if not</param>
		/// <returns>The current HTML transpiler instance for chaining</returns>
		public Transpiler SetFormatting(bool format)
		{
			HtmlGenerator.SetFormatting(format);

			return this;
		}

		/// <summary>
		/// Transpiles the given value into html
		/// </summary>
		/// <param name="value">The parsed NML document</param>
		/// <returns>An html string that represents the given document</returns>
		public string ToScript(NMLDocument value, IGenerator generator)
		{
			ElementVisitor visitor = new(generator);
			return value.Accept(visitor);
		}
	}
}
