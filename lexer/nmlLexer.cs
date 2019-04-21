//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from nml.g4 by ANTLR 4.7.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.2")]
[System.CLSCompliant(false)]
public partial class nmlLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		KEY=10, STRING=11, NUMBER=12, WS=13;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"KEY", "STRING", "ESC", "UNICODE", "HEX", "SAFECODEPOINT", "NUMBER", "INT", 
		"EXP", "WS"
	};


	public nmlLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public nmlLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'root'", "'{'", "','", "'}'", "'['", "']'", "'true'", "'false'", 
		"'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "KEY", "STRING", 
		"NUMBER", "WS"
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

	public override string GrammarFileName { get { return "nml.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static nmlLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\xF', '\x90', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\a', '\v', 'K', '\n', 
		'\v', '\f', '\v', '\xE', '\v', 'N', '\v', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\a', '\f', 'U', '\n', '\f', '\f', 
		'\f', '\xE', '\f', 'X', '\v', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\r', 
		'\x3', '\r', '\x3', '\r', '\x5', '\r', '_', '\n', '\r', '\x3', '\xE', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', 
		'\x5', '\x11', 'l', '\n', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\x6', '\x11', 'q', '\n', '\x11', '\r', '\x11', '\xE', '\x11', 
		'r', '\x5', '\x11', 'u', '\n', '\x11', '\x3', '\x11', '\x5', '\x11', 'x', 
		'\n', '\x11', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\a', '\x12', 
		'}', '\n', '\x12', '\f', '\x12', '\xE', '\x12', '\x80', '\v', '\x12', 
		'\x5', '\x12', '\x82', '\n', '\x12', '\x3', '\x13', '\x3', '\x13', '\x5', 
		'\x13', '\x86', '\n', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', 
		'\x6', '\x14', '\x8B', '\n', '\x14', '\r', '\x14', '\xE', '\x14', '\x8C', 
		'\x3', '\x14', '\x3', '\x14', '\x2', '\x2', '\x15', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\x2', 
		'\x1B', '\x2', '\x1D', '\x2', '\x1F', '\x2', '!', '\xE', '#', '\x2', '%', 
		'\x2', '\'', '\xF', '\x3', '\x2', '\n', '\n', '\x2', '$', '$', '\x31', 
		'\x31', '^', '^', '\x64', '\x64', 'h', 'h', 'p', 'p', 't', 't', 'v', 'v', 
		'\x5', '\x2', '\x32', ';', '\x43', 'H', '\x63', 'h', '\x5', '\x2', '\x2', 
		'!', '$', '$', '^', '^', '\x3', '\x2', '\x32', ';', '\x3', '\x2', '\x33', 
		';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', '-', '-', '/', '/', 
		'\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x96', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x3', ')', '\x3', '\x2', '\x2', '\x2', '\x5', 
		'.', '\x3', '\x2', '\x2', '\x2', '\a', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\x32', '\x3', '\x2', '\x2', '\x2', '\v', '\x34', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\x36', '\x3', '\x2', '\x2', '\x2', '\xF', '\x38', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '=', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x15', 'L', '\x3', '\x2', '\x2', 
		'\x2', '\x17', 'Q', '\x3', '\x2', '\x2', '\x2', '\x19', '[', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '`', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x66', 
		'\x3', '\x2', '\x2', '\x2', '\x1F', 'h', '\x3', '\x2', '\x2', '\x2', '!', 
		'k', '\x3', '\x2', '\x2', '\x2', '#', '\x81', '\x3', '\x2', '\x2', '\x2', 
		'%', '\x83', '\x3', '\x2', '\x2', '\x2', '\'', '\x8A', '\x3', '\x2', '\x2', 
		'\x2', ')', '*', '\a', 't', '\x2', '\x2', '*', '+', '\a', 'q', '\x2', 
		'\x2', '+', ',', '\a', 'q', '\x2', '\x2', ',', '-', '\a', 'v', '\x2', 
		'\x2', '-', '\x4', '\x3', '\x2', '\x2', '\x2', '.', '/', '\a', '}', '\x2', 
		'\x2', '/', '\x6', '\x3', '\x2', '\x2', '\x2', '\x30', '\x31', '\a', '.', 
		'\x2', '\x2', '\x31', '\b', '\x3', '\x2', '\x2', '\x2', '\x32', '\x33', 
		'\a', '\x7F', '\x2', '\x2', '\x33', '\n', '\x3', '\x2', '\x2', '\x2', 
		'\x34', '\x35', '\a', ']', '\x2', '\x2', '\x35', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\x36', '\x37', '\a', '_', '\x2', '\x2', '\x37', '\xE', '\x3', 
		'\x2', '\x2', '\x2', '\x38', '\x39', '\a', 'v', '\x2', '\x2', '\x39', 
		':', '\a', 't', '\x2', '\x2', ':', ';', '\a', 'w', '\x2', '\x2', ';', 
		'<', '\a', 'g', '\x2', '\x2', '<', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'=', '>', '\a', 'h', '\x2', '\x2', '>', '?', '\a', '\x63', '\x2', '\x2', 
		'?', '@', '\a', 'n', '\x2', '\x2', '@', '\x41', '\a', 'u', '\x2', '\x2', 
		'\x41', '\x42', '\a', 'g', '\x2', '\x2', '\x42', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x43', '\x44', '\a', 'p', '\x2', '\x2', '\x44', '\x45', 
		'\a', 'w', '\x2', '\x2', '\x45', '\x46', '\a', 'n', '\x2', '\x2', '\x46', 
		'G', '\a', 'n', '\x2', '\x2', 'G', '\x14', '\x3', '\x2', '\x2', '\x2', 
		'H', 'K', '\x5', '\x19', '\r', '\x2', 'I', 'K', '\x5', '\x1F', '\x10', 
		'\x2', 'J', 'H', '\x3', '\x2', '\x2', '\x2', 'J', 'I', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'N', '\x3', '\x2', '\x2', '\x2', 'L', 'J', '\x3', '\x2', '\x2', 
		'\x2', 'L', 'M', '\x3', '\x2', '\x2', '\x2', 'M', 'O', '\x3', '\x2', '\x2', 
		'\x2', 'N', 'L', '\x3', '\x2', '\x2', '\x2', 'O', 'P', '\a', '\"', '\x2', 
		'\x2', 'P', '\x16', '\x3', '\x2', '\x2', '\x2', 'Q', 'V', '\a', '$', '\x2', 
		'\x2', 'R', 'U', '\x5', '\x19', '\r', '\x2', 'S', 'U', '\x5', '\x1F', 
		'\x10', '\x2', 'T', 'R', '\x3', '\x2', '\x2', '\x2', 'T', 'S', '\x3', 
		'\x2', '\x2', '\x2', 'U', 'X', '\x3', '\x2', '\x2', '\x2', 'V', 'T', '\x3', 
		'\x2', '\x2', '\x2', 'V', 'W', '\x3', '\x2', '\x2', '\x2', 'W', 'Y', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'V', '\x3', '\x2', '\x2', '\x2', 'Y', 'Z', '\a', 
		'$', '\x2', '\x2', 'Z', '\x18', '\x3', '\x2', '\x2', '\x2', '[', '^', 
		'\a', '^', '\x2', '\x2', '\\', '_', '\t', '\x2', '\x2', '\x2', ']', '_', 
		'\x5', '\x1B', '\xE', '\x2', '^', '\\', '\x3', '\x2', '\x2', '\x2', '^', 
		']', '\x3', '\x2', '\x2', '\x2', '_', '\x1A', '\x3', '\x2', '\x2', '\x2', 
		'`', '\x61', '\a', 'w', '\x2', '\x2', '\x61', '\x62', '\x5', '\x1D', '\xF', 
		'\x2', '\x62', '\x63', '\x5', '\x1D', '\xF', '\x2', '\x63', '\x64', '\x5', 
		'\x1D', '\xF', '\x2', '\x64', '\x65', '\x5', '\x1D', '\xF', '\x2', '\x65', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\x66', 'g', '\t', '\x3', '\x2', '\x2', 
		'g', '\x1E', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\n', '\x4', '\x2', 
		'\x2', 'i', ' ', '\x3', '\x2', '\x2', '\x2', 'j', 'l', '\a', '/', '\x2', 
		'\x2', 'k', 'j', '\x3', '\x2', '\x2', '\x2', 'k', 'l', '\x3', '\x2', '\x2', 
		'\x2', 'l', 'm', '\x3', '\x2', '\x2', '\x2', 'm', 't', '\x5', '#', '\x12', 
		'\x2', 'n', 'p', '\a', '\x30', '\x2', '\x2', 'o', 'q', '\t', '\x5', '\x2', 
		'\x2', 'p', 'o', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\x3', '\x2', '\x2', 
		'\x2', 'r', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\x3', '\x2', '\x2', 
		'\x2', 's', 'u', '\x3', '\x2', '\x2', '\x2', 't', 'n', '\x3', '\x2', '\x2', 
		'\x2', 't', 'u', '\x3', '\x2', '\x2', '\x2', 'u', 'w', '\x3', '\x2', '\x2', 
		'\x2', 'v', 'x', '\x5', '%', '\x13', '\x2', 'w', 'v', '\x3', '\x2', '\x2', 
		'\x2', 'w', 'x', '\x3', '\x2', '\x2', '\x2', 'x', '\"', '\x3', '\x2', 
		'\x2', '\x2', 'y', '\x82', '\a', '\x32', '\x2', '\x2', 'z', '~', '\t', 
		'\x6', '\x2', '\x2', '{', '}', '\t', '\x5', '\x2', '\x2', '|', '{', '\x3', 
		'\x2', '\x2', '\x2', '}', '\x80', '\x3', '\x2', '\x2', '\x2', '~', '|', 
		'\x3', '\x2', '\x2', '\x2', '~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', 
		'\x82', '\x3', '\x2', '\x2', '\x2', '\x80', '~', '\x3', '\x2', '\x2', 
		'\x2', '\x81', 'y', '\x3', '\x2', '\x2', '\x2', '\x81', 'z', '\x3', '\x2', 
		'\x2', '\x2', '\x82', '$', '\x3', '\x2', '\x2', '\x2', '\x83', '\x85', 
		'\t', '\a', '\x2', '\x2', '\x84', '\x86', '\t', '\b', '\x2', '\x2', '\x85', 
		'\x84', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\x3', '\x2', '\x2', 
		'\x2', '\x86', '\x87', '\x3', '\x2', '\x2', '\x2', '\x87', '\x88', '\x5', 
		'#', '\x12', '\x2', '\x88', '&', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8B', 
		'\t', '\t', '\x2', '\x2', '\x8A', '\x89', '\x3', '\x2', '\x2', '\x2', 
		'\x8B', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x8C', '\x8A', '\x3', '\x2', 
		'\x2', '\x2', '\x8C', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8D', '\x8E', 
		'\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\b', '\x14', '\x2', '\x2', 
		'\x8F', '(', '\x3', '\x2', '\x2', '\x2', '\x10', '\x2', 'J', 'L', 'T', 
		'V', '^', 'k', 'r', 't', 'w', '~', '\x81', '\x85', '\x8C', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
