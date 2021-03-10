grammar NML;

@header { #pragma warning disable 3021 }

// Parser
nml			: headers? element+;

headers		: (setheader | assignheader)+;
setheader	: SET PROPERTY_NAME value SEMICOLON?;
assignheader: DECLARE IDENTIFIER STRING SEMICOLON?;

element		: elementkey SEMICOLON | elementkey? OPEN_BRACE (pair | element | setheader)* CLOSE_BRACE;
elementkey	: IDENTIFIER ('#' IDENTIFIER)? COLON with? loop? when?;

with		: USING IDENTIFIER (FROM IDENTIFIER)?;
loop		: FOR IDENTIFIER IN (PROPERTY_NAME | IDENTIFIER);
when		: WHEN PROPERTY_NAME COMPARE_TOKENS (STRING | NUMBER | LITERAL | concat);

pair		: key COLON? value SEMICOLON?;
key			: IDENTIFIER;
value		: STRING
			| PROPERTY_NAME
			| IDENTIFIER
			| NUMBER
			| LITERAL
			| concat
			| list;

//math		: op=ADDICTIVE_OPERATORS value
//			| op=MULTIPLICATIVE_OPERATORS value;
//whenthen	: WHEN PROPERTY_NAME COMPARE_TOKENS USABLE_TOKENS THEN value (ELSE value)?;

list		: '(' ((STRING | NUMBER | LITERAL) ','?)+ ')' | '(' ')';
concat		: DOLLAR_SIGN '(' ((STRING | NUMBER) ','?)+ ')' | '(' ')';

// Dropped lexer expressions
// WITH_EXPRESSION		: 'with' '(' IDENTIFIER ')';
// LAMBDA_EXPRESSION	: FUNCTION_SIGNATURE '=>' '{' '}' | FUNCTION_SIGNATURE '=>' STRING;

// Lexer characters
OPEN_BRACE					: '{';
CLOSE_BRACE					: '}';
COLON						: ':';
SEMICOLON					: ';';
COMPARE_TOKENS				: '<' | '>' | '<=' | '>=';
ADDICTIVE_OPERATORS			: '+' | '-';
MULTIPLICATIVE_OPERATORS	: '*' | '/' | '%';
DOT							: '.';
DOLLAR_SIGN					: '$';

// Lexer words
SET		: 'set';
DECLARE	: 'declare';
USING	: 'using';
FOR		: 'for';
WHEN	: 'when' | 'if';
IN		: 'in';
FROM	: 'from';
THEN	: 'then';
ELSE	: 'else';

// Lexer
IDENTIFIER			: [a-zA-Z] ([a-zA-Z0-9_-])*;
STRING				: '"' DOUBLE_QUOTE_CHAR* '"' | '\'' SINGLE_QUOTE_CHAR* '\'';
NUMBER				: '-'? INT ('.' [0-9]+)? EXP?;
LITERAL				: 'true' | 'false';

PROPERTY_NAME		: IDENTIFIER (DOT IDENTIFIER)*;

// Lexer fragments
fragment DOUBLE_QUOTE_CHAR	: ~["\\\r\n] | ESCAPE_SEQUENCE;
fragment SINGLE_QUOTE_CHAR	: ~['\\\r\n] | ESCAPE_SEQUENCE;

fragment ESCAPE_SEQUENCE	: '\\' ( NEWLINE
							| UNICODE_SEQUENCE			// \u1234
							| ['"\\/bfnrtv]				// single escape char
							| ~['"\\bfnrtv0-9xu\r\n]	// non escape char
							| '0'						// \0
							| 'x' HEX HEX				// \x3a
							);

fragment UNICODE_SEQUENCE	: 'u' HEX HEX HEX HEX;

fragment SYMBOL				: ('+' | '-')?;
fragment HEX				: [0-9a-fA-F];
fragment INT				: '0' | [1-9] [0-9]*;
fragment EXP				: [Ee] SYMBOL INT;
fragment NEWLINE			: '\r\n' | [\r\n\u2028\u2029];


LINE_COMMENT	: '//' ~[\r\n]* -> skip;
WS				: [ \t\n\r]+ -> skip;