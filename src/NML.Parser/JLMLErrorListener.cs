using System.IO;
using Antlr4.Runtime;

namespace NML.Parser
{
	public class NMLErrorListener : IAntlrErrorListener<IToken>
	{
		public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
		{
			if(recognizer is Generated.NMLParser parser)
				output.WriteLine($"Error at {line}:{charPositionInLine}. Unexpected between {parser.CurrentToken.Text} and {offendingSymbol.Text}");
			else
				output.WriteLine($"Error at {line}:{charPositionInLine}. Unexpected at {offendingSymbol.Text}");
		}
	}
}
