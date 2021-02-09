//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from NML.g4 by ANTLR 4.9

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace NML.Parser.Generated {
 #pragma warning disable 3021 
using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9")]
[System.CLSCompliant(false)]
public partial class NMLLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, OPEN_BRACE=5, CLOSE_BRACE=6, COLON=7, 
		SEMICOLON=8, COMPARE_TOKENS=9, ADDICTIVE_OPERATORS=10, MULTIPLICATIVE_OPERATORS=11, 
		DOT=12, DOLLAR_SIGN=13, SET=14, DECLARE=15, USING=16, FOR=17, WHEN=18, 
		IN=19, FROM=20, THEN=21, ELSE=22, IDENTIFIER=23, STRING=24, NUMBER=25, 
		LITERAL=26, PROPERTY_NAME=27, LINE_COMMENT=28, WS=29;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "OPEN_BRACE", "CLOSE_BRACE", "COLON", 
		"SEMICOLON", "COMPARE_TOKENS", "ADDICTIVE_OPERATORS", "MULTIPLICATIVE_OPERATORS", 
		"DOT", "DOLLAR_SIGN", "SET", "DECLARE", "USING", "FOR", "WHEN", "IN", 
		"FROM", "THEN", "ELSE", "IDENTIFIER", "STRING", "NUMBER", "LITERAL", "PROPERTY_NAME", 
		"DOUBLE_QUOTE_CHAR", "SINGLE_QUOTE_CHAR", "ESCAPE_SEQUENCE", "UNICODE_SEQUENCE", 
		"SYMBOL", "HEX", "INT", "EXP", "NEWLINE", "LINE_COMMENT", "WS"
	};


	public NMLLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public NMLLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'#'", "'('", "','", "')'", "'{'", "'}'", "':'", "';'", null, null, 
		null, "'.'", "'$'", "'set'", "'declare'", "'using'", "'for'", null, "'in'", 
		"'from'", "'then'", "'else'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, "OPEN_BRACE", "CLOSE_BRACE", "COLON", "SEMICOLON", 
		"COMPARE_TOKENS", "ADDICTIVE_OPERATORS", "MULTIPLICATIVE_OPERATORS", "DOT", 
		"DOLLAR_SIGN", "SET", "DECLARE", "USING", "FOR", "WHEN", "IN", "FROM", 
		"THEN", "ELSE", "IDENTIFIER", "STRING", "NUMBER", "LITERAL", "PROPERTY_NAME", 
		"LINE_COMMENT", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "NML.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static NMLLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x1F', '\x11E', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', '\x65', '\n', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', 
		'\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', 
		'\x5', '\x13', '\x8B', '\n', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x18', '\x3', '\x18', '\a', '\x18', '\xA1', '\n', '\x18', 
		'\f', '\x18', '\xE', '\x18', '\xA4', '\v', '\x18', '\x3', '\x19', '\x3', 
		'\x19', '\a', '\x19', '\xA8', '\n', '\x19', '\f', '\x19', '\xE', '\x19', 
		'\xAB', '\v', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\a', 
		'\x19', '\xB0', '\n', '\x19', '\f', '\x19', '\xE', '\x19', '\xB3', '\v', 
		'\x19', '\x3', '\x19', '\x5', '\x19', '\xB6', '\n', '\x19', '\x3', '\x1A', 
		'\x5', '\x1A', '\xB9', '\n', '\x1A', '\x3', '\x1A', '\x3', '\x1A', '\x3', 
		'\x1A', '\x6', '\x1A', '\xBE', '\n', '\x1A', '\r', '\x1A', '\xE', '\x1A', 
		'\xBF', '\x5', '\x1A', '\xC2', '\n', '\x1A', '\x3', '\x1A', '\x5', '\x1A', 
		'\xC5', '\n', '\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x5', '\x1B', '\xD0', '\n', '\x1B', '\x3', '\x1C', '\x3', '\x1C', 
		'\x3', '\x1C', '\x3', '\x1C', '\a', '\x1C', '\xD6', '\n', '\x1C', '\f', 
		'\x1C', '\xE', '\x1C', '\xD9', '\v', '\x1C', '\x3', '\x1D', '\x3', '\x1D', 
		'\x5', '\x1D', '\xDD', '\n', '\x1D', '\x3', '\x1E', '\x3', '\x1E', '\x5', 
		'\x1E', '\xE1', '\n', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', '\x3', '\x1F', 
		'\x3', '\x1F', '\x3', '\x1F', '\x5', '\x1F', '\xED', '\n', '\x1F', '\x3', 
		' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', ' ', '\x3', 
		'!', '\x5', '!', '\xF6', '\n', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', 
		'\x3', '#', '\x3', '#', '\a', '#', '\xFD', '\n', '#', '\f', '#', '\xE', 
		'#', '\x100', '\v', '#', '\x5', '#', '\x102', '\n', '#', '\x3', '$', '\x3', 
		'$', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x3', '%', '\x5', 
		'%', '\x10B', '\n', '%', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '&', 
		'\a', '&', '\x111', '\n', '&', '\f', '&', '\xE', '&', '\x114', '\v', '&', 
		'\x3', '&', '\x3', '&', '\x3', '\'', '\x6', '\'', '\x119', '\n', '\'', 
		'\r', '\'', '\xE', '\'', '\x11A', '\x3', '\'', '\x3', '\'', '\x2', '\x2', 
		'(', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\'', '\x15', ')', '\x16', '+', '\x17', 
		'-', '\x18', '/', '\x19', '\x31', '\x1A', '\x33', '\x1B', '\x35', '\x1C', 
		'\x37', '\x1D', '\x39', '\x2', ';', '\x2', '=', '\x2', '?', '\x2', '\x41', 
		'\x2', '\x43', '\x2', '\x45', '\x2', 'G', '\x2', 'I', '\x2', 'K', '\x1E', 
		'M', '\x1F', '\x3', '\x2', '\x12', '\x4', '\x2', '>', '>', '@', '@', '\x4', 
		'\x2', '-', '-', '/', '/', '\x5', '\x2', '\'', '\'', ',', ',', '\x31', 
		'\x31', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\a', '\x2', '/', '/', 
		'\x32', ';', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x3', '\x2', 
		'\x32', ';', '\x6', '\x2', '\f', '\f', '\xF', '\xF', '$', '$', '^', '^', 
		'\x6', '\x2', '\f', '\f', '\xF', '\xF', ')', ')', '^', '^', '\f', '\x2', 
		'$', '$', ')', ')', '\x31', '\x31', '^', '^', '\x64', '\x64', 'h', 'h', 
		'p', 'p', 't', 't', 'v', 'v', 'x', 'x', '\xE', '\x2', '\f', '\f', '\xF', 
		'\xF', '$', '$', ')', ')', '\x32', ';', '^', '^', '\x64', '\x64', 'h', 
		'h', 'p', 'p', 't', 't', 'v', 'x', 'z', 'z', '\x5', '\x2', '\x32', ';', 
		'\x43', 'H', '\x63', 'h', '\x3', '\x2', '\x33', ';', '\x4', '\x2', 'G', 
		'G', 'g', 'g', '\x5', '\x2', '\f', '\f', '\xF', '\xF', '\x202A', '\x202B', 
		'\x4', '\x2', '\f', '\f', '\xF', '\xF', '\x5', '\x2', '\v', '\f', '\xF', 
		'\xF', '\"', '\"', '\x2', '\x12E', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'+', '\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'K', '\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', 
		'\x3', 'O', '\x3', '\x2', '\x2', '\x2', '\x5', 'Q', '\x3', '\x2', '\x2', 
		'\x2', '\a', 'S', '\x3', '\x2', '\x2', '\x2', '\t', 'U', '\x3', '\x2', 
		'\x2', '\x2', '\v', 'W', '\x3', '\x2', '\x2', '\x2', '\r', 'Y', '\x3', 
		'\x2', '\x2', '\x2', '\xF', '[', '\x3', '\x2', '\x2', '\x2', '\x11', ']', 
		'\x3', '\x2', '\x2', '\x2', '\x13', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'\x15', '\x66', '\x3', '\x2', '\x2', '\x2', '\x17', 'h', '\x3', '\x2', 
		'\x2', '\x2', '\x19', 'j', '\x3', '\x2', '\x2', '\x2', '\x1B', 'l', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', 'n', '\x3', '\x2', '\x2', '\x2', '\x1F', 
		'r', '\x3', '\x2', '\x2', '\x2', '!', 'z', '\x3', '\x2', '\x2', '\x2', 
		'#', '\x80', '\x3', '\x2', '\x2', '\x2', '%', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', '\'', '\x8C', '\x3', '\x2', '\x2', '\x2', ')', '\x8F', '\x3', '\x2', 
		'\x2', '\x2', '+', '\x94', '\x3', '\x2', '\x2', '\x2', '-', '\x99', '\x3', 
		'\x2', '\x2', '\x2', '/', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\xB5', '\x3', '\x2', '\x2', '\x2', '\x33', '\xB8', '\x3', '\x2', '\x2', 
		'\x2', '\x35', '\xCF', '\x3', '\x2', '\x2', '\x2', '\x37', '\xD1', '\x3', 
		'\x2', '\x2', '\x2', '\x39', '\xDC', '\x3', '\x2', '\x2', '\x2', ';', 
		'\xE0', '\x3', '\x2', '\x2', '\x2', '=', '\xE2', '\x3', '\x2', '\x2', 
		'\x2', '?', '\xEE', '\x3', '\x2', '\x2', '\x2', '\x41', '\xF5', '\x3', 
		'\x2', '\x2', '\x2', '\x43', '\xF7', '\x3', '\x2', '\x2', '\x2', '\x45', 
		'\x101', '\x3', '\x2', '\x2', '\x2', 'G', '\x103', '\x3', '\x2', '\x2', 
		'\x2', 'I', '\x10A', '\x3', '\x2', '\x2', '\x2', 'K', '\x10C', '\x3', 
		'\x2', '\x2', '\x2', 'M', '\x118', '\x3', '\x2', '\x2', '\x2', 'O', 'P', 
		'\a', '%', '\x2', '\x2', 'P', '\x4', '\x3', '\x2', '\x2', '\x2', 'Q', 
		'R', '\a', '*', '\x2', '\x2', 'R', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'S', 'T', '\a', '.', '\x2', '\x2', 'T', '\b', '\x3', '\x2', '\x2', '\x2', 
		'U', 'V', '\a', '+', '\x2', '\x2', 'V', '\n', '\x3', '\x2', '\x2', '\x2', 
		'W', 'X', '\a', '}', '\x2', '\x2', 'X', '\f', '\x3', '\x2', '\x2', '\x2', 
		'Y', 'Z', '\a', '\x7F', '\x2', '\x2', 'Z', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '[', '\\', '\a', '<', '\x2', '\x2', '\\', '\x10', '\x3', '\x2', 
		'\x2', '\x2', ']', '^', '\a', '=', '\x2', '\x2', '^', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '_', '\x65', '\t', '\x2', '\x2', '\x2', '`', '\x61', '\a', 
		'>', '\x2', '\x2', '\x61', '\x65', '\a', '?', '\x2', '\x2', '\x62', '\x63', 
		'\a', '@', '\x2', '\x2', '\x63', '\x65', '\a', '?', '\x2', '\x2', '\x64', 
		'_', '\x3', '\x2', '\x2', '\x2', '\x64', '`', '\x3', '\x2', '\x2', '\x2', 
		'\x64', '\x62', '\x3', '\x2', '\x2', '\x2', '\x65', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x66', 'g', '\t', '\x3', '\x2', '\x2', 'g', '\x16', '\x3', 
		'\x2', '\x2', '\x2', 'h', 'i', '\t', '\x4', '\x2', '\x2', 'i', '\x18', 
		'\x3', '\x2', '\x2', '\x2', 'j', 'k', '\a', '\x30', '\x2', '\x2', 'k', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', 'l', 'm', '\a', '&', '\x2', '\x2', 
		'm', '\x1C', '\x3', '\x2', '\x2', '\x2', 'n', 'o', '\a', 'u', '\x2', '\x2', 
		'o', 'p', '\a', 'g', '\x2', '\x2', 'p', 'q', '\a', 'v', '\x2', '\x2', 
		'q', '\x1E', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\a', '\x66', '\x2', 
		'\x2', 's', 't', '\a', 'g', '\x2', '\x2', 't', 'u', '\a', '\x65', '\x2', 
		'\x2', 'u', 'v', '\a', 'n', '\x2', '\x2', 'v', 'w', '\a', '\x63', '\x2', 
		'\x2', 'w', 'x', '\a', 't', '\x2', '\x2', 'x', 'y', '\a', 'g', '\x2', 
		'\x2', 'y', ' ', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\a', 'w', '\x2', 
		'\x2', '{', '|', '\a', 'u', '\x2', '\x2', '|', '}', '\a', 'k', '\x2', 
		'\x2', '}', '~', '\a', 'p', '\x2', '\x2', '~', '\x7F', '\a', 'i', '\x2', 
		'\x2', '\x7F', '\"', '\x3', '\x2', '\x2', '\x2', '\x80', '\x81', '\a', 
		'h', '\x2', '\x2', '\x81', '\x82', '\a', 'q', '\x2', '\x2', '\x82', '\x83', 
		'\a', 't', '\x2', '\x2', '\x83', '$', '\x3', '\x2', '\x2', '\x2', '\x84', 
		'\x85', '\a', 'y', '\x2', '\x2', '\x85', '\x86', '\a', 'j', '\x2', '\x2', 
		'\x86', '\x87', '\a', 'g', '\x2', '\x2', '\x87', '\x8B', '\a', 'p', '\x2', 
		'\x2', '\x88', '\x89', '\a', 'k', '\x2', '\x2', '\x89', '\x8B', '\a', 
		'h', '\x2', '\x2', '\x8A', '\x84', '\x3', '\x2', '\x2', '\x2', '\x8A', 
		'\x88', '\x3', '\x2', '\x2', '\x2', '\x8B', '&', '\x3', '\x2', '\x2', 
		'\x2', '\x8C', '\x8D', '\a', 'k', '\x2', '\x2', '\x8D', '\x8E', '\a', 
		'p', '\x2', '\x2', '\x8E', '(', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', 
		'\a', 'h', '\x2', '\x2', '\x90', '\x91', '\a', 't', '\x2', '\x2', '\x91', 
		'\x92', '\a', 'q', '\x2', '\x2', '\x92', '\x93', '\a', 'o', '\x2', '\x2', 
		'\x93', '*', '\x3', '\x2', '\x2', '\x2', '\x94', '\x95', '\a', 'v', '\x2', 
		'\x2', '\x95', '\x96', '\a', 'j', '\x2', '\x2', '\x96', '\x97', '\a', 
		'g', '\x2', '\x2', '\x97', '\x98', '\a', 'p', '\x2', '\x2', '\x98', ',', 
		'\x3', '\x2', '\x2', '\x2', '\x99', '\x9A', '\a', 'g', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', 'n', '\x2', '\x2', '\x9B', '\x9C', '\a', 'u', '\x2', '\x2', 
		'\x9C', '\x9D', '\a', 'g', '\x2', '\x2', '\x9D', '.', '\x3', '\x2', '\x2', 
		'\x2', '\x9E', '\xA2', '\t', '\x5', '\x2', '\x2', '\x9F', '\xA1', '\t', 
		'\x6', '\x2', '\x2', '\xA0', '\x9F', '\x3', '\x2', '\x2', '\x2', '\xA1', 
		'\xA4', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA0', '\x3', '\x2', '\x2', 
		'\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA3', '\x30', '\x3', 
		'\x2', '\x2', '\x2', '\xA4', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA5', 
		'\xA9', '\a', '$', '\x2', '\x2', '\xA6', '\xA8', '\x5', '\x39', '\x1D', 
		'\x2', '\xA7', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xAB', '\x3', 
		'\x2', '\x2', '\x2', '\xA9', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA9', 
		'\xAA', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAC', '\x3', '\x2', '\x2', 
		'\x2', '\xAB', '\xA9', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xB6', '\a', 
		'$', '\x2', '\x2', '\xAD', '\xB1', '\a', ')', '\x2', '\x2', '\xAE', '\xB0', 
		'\x5', ';', '\x1E', '\x2', '\xAF', '\xAE', '\x3', '\x2', '\x2', '\x2', 
		'\xB0', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB1', '\xAF', '\x3', '\x2', 
		'\x2', '\x2', '\xB1', '\xB2', '\x3', '\x2', '\x2', '\x2', '\xB2', '\xB4', 
		'\x3', '\x2', '\x2', '\x2', '\xB3', '\xB1', '\x3', '\x2', '\x2', '\x2', 
		'\xB4', '\xB6', '\a', ')', '\x2', '\x2', '\xB5', '\xA5', '\x3', '\x2', 
		'\x2', '\x2', '\xB5', '\xAD', '\x3', '\x2', '\x2', '\x2', '\xB6', '\x32', 
		'\x3', '\x2', '\x2', '\x2', '\xB7', '\xB9', '\a', '/', '\x2', '\x2', '\xB8', 
		'\xB7', '\x3', '\x2', '\x2', '\x2', '\xB8', '\xB9', '\x3', '\x2', '\x2', 
		'\x2', '\xB9', '\xBA', '\x3', '\x2', '\x2', '\x2', '\xBA', '\xC1', '\x5', 
		'\x45', '#', '\x2', '\xBB', '\xBD', '\a', '\x30', '\x2', '\x2', '\xBC', 
		'\xBE', '\t', '\a', '\x2', '\x2', '\xBD', '\xBC', '\x3', '\x2', '\x2', 
		'\x2', '\xBE', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xBD', '\x3', 
		'\x2', '\x2', '\x2', '\xBF', '\xC0', '\x3', '\x2', '\x2', '\x2', '\xC0', 
		'\xC2', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xBB', '\x3', '\x2', '\x2', 
		'\x2', '\xC1', '\xC2', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC4', '\x3', 
		'\x2', '\x2', '\x2', '\xC3', '\xC5', '\x5', 'G', '$', '\x2', '\xC4', '\xC3', 
		'\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', '\x2', '\x2', 
		'\xC5', '\x34', '\x3', '\x2', '\x2', '\x2', '\xC6', '\xC7', '\a', 'v', 
		'\x2', '\x2', '\xC7', '\xC8', '\a', 't', '\x2', '\x2', '\xC8', '\xC9', 
		'\a', 'w', '\x2', '\x2', '\xC9', '\xD0', '\a', 'g', '\x2', '\x2', '\xCA', 
		'\xCB', '\a', 'h', '\x2', '\x2', '\xCB', '\xCC', '\a', '\x63', '\x2', 
		'\x2', '\xCC', '\xCD', '\a', 'n', '\x2', '\x2', '\xCD', '\xCE', '\a', 
		'u', '\x2', '\x2', '\xCE', '\xD0', '\a', 'g', '\x2', '\x2', '\xCF', '\xC6', 
		'\x3', '\x2', '\x2', '\x2', '\xCF', '\xCA', '\x3', '\x2', '\x2', '\x2', 
		'\xD0', '\x36', '\x3', '\x2', '\x2', '\x2', '\xD1', '\xD7', '\x5', '/', 
		'\x18', '\x2', '\xD2', '\xD3', '\x5', '\x19', '\r', '\x2', '\xD3', '\xD4', 
		'\x5', '/', '\x18', '\x2', '\xD4', '\xD6', '\x3', '\x2', '\x2', '\x2', 
		'\xD5', '\xD2', '\x3', '\x2', '\x2', '\x2', '\xD6', '\xD9', '\x3', '\x2', 
		'\x2', '\x2', '\xD7', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', 
		'\x3', '\x2', '\x2', '\x2', '\xD8', '\x38', '\x3', '\x2', '\x2', '\x2', 
		'\xD9', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xDA', '\xDD', '\n', '\b', 
		'\x2', '\x2', '\xDB', '\xDD', '\x5', '=', '\x1F', '\x2', '\xDC', '\xDA', 
		'\x3', '\x2', '\x2', '\x2', '\xDC', '\xDB', '\x3', '\x2', '\x2', '\x2', 
		'\xDD', ':', '\x3', '\x2', '\x2', '\x2', '\xDE', '\xE1', '\n', '\t', '\x2', 
		'\x2', '\xDF', '\xE1', '\x5', '=', '\x1F', '\x2', '\xE0', '\xDE', '\x3', 
		'\x2', '\x2', '\x2', '\xE0', '\xDF', '\x3', '\x2', '\x2', '\x2', '\xE1', 
		'<', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xEC', '\a', '^', '\x2', '\x2', 
		'\xE3', '\xED', '\x5', 'I', '%', '\x2', '\xE4', '\xED', '\x5', '?', ' ', 
		'\x2', '\xE5', '\xED', '\t', '\n', '\x2', '\x2', '\xE6', '\xED', '\n', 
		'\v', '\x2', '\x2', '\xE7', '\xED', '\a', '\x32', '\x2', '\x2', '\xE8', 
		'\xE9', '\a', 'z', '\x2', '\x2', '\xE9', '\xEA', '\x5', '\x43', '\"', 
		'\x2', '\xEA', '\xEB', '\x5', '\x43', '\"', '\x2', '\xEB', '\xED', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xEC', 
		'\xE4', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xE5', '\x3', '\x2', '\x2', 
		'\x2', '\xEC', '\xE6', '\x3', '\x2', '\x2', '\x2', '\xEC', '\xE7', '\x3', 
		'\x2', '\x2', '\x2', '\xEC', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xED', 
		'>', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEF', '\a', 'w', '\x2', '\x2', 
		'\xEF', '\xF0', '\x5', '\x43', '\"', '\x2', '\xF0', '\xF1', '\x5', '\x43', 
		'\"', '\x2', '\xF1', '\xF2', '\x5', '\x43', '\"', '\x2', '\xF2', '\xF3', 
		'\x5', '\x43', '\"', '\x2', '\xF3', '@', '\x3', '\x2', '\x2', '\x2', '\xF4', 
		'\xF6', '\t', '\x3', '\x2', '\x2', '\xF5', '\xF4', '\x3', '\x2', '\x2', 
		'\x2', '\xF5', '\xF6', '\x3', '\x2', '\x2', '\x2', '\xF6', '\x42', '\x3', 
		'\x2', '\x2', '\x2', '\xF7', '\xF8', '\t', '\f', '\x2', '\x2', '\xF8', 
		'\x44', '\x3', '\x2', '\x2', '\x2', '\xF9', '\x102', '\a', '\x32', '\x2', 
		'\x2', '\xFA', '\xFE', '\t', '\r', '\x2', '\x2', '\xFB', '\xFD', '\t', 
		'\a', '\x2', '\x2', '\xFC', '\xFB', '\x3', '\x2', '\x2', '\x2', '\xFD', 
		'\x100', '\x3', '\x2', '\x2', '\x2', '\xFE', '\xFC', '\x3', '\x2', '\x2', 
		'\x2', '\xFE', '\xFF', '\x3', '\x2', '\x2', '\x2', '\xFF', '\x102', '\x3', 
		'\x2', '\x2', '\x2', '\x100', '\xFE', '\x3', '\x2', '\x2', '\x2', '\x101', 
		'\xF9', '\x3', '\x2', '\x2', '\x2', '\x101', '\xFA', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\x46', '\x3', '\x2', '\x2', '\x2', '\x103', '\x104', 
		'\t', '\xE', '\x2', '\x2', '\x104', '\x105', '\x5', '\x41', '!', '\x2', 
		'\x105', '\x106', '\x5', '\x45', '#', '\x2', '\x106', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\x107', '\x108', '\a', '\xF', '\x2', '\x2', '\x108', '\x10B', 
		'\a', '\f', '\x2', '\x2', '\x109', '\x10B', '\t', '\xF', '\x2', '\x2', 
		'\x10A', '\x107', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x109', '\x3', 
		'\x2', '\x2', '\x2', '\x10B', 'J', '\x3', '\x2', '\x2', '\x2', '\x10C', 
		'\x10D', '\a', '\x31', '\x2', '\x2', '\x10D', '\x10E', '\a', '\x31', '\x2', 
		'\x2', '\x10E', '\x112', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x111', 
		'\n', '\x10', '\x2', '\x2', '\x110', '\x10F', '\x3', '\x2', '\x2', '\x2', 
		'\x111', '\x114', '\x3', '\x2', '\x2', '\x2', '\x112', '\x110', '\x3', 
		'\x2', '\x2', '\x2', '\x112', '\x113', '\x3', '\x2', '\x2', '\x2', '\x113', 
		'\x115', '\x3', '\x2', '\x2', '\x2', '\x114', '\x112', '\x3', '\x2', '\x2', 
		'\x2', '\x115', '\x116', '\b', '&', '\x2', '\x2', '\x116', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\x117', '\x119', '\t', '\x11', '\x2', '\x2', '\x118', 
		'\x117', '\x3', '\x2', '\x2', '\x2', '\x119', '\x11A', '\x3', '\x2', '\x2', 
		'\x2', '\x11A', '\x118', '\x3', '\x2', '\x2', '\x2', '\x11A', '\x11B', 
		'\x3', '\x2', '\x2', '\x2', '\x11B', '\x11C', '\x3', '\x2', '\x2', '\x2', 
		'\x11C', '\x11D', '\b', '\'', '\x2', '\x2', '\x11D', 'N', '\x3', '\x2', 
		'\x2', '\x2', '\x18', '\x2', '\x64', '\x8A', '\xA2', '\xA9', '\xB1', '\xB5', 
		'\xB8', '\xBF', '\xC1', '\xC4', '\xCF', '\xD7', '\xDC', '\xE0', '\xEC', 
		'\xF5', '\xFE', '\x101', '\x10A', '\x112', '\x11A', '\x3', '\b', '\x2', 
		'\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace NML.Parser.Generated
