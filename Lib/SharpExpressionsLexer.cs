//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.2 C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g 2015-05-06 00:17:20

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

namespace SharpExpressions.parser
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.5.0.2")]
[System.CLSCompliant(false)]
public partial class SharpExpressionsLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int IDENTIFIER=4;
	public const int REAL=5;
	public const int WS=6;
	public const int T__7=7;
	public const int T__8=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;

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
	public override string GrammarFileName { get { return "C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void EnterRule_T__7();
	partial void LeaveRule_T__7();

	// $ANTLR start "T__7"
	[GrammarRule("T__7")]
	private void mT__7()
	{
		EnterRule_T__7();
		EnterRule("T__7", 1);
		TraceIn("T__7", 1);
		try
		{
			int _type = T__7;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:9:6: ( '(' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:9:8: '('
			{
			DebugLocation(9, 8);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__7", 1);
			LeaveRule("T__7", 1);
			LeaveRule_T__7();
		}
	}
	// $ANTLR end "T__7"

	partial void EnterRule_T__8();
	partial void LeaveRule_T__8();

	// $ANTLR start "T__8"
	[GrammarRule("T__8")]
	private void mT__8()
	{
		EnterRule_T__8();
		EnterRule("T__8", 2);
		TraceIn("T__8", 2);
		try
		{
			int _type = T__8;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:10:6: ( ')' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:10:8: ')'
			{
			DebugLocation(10, 8);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__8", 2);
			LeaveRule("T__8", 2);
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
		EnterRule("T__9", 3);
		TraceIn("T__9", 3);
		try
		{
			int _type = T__9;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:11:6: ( '*' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:11:8: '*'
			{
			DebugLocation(11, 8);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__9", 3);
			LeaveRule("T__9", 3);
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
		EnterRule("T__10", 4);
		TraceIn("T__10", 4);
		try
		{
			int _type = T__10;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:12:7: ( '+' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:12:9: '+'
			{
			DebugLocation(12, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__10", 4);
			LeaveRule("T__10", 4);
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
		EnterRule("T__11", 5);
		TraceIn("T__11", 5);
		try
		{
			int _type = T__11;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:13:7: ( '-' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:13:9: '-'
			{
			DebugLocation(13, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__11", 5);
			LeaveRule("T__11", 5);
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
		EnterRule("T__12", 6);
		TraceIn("T__12", 6);
		try
		{
			int _type = T__12;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:14:7: ( '.' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:14:9: '.'
			{
			DebugLocation(14, 9);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__12", 6);
			LeaveRule("T__12", 6);
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
		EnterRule("T__13", 7);
		TraceIn("T__13", 7);
		try
		{
			int _type = T__13;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:7: ( '/' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:9: '/'
			{
			DebugLocation(15, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__13", 7);
			LeaveRule("T__13", 7);
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
		EnterRule("T__14", 8);
		TraceIn("T__14", 8);
		try
		{
			int _type = T__14;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:16:7: ( '^' )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:16:9: '^'
			{
			DebugLocation(16, 9);
			Match('^'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__14", 8);
			LeaveRule("T__14", 8);
			LeaveRule_T__14();
		}
	}
	// $ANTLR end "T__14"

	partial void EnterRule_IDENTIFIER();
	partial void LeaveRule_IDENTIFIER();

	// $ANTLR start "IDENTIFIER"
	[GrammarRule("IDENTIFIER")]
	private void mIDENTIFIER()
	{
		EnterRule_IDENTIFIER();
		EnterRule("IDENTIFIER", 9);
		TraceIn("IDENTIFIER", 9);
		try
		{
			int _type = IDENTIFIER;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:55:12: ( ( 'A' .. 'Z' | 'a' .. 'z' | '_' ) ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:55:14: ( 'A' .. 'Z' | 'a' .. 'z' | '_' ) ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )*
			{
			DebugLocation(55, 14);
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

			DebugLocation(55, 41);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:55:41: ( 'A' .. 'Z' | 'a' .. 'z' | '0' .. '9' | '_' )*
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
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:
					{
					DebugLocation(55, 41);
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
			TraceOut("IDENTIFIER", 9);
			LeaveRule("IDENTIFIER", 9);
			LeaveRule_IDENTIFIER();
		}
	}
	// $ANTLR end "IDENTIFIER"

	partial void EnterRule_REAL();
	partial void LeaveRule_REAL();

	// $ANTLR start "REAL"
	[GrammarRule("REAL")]
	private void mREAL()
	{
		EnterRule_REAL();
		EnterRule("REAL", 10);
		TraceIn("REAL", 10);
		try
		{
			int _type = REAL;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:6: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? | '.' ( '0' .. '9' )+ )
			int alt6=2;
			try { DebugEnterDecision(6, false);
			int LA6_1 = input.LA(1);

			if (((LA6_1>='0' && LA6_1<='9')))
			{
				alt6 = 1;
			}
			else if ((LA6_1=='.'))
			{
				alt6 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 6, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:8: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
				{
				DebugLocation(57, 8);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:8: ( '0' .. '9' )+
				int cnt2=0;
				try { DebugEnterSubRule(2);
				while (true)
				{
					int alt2=2;
					try { DebugEnterDecision(2, false);
					int LA2_1 = input.LA(1);

					if (((LA2_1>='0' && LA2_1<='9')))
					{
						alt2 = 1;
					}


					} finally { DebugExitDecision(2); }
					switch (alt2)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:
						{
						DebugLocation(57, 8);
						input.Consume();


						}
						break;

					default:
						if (cnt2 >= 1)
							goto loop2;

						EarlyExitException eee2 = new EarlyExitException( 2, input );
						DebugRecognitionException(eee2);
						throw eee2;
					}
					cnt2++;
				}
				loop2:
					;

				} finally { DebugExitSubRule(2); }

				DebugLocation(57, 19);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:19: ( '.' ( '0' .. '9' )+ )?
				int alt4=2;
				try { DebugEnterSubRule(4);
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1=='.'))
				{
					alt4 = 1;
				}
				} finally { DebugExitDecision(4); }
				switch (alt4)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:20: '.' ( '0' .. '9' )+
					{
					DebugLocation(57, 20);
					Match('.'); 
					DebugLocation(57, 24);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:24: ( '0' .. '9' )+
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
							// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:
							{
							DebugLocation(57, 24);
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


					}
					break;

				}
				} finally { DebugExitSubRule(4); }


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:58:8: '.' ( '0' .. '9' )+
				{
				DebugLocation(58, 8);
				Match('.'); 
				DebugLocation(58, 11);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:58:11: ( '0' .. '9' )+
				int cnt5=0;
				try { DebugEnterSubRule(5);
				while (true)
				{
					int alt5=2;
					try { DebugEnterDecision(5, false);
					int LA5_1 = input.LA(1);

					if (((LA5_1>='0' && LA5_1<='9')))
					{
						alt5 = 1;
					}


					} finally { DebugExitDecision(5); }
					switch (alt5)
					{
					case 1:
						DebugEnterAlt(1);
						// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:
						{
						DebugLocation(58, 11);
						input.Consume();


						}
						break;

					default:
						if (cnt5 >= 1)
							goto loop5;

						EarlyExitException eee5 = new EarlyExitException( 5, input );
						DebugRecognitionException(eee5);
						throw eee5;
					}
					cnt5++;
				}
				loop5:
					;

				} finally { DebugExitSubRule(5); }


				}
				break;

			}
			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("REAL", 10);
			LeaveRule("REAL", 10);
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
		EnterRule("WS", 11);
		TraceIn("WS", 11);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:59:4: ( ( ' ' | '\\t' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:59:7: ( ' ' | '\\t' | '\\r' | '\\n' )+
			{
			DebugLocation(59, 7);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:59:7: ( ' ' | '\\t' | '\\r' | '\\n' )+
			int cnt7=0;
			try { DebugEnterSubRule(7);
			while (true)
			{
				int alt7=2;
				try { DebugEnterDecision(7, false);
				int LA7_1 = input.LA(1);

				if (((LA7_1>='\t' && LA7_1<='\n')||LA7_1=='\r'||LA7_1==' '))
				{
					alt7 = 1;
				}


				} finally { DebugExitDecision(7); }
				switch (alt7)
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:
					{
					DebugLocation(59, 7);
					input.Consume();


					}
					break;

				default:
					if (cnt7 >= 1)
						goto loop7;

					EarlyExitException eee7 = new EarlyExitException( 7, input );
					DebugRecognitionException(eee7);
					throw eee7;
				}
				cnt7++;
			}
			loop7:
				;

			} finally { DebugExitSubRule(7); }

			DebugLocation(59, 29);
			Skip();

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 11);
			LeaveRule("WS", 11);
			LeaveRule_WS();
		}
	}
	// $ANTLR end "WS"

	public override void mTokens()
	{
		// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:8: ( T__7 | T__8 | T__9 | T__10 | T__11 | T__12 | T__13 | T__14 | IDENTIFIER | REAL | WS )
		int alt8=11;
		try { DebugEnterDecision(8, false);
		switch (input.LA(1))
		{
		case '(':
			{
			alt8 = 1;
			}
			break;
		case ')':
			{
			alt8 = 2;
			}
			break;
		case '*':
			{
			alt8 = 3;
			}
			break;
		case '+':
			{
			alt8 = 4;
			}
			break;
		case '-':
			{
			alt8 = 5;
			}
			break;
		case '.':
			{
			int LA8_2 = input.LA(2);

			if (((LA8_2>='0' && LA8_2<='9')))
			{
				alt8 = 10;
			}
			else
			{
				alt8 = 6;
			}
			}
			break;
		case '/':
			{
			alt8 = 7;
			}
			break;
		case '^':
			{
			alt8 = 8;
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
		case 'f':
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
		case 't':
		case 'u':
		case 'v':
		case 'w':
		case 'x':
		case 'y':
		case 'z':
			{
			alt8 = 9;
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
			alt8 = 10;
			}
			break;
		case '\t':
		case '\n':
		case '\r':
		case ' ':
			{
			alt8 = 11;
			}
			break;
		default:
			{
				NoViableAltException nvae = new NoViableAltException("", 8, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
		}

		} finally { DebugExitDecision(8); }
		switch (alt8)
		{
		case 1:
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:10: T__7
			{
			DebugLocation(1, 10);
			mT__7(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:15: T__8
			{
			DebugLocation(1, 15);
			mT__8(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:20: T__9
			{
			DebugLocation(1, 20);
			mT__9(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:25: T__10
			{
			DebugLocation(1, 25);
			mT__10(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:31: T__11
			{
			DebugLocation(1, 31);
			mT__11(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:37: T__12
			{
			DebugLocation(1, 37);
			mT__12(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:43: T__13
			{
			DebugLocation(1, 43);
			mT__13(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:49: T__14
			{
			DebugLocation(1, 49);
			mT__14(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:55: IDENTIFIER
			{
			DebugLocation(1, 55);
			mIDENTIFIER(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:66: REAL
			{
			DebugLocation(1, 66);
			mREAL(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:1:71: WS
			{
			DebugLocation(1, 71);
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

} // namespace SharpExpressions.parser
