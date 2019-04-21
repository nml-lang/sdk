using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System;

namespace parser
{
    public class Parser
    {
        public Parser Parse()
        {
            string input = @"
                root {
                    title 'Basic example'

                rec:
                {
                    width 250
                    height 200
                    colour colour.white
                    background colour.black

                    img {
                        source: 'pics/smallblue.png'
                        x: canvas.height / 2
                    }
                        img {
                        source: 'pics/logo.png'
                    }
                }
            ";
            ICharStream stream = CharStreams.fromstring(input);
            ITokenSource lexer = new nmlLexer(stream);
            ITokenStream token = new CommonTokenStream(lexer);
            nmlParser parser = new nmlParser(token)
            {
                BuildParseTree = true
            };
            IParseTree tree = parser.StartRule();

            return this;
        }
    }
}
