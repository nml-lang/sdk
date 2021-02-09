using Antlr4.Runtime;
using NML.Parser.Objects;
using NML.Parser.Parsers;

namespace NML.Parser
{
	/// <summary>
	/// Document loader for NML files
	/// </summary>
	public static class NMLDocumentLoader
	{
		/// <summary>
		/// Loads given text and parses it into a NML document
		/// The child or children of this object are the root element of the parsed text
		/// </summary>
		/// <param name="fileText">Text to be parsed</param>
		/// <returns>An NML document that can either given to a transpiler (e.g. the NML.Transpiler HtmlTranspiler)</returns>
		public static NMLDocument Load(string fileText)
		{
			Generated.NMLLexer lexer = new(new AntlrInputStream(fileText));
			Generated.NMLParser parser = new(new CommonTokenStream(lexer));

			parser.RemoveErrorListeners();
			parser.AddErrorListener(new NMLErrorListener());

			try {
				ElementVisitor visitor = new();
				return (NMLDocument)parser.nml().Accept(visitor);
			}
			catch(RecognitionException rex)
			{
				throw rex.GetBaseException();
			}
		}
	}
}
