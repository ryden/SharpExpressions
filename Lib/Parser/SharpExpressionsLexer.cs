//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.2 C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g 2015-07-06 23:56:11

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;

namespace SharpExpressions.Parser
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5.0.2")]
[System.CLSCompliant(false)]
public partial class SharpExpressionsLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int IDENTIFIER=4;
	public const int QUOTED_STRING=5;
	public const int REAL=6;
	public const int WS=7;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int T__16=16;
	public const int T__17=17;
	public const int T__18=18;
	public const int T__19=19;
	public const int T__20=20;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
	public const int T__27=27;
	public const int T__28=28;
	public const int T__29=29;

	// delegates
	// delegators

	public SharpExpressionsLexer()
	{
		OnCreated();
	}

	public SharpExpressionsLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public SharpExpressionsLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__8();
	partial void LeaveRule_T__8();

	// $ANTLR start "T__8"
	[GrammarRule("T__8")]
	private void mT__8()
	{
		EnterRule_T__8();
		EnterRule("T__8", 1);
		TraceIn("T__8", 1);
		try
		{
			int _type = T__8;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:9:6: ( '!' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:9:8: '!'
			{
			DebugLocation(9, 8);
			Match('!'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__8", 1);
			LeaveRule("T__8", 1);
			LeaveRule_T__8();
		}
	}
	// $ANTLR end "T__8"

	partial void EnterRule_T__9();
	partial void LeaveRule_T__9();

	// $ANTLR start "T__9"
	[GrammarRule("T__9")]
	private void mT__9()
	{
		EnterRule_T__9();
		EnterRule("T__9", 2);
		TraceIn("T__9", 2);
		try
		{
			int _type = T__9;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:10:6: ( '!=' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:10:8: '!='
			{
			DebugLocation(10, 8);
			Match("!="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__9", 2);
			LeaveRule("T__9", 2);
			LeaveRule_T__9();
		}
	}
	// $ANTLR end "T__9"

	partial void EnterRule_T__10();
	partial void LeaveRule_T__10();

	// $ANTLR start "T__10"
	[GrammarRule("T__10")]
	private void mT__10()
	{
		EnterRule_T__10();
		EnterRule("T__10", 3);
		TraceIn("T__10", 3);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:11:7: ( '&&' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:11:9: '&&'
			{
			DebugLocation(11, 9);
			Match("&&"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 3);
			LeaveRule("T__10", 3);
			LeaveRule_T__10();
		}
	}
	// $ANTLR end "T__10"

	partial void EnterRule_T__11();
	partial void LeaveRule_T__11();

	// $ANTLR start "T__11"
	[GrammarRule("T__11")]
	private void mT__11()
	{
		EnterRule_T__11();
		EnterRule("T__11", 4);
		TraceIn("T__11", 4);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:12:7: ( '(' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:12:9: '('
			{
			DebugLocation(12, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 4);
			LeaveRule("T__11", 4);
			LeaveRule_T__11();
		}
	}
	// $ANTLR end "T__11"

	partial void EnterRule_T__12();
	partial void LeaveRule_T__12();

	// $ANTLR start "T__12"
	[GrammarRule("T__12")]
	private void mT__12()
	{
		EnterRule_T__12();
		EnterRule("T__12", 5);
		TraceIn("T__12", 5);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:13:7: ( ')' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:13:9: ')'
			{
			DebugLocation(13, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 5);
			LeaveRule("T__12", 5);
			LeaveRule_T__12();
		}
	}
	// $ANTLR end "T__12"

	partial void EnterRule_T__13();
	partial void LeaveRule_T__13();

	// $ANTLR start "T__13"
	[GrammarRule("T__13")]
	private void mT__13()
	{
		EnterRule_T__13();
		EnterRule("T__13", 6);
		TraceIn("T__13", 6);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:14:7: ( '*' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:14:9: '*'
			{
			DebugLocation(14, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 6);
			LeaveRule("T__13", 6);
			LeaveRule_T__13();
		}
	}
	// $ANTLR end "T__13"

	partial void EnterRule_T__14();
	partial void LeaveRule_T__14();

	// $ANTLR start "T__14"
	[GrammarRule("T__14")]
	private void mT__14()
	{
		EnterRule_T__14();
		EnterRule("T__14", 7);
		TraceIn("T__14", 7);
		try
		{
			int _type = T__14;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:15:7: ( '+' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:15:9: '+'
			{
			DebugLocation(15, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__14", 7);
			LeaveRule("T__14", 7);
			LeaveRule_T__14();
		}
	}
	// $ANTLR end "T__14"

	partial void EnterRule_T__15();
	partial void LeaveRule_T__15();

	// $ANTLR start "T__15"
	[GrammarRule("T__15")]
	private void mT__15()
	{
		EnterRule_T__15();
		EnterRule("T__15", 8);
		TraceIn("T__15", 8);
		try
		{
			int _type = T__15;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:16:7: ( ',' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:16:9: ','
			{
			DebugLocation(16, 9);
			Match(','); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__15", 8);
			LeaveRule("T__15", 8);
			LeaveRule_T__15();
		}
	}
	// $ANTLR end "T__15"

	partial void EnterRule_T__16();
	partial void LeaveRule_T__16();

	// $ANTLR start "T__16"
	[GrammarRule("T__16")]
	private void mT__16()
	{
		EnterRule_T__16();
		EnterRule("T__16", 9);
		TraceIn("T__16", 9);
		try
		{
			int _type = T__16;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:17:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:17:9: '-'
			{
			DebugLocation(17, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__16", 9);
			LeaveRule("T__16", 9);
			LeaveRule_T__16();
		}
	}
	// $ANTLR end "T__16"

	partial void EnterRule_T__17();
	partial void LeaveRule_T__17();

	// $ANTLR start "T__17"
	[GrammarRule("T__17")]
	private void mT__17()
	{
		EnterRule_T__17();
		EnterRule("T__17", 10);
		TraceIn("T__17", 10);
		try
		{
			int _type = T__17;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:18:7: ( '.' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:18:9: '.'
			{
			DebugLocation(18, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__17", 10);
			LeaveRule("T__17", 10);
			LeaveRule_T__17();
		}
	}
	// $ANTLR end "T__17"

	partial void EnterRule_T__18();
	partial void LeaveRule_T__18();

	// $ANTLR start "T__18"
	[GrammarRule("T__18")]
	private void mT__18()
	{
		EnterRule_T__18();
		EnterRule("T__18", 11);
		TraceIn("T__18", 11);
		try
		{
			int _type = T__18;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:19:7: ( '/' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:19:9: '/'
			{
			DebugLocation(19, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__18", 11);
			LeaveRule("T__18", 11);
			LeaveRule_T__18();
		}
	}
	// $ANTLR end "T__18"

	partial void EnterRule_T__19();
	partial void LeaveRule_T__19();

	// $ANTLR start "T__19"
	[GrammarRule("T__19")]
	private void mT__19()
	{
		EnterRule_T__19();
		EnterRule("T__19", 12);
		TraceIn("T__19", 12);
		try
		{
			int _type = T__19;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:20:7: ( '<' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:20:9: '<'
			{
			DebugLocation(20, 9);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__19", 12);
			LeaveRule("T__19", 12);
			LeaveRule_T__19();
		}
	}
	// $ANTLR end "T__19"

	partial void EnterRule_T__20();
	partial void LeaveRule_T__20();

	// $ANTLR start "T__20"
	[GrammarRule("T__20")]
	private void mT__20()
	{
		EnterRule_T__20();
		EnterRule("T__20", 13);
		TraceIn("T__20", 13);
		try
		{
			int _type = T__20;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:21:7: ( '<=' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:21:9: '<='
			{
			DebugLocation(21, 9);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__20", 13);
			LeaveRule("T__20", 13);
			LeaveRule_T__20();
		}
	}
	// $ANTLR end "T__20"

	partial void EnterRule_T__21();
	partial void LeaveRule_T__21();

	// $ANTLR start "T__21"
	[GrammarRule("T__21")]
	private void mT__21()
	{
		EnterRule_T__21();
		EnterRule("T__21", 14);
		TraceIn("T__21", 14);
		try
		{
			int _type = T__21;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:22:7: ( '==' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:22:9: '=='
			{
			DebugLocation(22, 9);
			Match("=="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__21", 14);
			LeaveRule("T__21", 14);
			LeaveRule_T__21();
		}
	}
	// $ANTLR end "T__21"

	partial void EnterRule_T__22();
	partial void LeaveRule_T__22();

	// $ANTLR start "T__22"
	[GrammarRule("T__22")]
	private void mT__22()
	{
		EnterRule_T__22();
		EnterRule("T__22", 15);
		TraceIn("T__22", 15);
		try
		{
			int _type = T__22;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:23:7: ( '>' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:23:9: '>'
			{
			DebugLocation(23, 9);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__22", 15);
			LeaveRule("T__22", 15);
			LeaveRule_T__22();
		}
	}
	// $ANTLR end "T__22"

	partial void EnterRule_T__23();
	partial void LeaveRule_T__23();

	// $ANTLR start "T__23"
	[GrammarRule("T__23")]
	private void mT__23()
	{
		EnterRule_T__23();
		EnterRule("T__23", 16);
		TraceIn("T__23", 16);
		try
		{
			int _type = T__23;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:24:7: ( '>=' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:24:9: '>='
			{
			DebugLocation(24, 9);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__23", 16);
			LeaveRule("T__23", 16);
			LeaveRule_T__23();
		}
	}
	// $ANTLR end "T__23"

	partial void EnterRule_T__24();
	partial void LeaveRule_T__24();

	// $ANTLR start "T__24"
	[GrammarRule("T__24")]
	private void mT__24()
	{
		EnterRule_T__24();
		EnterRule("T__24", 17);
		TraceIn("T__24", 17);
		try
		{
			int _type = T__24;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:25:7: ( '[' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:25:9: '['
			{
			DebugLocation(25, 9);
			Match('['); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__24", 17);
			LeaveRule("T__24", 17);
			LeaveRule_T__24();
		}
	}
	// $ANTLR end "T__24"

	partial void EnterRule_T__25();
	partial void LeaveRule_T__25();

	// $ANTLR start "T__25"
	[GrammarRule("T__25")]
	private void mT__25()
	{
		EnterRule_T__25();
		EnterRule("T__25", 18);
		TraceIn("T__25", 18);
		try
		{
			int _type = T__25;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:26:7: ( ']' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:26:9: ']'
			{
			DebugLocation(26, 9);
			Match(']'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__25", 18);
			LeaveRule("T__25", 18);
			LeaveRule_T__25();
		}
	}
	// $ANTLR end "T__25"

	partial void EnterRule_T__26();
	partial void LeaveRule_T__26();

	// $ANTLR start "T__26"
	[GrammarRule("T__26")]
	private void mT__26()
	{
		EnterRule_T__26();
		EnterRule("T__26", 19);
		TraceIn("T__26", 19);
		try
		{
			int _type = T__26;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:27:7: ( '^' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:27:9: '^'
			{
			DebugLocation(27, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__26", 19);
			LeaveRule("T__26", 19);
			LeaveRule_T__26();
		}
	}
	// $ANTLR end "T__26"

	partial void EnterRule_T__27();
	partial void LeaveRule_T__27();

	// $ANTLR start "T__27"
	[GrammarRule("T__27")]
	private void mT__27()
	{
		EnterRule_T__27();
		EnterRule("T__27", 20);
		TraceIn("T__27", 20);
		try
		{
			int _type = T__27;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:28:7: ( 'false' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:28:9: 'false'
			{
			DebugLocation(28, 9);
			Match("false"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__27", 20);
			LeaveRule("T__27", 20);
			LeaveRule_T__27();
		}
	}
	// $ANTLR end "T__27"

	partial void EnterRule_T__28();
	partial void LeaveRule_T__28();

	// $ANTLR start "T__28"
	[GrammarRule("T__28")]
	private void mT__28()
	{
		EnterRule_T__28();
		EnterRule("T__28", 21);
		TraceIn("T__28", 21);
		try
		{
			int _type = T__28;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:29:7: ( 'true' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:29:9: 'true'
			{
			DebugLocation(29, 9);
			Match("true"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__28", 21);
			LeaveRule("T__28", 21);
			LeaveRule_T__28();
		}
	}
	// $ANTLR end "T__28"

	partial void EnterRule_T__29();
	partial void LeaveRule_T__29();

	// $ANTLR start "T__29"
	[GrammarRule("T__29")]
	private void mT__29()
	{
		EnterRule_T__29();
		EnterRule("T__29", 22);
		TraceIn("T__29", 22);
		try
		{
			int _type = T__29;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:30:7: ( '||' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:30:9: '||'
			{
			DebugLocation(30, 9);
			Match("||"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__29", 22);
			LeaveRule("T__29", 22);
			LeaveRule_T__29();
		}
	}
	// $ANTLR end "T__29"

	partial void EnterRule_IDENTIFIER();
	partial void LeaveRule_IDENTIFIER();

	// $ANTLR start "IDENTIFIER"
	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		EnterRule_IDENTIFIER();
		EnterRule("IDENTIFIER", 23);
		TraceIn("IDENTIFIER", 23);
		try
		{
			int _type = IDENTIFIER;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:111:12: ( ( 'A' .. 'Z' | 'a' .. 'z' | '_' ) ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:111:14: ( 'A' .. 'Z' | 'a' .. 'z' | '_' ) ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )*
			{
			DebugLocation(111, 14);
			if ((input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z'))
			{
				input.Consume();
			}
			else
			{
				MismatchedSetException mse = new MismatchedSetException(null,input);
				DebugRecognitionException(mse);
				Recover(mse);
				throw mse;
			}

			DebugLocation(111, 41);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:111:41: ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if (((LA1_1>='0' && LA1_1<='9')||(LA1_1>='A' && LA1_1<='Z')||LA1_1=='_'||(LA1_1>='a' && LA1_1<='z')))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
					{
					DebugLocation(111, 41);
					input.Consume();


					}
					break;

				default:
					goto loop1;
				}
			}

			loop1:
				;

			} finally { DebugExitSubRule(1); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IDENTIFIER", 23);
			LeaveRule("IDENTIFIER", 23);
			LeaveRule_IDENTIFIER();
		}
	}
	// $ANTLR end "IDENTIFIER"

	partial void EnterRule_QUOTED_STRING();
	partial void LeaveRule_QUOTED_STRING();

	// $ANTLR start "QUOTED_STRING"
	[GrammarRule("QUOTED_STRING")]
	private void mQUOTED_STRING()
	{
		EnterRule_QUOTED_STRING();
		EnterRule("QUOTED_STRING", 24);
		TraceIn("QUOTED_STRING", 24);
		try
		{
			int _type = QUOTED_STRING;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:113:15: ( '\"' (~ ( '\\r' | '\\n' | '\"' ) )* '\"' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:113:17: '\"' (~ ( '\\r' | '\\n' | '\"' ) )* '\"'
			{
			DebugLocation(113, 17);
			Match('\"'); 
			DebugLocation(113, 21);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:113:21: (~ ( '\\r' | '\\n' | '\"' ) )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if (((LA2_1>='\u0000' && LA2_1<='\t')||(LA2_1>='\u000B' && LA2_1<='\f')||(LA2_1>='\u000E' && LA2_1<='!')||(LA2_1>='#' && LA2_1<='\uFFFF')))
				{
					alt2 = 1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
					{
					DebugLocation(113, 21);
					input.Consume();


					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(113, 46);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTED_STRING", 24);
			LeaveRule("QUOTED_STRING", 24);
			LeaveRule_QUOTED_STRING();
		}
	}
	// $ANTLR end "QUOTED_STRING"

	partial void EnterRule_REAL();
	partial void LeaveRule_REAL();

	// $ANTLR start "REAL"
	[GrammarRule("REAL")]
	private void mREAL()
	{
		EnterRule_REAL();
		EnterRule("REAL", 25);
		TraceIn("REAL", 25);
		try
		{
			int _type = REAL;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:6: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
			int alt7=2;
			try { DebugEnterDecision(7, false);
			int LA7_1 = input.LA(1);

			if (((LA7_1>='0' && LA7_1<='9')))
			{
				alt7 = 1;
			}
			else if ((LA7_1=='.'))
			{
				alt7 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 7, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:8: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
				{
				DebugLocation(115, 8);
				// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:8: ( '0' .. '9' )+
				int cnt3=0;
				try { DebugEnterSubRule(3);
				while (true)
				{
					int alt3=2;
					try { DebugEnterDecision(3, false);
					int LA3_1 = input.LA(1);

					if (((LA3_1>='0' && LA3_1<='9')))
					{
						alt3 = 1;
					}


					} finally { DebugExitDecision(3); }
					switch (alt3)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
						{
						DebugLocation(115, 8);
						input.Consume();


						}
						break;

					default:
						if (cnt3 >= 1)
							goto loop3;

						EarlyExitException eee3 = new EarlyExitException( 3, input );
						DebugRecognitionException(eee3);
						throw eee3;
					}
					cnt3++;
				}
				loop3:
					;

				} finally { DebugExitSubRule(3); }

				DebugLocation(115, 19);
				// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:19: ( '.' ( '0' .. '9' )+ )?
				int alt5=2;
				try { DebugEnterSubRule(5);
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1=='.'))
				{
					alt5 = 1;
				}
				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:20: '.' ( '0' .. '9' )+
					{
					DebugLocation(115, 20);
					Match('.'); 
					DebugLocation(115, 24);
					// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:115:24: ( '0' .. '9' )+
					int cnt4=0;
					try { DebugEnterSubRule(4);
					while (true)
					{
						int alt4=2;
						try { DebugEnterDecision(4, false);
						int LA4_1 = input.LA(1);

						if (((LA4_1>='0' && LA4_1<='9')))
						{
							alt4 = 1;
						}


						} finally { DebugExitDecision(4); }
						switch (alt4)
						{
						case 1:
							DebugEnterAlt(1);
							// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
							{
							DebugLocation(115, 24);
							input.Consume();


							}
							break;

						default:
							if (cnt4 >= 1)
								goto loop4;

							EarlyExitException eee4 = new EarlyExitException( 4, input );
							DebugRecognitionException(eee4);
							throw eee4;
						}
						cnt4++;
					}
					loop4:
						;

					} finally { DebugExitSubRule(4); }


					}
					break;

				}
				} finally { DebugExitSubRule(5); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:116:8: '.' ( '0' .. '9' )+
				{
				DebugLocation(116, 8);
				Match('.'); 
				DebugLocation(116, 11);
				// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:116:11: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, false);
					int LA6_1 = input.LA(1);

					if (((LA6_1>='0' && LA6_1<='9')))
					{
						alt6 = 1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
						{
						DebugLocation(116, 11);
						input.Consume();


						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REAL", 25);
			LeaveRule("REAL", 25);
			LeaveRule_REAL();
		}
	}
	// $ANTLR end "REAL"

	partial void EnterRule_WS();
	partial void LeaveRule_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		EnterRule_WS();
		EnterRule("WS", 26);
		TraceIn("WS", 26);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:117:4: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:117:7: ( ' ' | '\\t' | '\\r' | '\\n' )+
			{
			DebugLocation(117, 7);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:117:7: ( ' ' | '\\t' | '\\r' | '\\n' )+
			int cnt8=0;
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, false);
				int LA8_1 = input.LA(1);

				if (((LA8_1>='\t' && LA8_1<='\n')||LA8_1=='\r'||LA8_1==' '))
				{
					alt8 = 1;
				}


				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:
					{
					DebugLocation(117, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt8 >= 1)
						goto loop8;

					EarlyExitException eee8 = new EarlyExitException( 8, input );
					DebugRecognitionException(eee8);
					throw eee8;
				}
				cnt8++;
			}
			loop8:
				;

			} finally { DebugExitSubRule(8); }

			DebugLocation(117, 29);
			Skip();

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 26);
			LeaveRule("WS", 26);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:8: ( T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | T__15 | T__16 | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | T__24 | T__25 | T__26 | T__27 | T__28 | T__29 | IDENTIFIER | QUOTED_STRING | REAL | WS )
		int alt9=26;
		try { DebugEnterDecision(9, false);
		switch (input.LA(1))
		{
		case '!':
			{
			int LA9_2 = input.LA(2);

			if ((LA9_2=='='))
			{
				alt9 = 2;
			}
			else
			{
				alt9 = 1;
			}
			}
			break;
		case '&':
			{
			alt9 = 3;
			}
			break;
		case '(':
			{
			alt9 = 4;
			}
			break;
		case ')':
			{
			alt9 = 5;
			}
			break;
		case '*':
			{
			alt9 = 6;
			}
			break;
		case '+':
			{
			alt9 = 7;
			}
			break;
		case ',':
			{
			alt9 = 8;
			}
			break;
		case '-':
			{
			alt9 = 9;
			}
			break;
		case '.':
			{
			int LA9_2 = input.LA(2);

			if (((LA9_2>='0' && LA9_2<='9')))
			{
				alt9 = 25;
			}
			else
			{
				alt9 = 10;
			}
			}
			break;
		case '/':
			{
			alt9 = 11;
			}
			break;
		case '<':
			{
			int LA9_2 = input.LA(2);

			if ((LA9_2=='='))
			{
				alt9 = 13;
			}
			else
			{
				alt9 = 12;
			}
			}
			break;
		case '=':
			{
			alt9 = 14;
			}
			break;
		case '>':
			{
			int LA9_2 = input.LA(2);

			if ((LA9_2=='='))
			{
				alt9 = 16;
			}
			else
			{
				alt9 = 15;
			}
			}
			break;
		case '[':
			{
			alt9 = 17;
			}
			break;
		case ']':
			{
			alt9 = 18;
			}
			break;
		case '^':
			{
			alt9 = 19;
			}
			break;
		case 'f':
			{
			int LA9_2 = input.LA(2);

			if ((LA9_2=='a'))
			{
				int LA9_3 = input.LA(3);

				if ((LA9_3=='l'))
				{
					int LA9_4 = input.LA(4);

					if ((LA9_4=='s'))
					{
						int LA9_5 = input.LA(5);

						if ((LA9_5=='e'))
						{
							int LA9_6 = input.LA(6);

							if (((LA9_6>='0' && LA9_6<='9')||(LA9_6>='A' && LA9_6<='Z')||LA9_6=='_'||(LA9_6>='a' && LA9_6<='z')))
							{
								alt9 = 23;
							}
							else
							{
								alt9 = 20;
							}
						}
						else
						{
							alt9 = 23;
						}
					}
					else
					{
						alt9 = 23;
					}
				}
				else
				{
					alt9 = 23;
				}
			}
			else
			{
				alt9 = 23;
			}
			}
			break;
		case 't':
			{
			int LA9_2 = input.LA(2);

			if ((LA9_2=='r'))
			{
				int LA9_3 = input.LA(3);

				if ((LA9_3=='u'))
				{
					int LA9_4 = input.LA(4);

					if ((LA9_4=='e'))
					{
						int LA9_5 = input.LA(5);

						if (((LA9_5>='0' && LA9_5<='9')||(LA9_5>='A' && LA9_5<='Z')||LA9_5=='_'||(LA9_5>='a' && LA9_5<='z')))
						{
							alt9 = 23;
						}
						else
						{
							alt9 = 21;
						}
					}
					else
					{
						alt9 = 23;
					}
				}
				else
				{
					alt9 = 23;
				}
			}
			else
			{
				alt9 = 23;
			}
			}
			break;
		case '|':
			{
			alt9 = 22;
			}
			break;
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'G':
		case 'H':
		case 'I':
		case 'J':
		case 'K':
		case 'L':
		case 'M':
		case 'N':
		case 'O':
		case 'P':
		case 'Q':
		case 'R':
		case 'S':
		case 'T':
		case 'U':
		case 'V':
		case 'W':
		case 'X':
		case 'Y':
		case 'Z':
		case '_':
		case 'a':
		case 'b':
		case 'c':
		case 'd':
		case 'e':
		case 'g':
		case 'h':
		case 'i':
		case 'j':
		case 'k':
		case 'l':
		case 'm':
		case 'n':
		case 'o':
		case 'p':
		case 'q':
		case 'r':
		case 's':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
			{
			alt9 = 23;
			}
			break;
		case '\"':
			{
			alt9 = 24;
			}
			break;
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
			{
			alt9 = 25;
			}
			break;
		case '\t':
		case '\n':
		case '\r':
		case ' ':
			{
			alt9 = 26;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(9); }
		switch (alt9)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:10: T__8
			{
			DebugLocation(1, 10);
			mT__8(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:15: T__9
			{
			DebugLocation(1, 15);
			mT__9(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:20: T__10
			{
			DebugLocation(1, 20);
			mT__10(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:26: T__11
			{
			DebugLocation(1, 26);
			mT__11(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:32: T__12
			{
			DebugLocation(1, 32);
			mT__12(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:38: T__13
			{
			DebugLocation(1, 38);
			mT__13(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:44: T__14
			{
			DebugLocation(1, 44);
			mT__14(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:50: T__15
			{
			DebugLocation(1, 50);
			mT__15(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:56: T__16
			{
			DebugLocation(1, 56);
			mT__16(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:62: T__17
			{
			DebugLocation(1, 62);
			mT__17(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:68: T__18
			{
			DebugLocation(1, 68);
			mT__18(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:74: T__19
			{
			DebugLocation(1, 74);
			mT__19(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:80: T__20
			{
			DebugLocation(1, 80);
			mT__20(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:86: T__21
			{
			DebugLocation(1, 86);
			mT__21(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:92: T__22
			{
			DebugLocation(1, 92);
			mT__22(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:98: T__23
			{
			DebugLocation(1, 98);
			mT__23(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:104: T__24
			{
			DebugLocation(1, 104);
			mT__24(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:110: T__25
			{
			DebugLocation(1, 110);
			mT__25(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:116: T__26
			{
			DebugLocation(1, 116);
			mT__26(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:122: T__27
			{
			DebugLocation(1, 122);
			mT__27(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:128: T__28
			{
			DebugLocation(1, 128);
			mT__28(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:134: T__29
			{
			DebugLocation(1, 134);
			mT__29(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:140: IDENTIFIER
			{
			DebugLocation(1, 140);
			mIDENTIFIER(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:151: QUOTED_STRING
			{
			DebugLocation(1, 151);
			mQUOTED_STRING(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:165: REAL
			{
			DebugLocation(1, 165);
			mREAL(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// C:\\workspace\\SharpExpressions\\Lib\\\\Parser\\SharpExpressions.g:1:170: WS
			{
			DebugLocation(1, 170);
			mWS(); 

			}
			break;

		}

	}


	#region DFA

	protected override void InitDFAs()
	{
		base.InitDFAs();
	}

	#endregion

}

} // namespace SharpExpressions.Parser
