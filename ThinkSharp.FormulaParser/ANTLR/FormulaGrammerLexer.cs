//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from FormulaGrammer.g4 by ANTLR 4.7.2

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
public partial class FormulaGrammerLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		LPAREN=1, RPAREN=2, PLUS=3, MINUS=4, TIMES=5, DIV=6, COMMA=7, POINT=8, 
		POW=9, IDENTIFIER=10, DECIMAL_NUMBER=11, BINARY_NUMBER=12, HEXADECIMAL_NUMBER=13, 
		SCIENTIFIC_NUMBER=14, WS=15;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "COMMA", "POINT", 
		"POW", "IDENTIFIER", "DECIMAL_NUMBER", "BINARY_NUMBER", "HEXADECIMAL_NUMBER", 
		"SCIENTIFIC_NUMBER", "VALID_ID_START", "VALID_ID_CHAR", "PREFIX_DEC", 
		"NUMBER_DEC", "PREFIX_BIN", "NUMBER_BIN", "PREFIX_HEX", "NUMBER_HEX", 
		"E1", "E2", "SIGN", "WS"
	};


	public FormulaGrammerLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public FormulaGrammerLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'+'", "'-'", "'*'", "'/'", "','", "'.'", "'^'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "COMMA", "POINT", 
		"POW", "IDENTIFIER", "DECIMAL_NUMBER", "BINARY_NUMBER", "HEXADECIMAL_NUMBER", 
		"SCIENTIFIC_NUMBER", "WS"
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

	public override string GrammarFileName { get { return "FormulaGrammer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static FormulaGrammerLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x11', '\x99', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', 
		'\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', 
		'\v', '\a', '\v', 'L', '\n', '\v', '\f', '\v', '\xE', '\v', 'O', '\v', 
		'\v', '\x3', '\f', '\x5', '\f', 'R', '\n', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x5', '\xF', '_', '\n', 
		'\xF', '\x3', '\xF', '\x5', '\xF', '\x62', '\n', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\x10', '\x5', '\x10', 'g', '\n', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x5', '\x11', 'k', '\n', '\x11', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x6', '\x13', 'q', '\n', 
		'\x13', '\r', '\x13', '\xE', '\x13', 'r', '\x3', '\x13', '\x3', '\x13', 
		'\x6', '\x13', 'w', '\n', '\x13', '\r', '\x13', '\xE', '\x13', 'x', '\x5', 
		'\x13', '{', '\n', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x15', '\x6', '\x15', '\x81', '\n', '\x15', '\r', '\x15', '\xE', 
		'\x15', '\x82', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', 
		'\x6', '\x17', '\x89', '\n', '\x17', '\r', '\x17', '\xE', '\x17', '\x8A', 
		'\x3', '\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', 
		'\x3', '\x1A', '\x3', '\x1B', '\x6', '\x1B', '\x94', '\n', '\x1B', '\r', 
		'\x1B', '\xE', '\x1B', '\x95', '\x3', '\x1B', '\x3', '\x1B', '\x2', '\x2', 
		'\x1C', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x2', '!', 
		'\x2', '#', '\x2', '%', '\x2', '\'', '\x2', ')', '\x2', '+', '\x2', '-', 
		'\x2', '/', '\x2', '\x31', '\x2', '\x33', '\x2', '\x35', '\x11', '\x3', 
		'\x2', '\t', '\x6', '\x2', '&', '&', '\x43', '\\', '\x61', '\x61', '\x63', 
		'|', '\x4', '\x2', '\x46', '\x46', '\x66', '\x66', '\x4', '\x2', '\x44', 
		'\x44', '\x64', '\x64', '\x4', '\x2', 'Z', 'Z', 'z', 'z', '\x5', '\x2', 
		'\x32', ';', '\x43', 'H', '\x63', 'h', '\x4', '\x2', '-', '-', '/', '/', 
		'\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x98', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x35', '\x3', '\x2', '\x2', '\x2', '\x3', '\x37', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '\x39', '\x3', '\x2', '\x2', '\x2', '\a', 
		';', '\x3', '\x2', '\x2', '\x2', '\t', '=', '\x3', '\x2', '\x2', '\x2', 
		'\v', '?', '\x3', '\x2', '\x2', '\x2', '\r', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '\x43', '\x3', '\x2', '\x2', '\x2', '\x11', '\x45', '\x3', 
		'\x2', '\x2', '\x2', '\x13', 'G', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'I', '\x3', '\x2', '\x2', '\x2', '\x17', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x19', 'U', '\x3', '\x2', '\x2', '\x2', '\x1B', 'X', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', '[', '\x3', '\x2', '\x2', '\x2', '\x1F', '\x66', '\x3', 
		'\x2', '\x2', '\x2', '!', 'j', '\x3', '\x2', '\x2', '\x2', '#', 'l', '\x3', 
		'\x2', '\x2', '\x2', '%', 'p', '\x3', '\x2', '\x2', '\x2', '\'', '|', 
		'\x3', '\x2', '\x2', '\x2', ')', '\x80', '\x3', '\x2', '\x2', '\x2', '+', 
		'\x84', '\x3', '\x2', '\x2', '\x2', '-', '\x88', '\x3', '\x2', '\x2', 
		'\x2', '/', '\x8C', '\x3', '\x2', '\x2', '\x2', '\x31', '\x8E', '\x3', 
		'\x2', '\x2', '\x2', '\x33', '\x90', '\x3', '\x2', '\x2', '\x2', '\x35', 
		'\x93', '\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', '*', '\x2', 
		'\x2', '\x38', '\x4', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', '+', 
		'\x2', '\x2', ':', '\x6', '\x3', '\x2', '\x2', '\x2', ';', '<', '\a', 
		'-', '\x2', '\x2', '<', '\b', '\x3', '\x2', '\x2', '\x2', '=', '>', '\a', 
		'/', '\x2', '\x2', '>', '\n', '\x3', '\x2', '\x2', '\x2', '?', '@', '\a', 
		',', '\x2', '\x2', '@', '\f', '\x3', '\x2', '\x2', '\x2', '\x41', '\x42', 
		'\a', '\x31', '\x2', '\x2', '\x42', '\xE', '\x3', '\x2', '\x2', '\x2', 
		'\x43', '\x44', '\a', '.', '\x2', '\x2', '\x44', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x45', '\x46', '\a', '\x30', '\x2', '\x2', '\x46', '\x12', 
		'\x3', '\x2', '\x2', '\x2', 'G', 'H', '\a', '`', '\x2', '\x2', 'H', '\x14', 
		'\x3', '\x2', '\x2', '\x2', 'I', 'M', '\x5', '\x1F', '\x10', '\x2', 'J', 
		'L', '\x5', '!', '\x11', '\x2', 'K', 'J', '\x3', '\x2', '\x2', '\x2', 
		'L', 'O', '\x3', '\x2', '\x2', '\x2', 'M', 'K', '\x3', '\x2', '\x2', '\x2', 
		'M', 'N', '\x3', '\x2', '\x2', '\x2', 'N', '\x16', '\x3', '\x2', '\x2', 
		'\x2', 'O', 'M', '\x3', '\x2', '\x2', '\x2', 'P', 'R', '\x5', '#', '\x12', 
		'\x2', 'Q', 'P', '\x3', '\x2', '\x2', '\x2', 'Q', 'R', '\x3', '\x2', '\x2', 
		'\x2', 'R', 'S', '\x3', '\x2', '\x2', '\x2', 'S', 'T', '\x5', '%', '\x13', 
		'\x2', 'T', '\x18', '\x3', '\x2', '\x2', '\x2', 'U', 'V', '\x5', '\'', 
		'\x14', '\x2', 'V', 'W', '\x5', ')', '\x15', '\x2', 'W', '\x1A', '\x3', 
		'\x2', '\x2', '\x2', 'X', 'Y', '\x5', '+', '\x16', '\x2', 'Y', 'Z', '\x5', 
		'-', '\x17', '\x2', 'Z', '\x1C', '\x3', '\x2', '\x2', '\x2', '[', '^', 
		'\x5', '%', '\x13', '\x2', '\\', '_', '\x5', '/', '\x18', '\x2', ']', 
		'_', '\x5', '\x31', '\x19', '\x2', '^', '\\', '\x3', '\x2', '\x2', '\x2', 
		'^', ']', '\x3', '\x2', '\x2', '\x2', '_', '\x61', '\x3', '\x2', '\x2', 
		'\x2', '`', '\x62', '\x5', '\x33', '\x1A', '\x2', '\x61', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x61', '\x62', '\x3', '\x2', '\x2', '\x2', '\x62', 
		'\x63', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\x5', '%', '\x13', 
		'\x2', '\x64', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x65', 'g', '\t', 
		'\x2', '\x2', '\x2', '\x66', '\x65', '\x3', '\x2', '\x2', '\x2', 'g', 
		' ', '\x3', '\x2', '\x2', '\x2', 'h', 'k', '\x5', '\x1F', '\x10', '\x2', 
		'i', 'k', '\x4', '\x32', ';', '\x2', 'j', 'h', '\x3', '\x2', '\x2', '\x2', 
		'j', 'i', '\x3', '\x2', '\x2', '\x2', 'k', '\"', '\x3', '\x2', '\x2', 
		'\x2', 'l', 'm', '\a', '\x32', '\x2', '\x2', 'm', 'n', '\t', '\x3', '\x2', 
		'\x2', 'n', '$', '\x3', '\x2', '\x2', '\x2', 'o', 'q', '\x4', '\x32', 
		';', '\x2', 'p', 'o', '\x3', '\x2', '\x2', '\x2', 'q', 'r', '\x3', '\x2', 
		'\x2', '\x2', 'r', 'p', '\x3', '\x2', '\x2', '\x2', 'r', 's', '\x3', '\x2', 
		'\x2', '\x2', 's', 'z', '\x3', '\x2', '\x2', '\x2', 't', 'v', '\a', '\x30', 
		'\x2', '\x2', 'u', 'w', '\x4', '\x32', ';', '\x2', 'v', 'u', '\x3', '\x2', 
		'\x2', '\x2', 'w', 'x', '\x3', '\x2', '\x2', '\x2', 'x', 'v', '\x3', '\x2', 
		'\x2', '\x2', 'x', 'y', '\x3', '\x2', '\x2', '\x2', 'y', '{', '\x3', '\x2', 
		'\x2', '\x2', 'z', 't', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\x3', '\x2', 
		'\x2', '\x2', '{', '&', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', '\x32', 
		'\x2', '\x2', '}', '~', '\t', '\x4', '\x2', '\x2', '~', '(', '\x3', '\x2', 
		'\x2', '\x2', '\x7F', '\x81', '\x4', '\x32', '\x33', '\x2', '\x80', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '\x81', '\x82', '\x3', '\x2', '\x2', '\x2', 
		'\x82', '\x80', '\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\x3', '\x2', 
		'\x2', '\x2', '\x83', '*', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', 
		'\a', '\x32', '\x2', '\x2', '\x85', '\x86', '\t', '\x5', '\x2', '\x2', 
		'\x86', ',', '\x3', '\x2', '\x2', '\x2', '\x87', '\x89', '\t', '\x6', 
		'\x2', '\x2', '\x88', '\x87', '\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', 
		'\x3', '\x2', '\x2', '\x2', '\x8A', '\x88', '\x3', '\x2', '\x2', '\x2', 
		'\x8A', '\x8B', '\x3', '\x2', '\x2', '\x2', '\x8B', '.', '\x3', '\x2', 
		'\x2', '\x2', '\x8C', '\x8D', '\a', 'G', '\x2', '\x2', '\x8D', '\x30', 
		'\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\a', 'g', '\x2', '\x2', '\x8F', 
		'\x32', '\x3', '\x2', '\x2', '\x2', '\x90', '\x91', '\t', '\a', '\x2', 
		'\x2', '\x91', '\x34', '\x3', '\x2', '\x2', '\x2', '\x92', '\x94', '\t', 
		'\b', '\x2', '\x2', '\x93', '\x92', '\x3', '\x2', '\x2', '\x2', '\x94', 
		'\x95', '\x3', '\x2', '\x2', '\x2', '\x95', '\x93', '\x3', '\x2', '\x2', 
		'\x2', '\x95', '\x96', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\x3', 
		'\x2', '\x2', '\x2', '\x97', '\x98', '\b', '\x1B', '\x2', '\x2', '\x98', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x10', '\x2', 'M', 'Q', '^', '\x61', 
		'\x66', 'j', 'r', 'x', 'z', '\x82', '\x88', '\x8A', '\x95', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
