//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.2 C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g 2015-05-06 00:17:19

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
public partial class SharpExpressionsParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "IDENTIFIER", "REAL", "WS", "'('", "')'", "'*'", "'+'", "'-'", "'.'", "'/'", "'^'"
	};
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

	public SharpExpressionsParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public SharpExpressionsParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
	}

	public override string[] TokenNames { get { return SharpExpressionsParser.tokenNames; } }
	public override string GrammarFileName { get { return "C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_eval();
	partial void LeaveRule_eval();
	// $ANTLR start "eval"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:14:8: public eval returns [Queue queue] :Q= addition_expression ;
	[GrammarRule("eval")]
	public Queue eval()
	{
		EnterRule_eval();
		EnterRule("eval", 1);
		TraceIn("eval", 1);
		Queue queue = default(Queue);


		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "eval");
		DebugLocation(14, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:3: (Q= addition_expression )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:5: Q= addition_expression
			{
			DebugLocation(15, 5);
			 allocate_queues(5); 
			DebugLocation(15, 30);
			PushFollow(Follow._addition_expression_in_eval56);
			Q=addition_expression();
			PopFollow();

			DebugLocation(15, 51);
			 queue=Q; 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("eval", 1);
			LeaveRule("eval", 1);
			LeaveRule_eval();
		}
		DebugLocation(16, 2);
		} finally { DebugExitRule(GrammarFileName, "eval"); }
		return queue;

	}
	// $ANTLR end "eval"

	partial void EnterRule_addition_expression();
	partial void LeaveRule_addition_expression();
	// $ANTLR start "addition_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:18:1: addition_expression returns [Queue ret] : Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )* ;
	[GrammarRule("addition_expression")]
	private Queue addition_expression()
	{
		EnterRule_addition_expression();
		EnterRule("addition_expression", 2);
		TraceIn("addition_expression", 2);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "addition_expression");
		DebugLocation(18, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:19:3: (Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:19:5: Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )*
			{
			DebugLocation(19, 7);
			PushFollow(Follow._multiply_expression_in_addition_expression77);
			Q1=multiply_expression();
			PopFollow();

			DebugLocation(19, 28);
			 ret=Q1; 
			DebugLocation(20, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:20:5: ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=3;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if ((LA1_1==10))
				{
					alt1 = 1;
				}
				else if ((LA1_1==11))
				{
					alt1 = 2;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:20:7: '+' Q2= multiply_expression
					{
					DebugLocation(20, 7);
					Match(input,10,Follow._10_in_addition_expression87); 
					DebugLocation(20, 13);
					PushFollow(Follow._multiply_expression_in_addition_expression91);
					Q2=multiply_expression();
					PopFollow();

					DebugLocation(20, 34);
					 ret=push_operation(ret, Operator.Add, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:21:4: '-' Q2= multiply_expression
					{
					DebugLocation(21, 4);
					Match(input,11,Follow._11_in_addition_expression98); 
					DebugLocation(21, 10);
					PushFollow(Follow._multiply_expression_in_addition_expression102);
					Q2=multiply_expression();
					PopFollow();

					DebugLocation(21, 31);
					 ret=push_operation(ret, Operator.Sub, Q2); 

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

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("addition_expression", 2);
			LeaveRule("addition_expression", 2);
			LeaveRule_addition_expression();
		}
		DebugLocation(22, 2);
		} finally { DebugExitRule(GrammarFileName, "addition_expression"); }
		return ret;

	}
	// $ANTLR end "addition_expression"

	partial void EnterRule_multiply_expression();
	partial void LeaveRule_multiply_expression();
	// $ANTLR start "multiply_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:24:1: multiply_expression returns [Queue ret] : Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )* ;
	[GrammarRule("multiply_expression")]
	private Queue multiply_expression()
	{
		EnterRule_multiply_expression();
		EnterRule("multiply_expression", 3);
		TraceIn("multiply_expression", 3);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "multiply_expression");
		DebugLocation(24, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:25:3: (Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:25:5: Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )*
			{
			DebugLocation(25, 7);
			PushFollow(Follow._power_expression_in_multiply_expression125);
			Q1=power_expression();
			PopFollow();

			DebugLocation(25, 25);
			 ret=Q1; 
			DebugLocation(26, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:26:5: ( '*' Q2= power_expression | '/' Q2= power_expression )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=3;
				try { DebugEnterDecision(2, false);
				int LA2_1 = input.LA(1);

				if ((LA2_1==9))
				{
					alt2 = 1;
				}
				else if ((LA2_1==13))
				{
					alt2 = 2;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:26:7: '*' Q2= power_expression
					{
					DebugLocation(26, 7);
					Match(input,9,Follow._9_in_multiply_expression135); 
					DebugLocation(26, 13);
					PushFollow(Follow._power_expression_in_multiply_expression139);
					Q2=power_expression();
					PopFollow();

					DebugLocation(26, 31);
					 ret=push_operation(ret, Operator.Mul, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:27:4: '/' Q2= power_expression
					{
					DebugLocation(27, 4);
					Match(input,13,Follow._13_in_multiply_expression146); 
					DebugLocation(27, 10);
					PushFollow(Follow._power_expression_in_multiply_expression150);
					Q2=power_expression();
					PopFollow();

					DebugLocation(27, 28);
					 ret=push_operation(ret, Operator.Div, Q2); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("multiply_expression", 3);
			LeaveRule("multiply_expression", 3);
			LeaveRule_multiply_expression();
		}
		DebugLocation(28, 2);
		} finally { DebugExitRule(GrammarFileName, "multiply_expression"); }
		return ret;

	}
	// $ANTLR end "multiply_expression"

	partial void EnterRule_power_expression();
	partial void LeaveRule_power_expression();
	// $ANTLR start "power_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:30:1: power_expression returns [Queue ret] : Q1= atomic_expression ( '^' Q2= atomic_expression )* ;
	[GrammarRule("power_expression")]
	private Queue power_expression()
	{
		EnterRule_power_expression();
		EnterRule("power_expression", 4);
		TraceIn("power_expression", 4);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "power_expression");
		DebugLocation(30, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:31:3: (Q1= atomic_expression ( '^' Q2= atomic_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:31:5: Q1= atomic_expression ( '^' Q2= atomic_expression )*
			{
			DebugLocation(31, 7);
			PushFollow(Follow._atomic_expression_in_power_expression173);
			Q1=atomic_expression();
			PopFollow();

			DebugLocation(31, 26);
			 ret=Q1; 
			DebugLocation(32, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:32:5: ( '^' Q2= atomic_expression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1==14))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:32:7: '^' Q2= atomic_expression
					{
					DebugLocation(32, 7);
					Match(input,14,Follow._14_in_power_expression183); 
					DebugLocation(32, 13);
					PushFollow(Follow._atomic_expression_in_power_expression187);
					Q2=atomic_expression();
					PopFollow();

					DebugLocation(32, 32);
					 ret=push_operation(ret, Operator.Pow, Q2); 

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("power_expression", 4);
			LeaveRule("power_expression", 4);
			LeaveRule_power_expression();
		}
		DebugLocation(33, 2);
		} finally { DebugExitRule(GrammarFileName, "power_expression"); }
		return ret;

	}
	// $ANTLR end "power_expression"

	partial void EnterRule_atomic_expression();
	partial void LeaveRule_atomic_expression();
	// $ANTLR start "atomic_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:35:1: atomic_expression returns [Queue ret] : (Q= factor | '(' Q= addition_expression ')' );
	[GrammarRule("atomic_expression")]
	private Queue atomic_expression()
	{
		EnterRule_atomic_expression();
		EnterRule("atomic_expression", 5);
		TraceIn("atomic_expression", 5);
		Queue ret = default(Queue);


		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "atomic_expression");
		DebugLocation(35, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:36:3: (Q= factor | '(' Q= addition_expression ')' )
			int alt4=2;
			try { DebugEnterDecision(4, false);
			int LA4_1 = input.LA(1);

			if (((LA4_1>=IDENTIFIER && LA4_1<=REAL)||LA4_1==11))
			{
				alt4 = 1;
			}
			else if ((LA4_1==7))
			{
				alt4 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:36:5: Q= factor
				{
				DebugLocation(36, 6);
				PushFollow(Follow._factor_in_atomic_expression211);
				Q=factor();
				PopFollow();

				DebugLocation(36, 14);
				 ret=Q; 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:37:5: '(' Q= addition_expression ')'
				{
				DebugLocation(37, 5);
				Match(input,7,Follow._7_in_atomic_expression219); 
				DebugLocation(37, 10);
				PushFollow(Follow._addition_expression_in_atomic_expression223);
				Q=addition_expression();
				PopFollow();

				DebugLocation(37, 31);
				Match(input,8,Follow._8_in_atomic_expression225); 
				DebugLocation(37, 35);
				 ret=Q; 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("atomic_expression", 5);
			LeaveRule("atomic_expression", 5);
			LeaveRule_atomic_expression();
		}
		DebugLocation(38, 2);
		} finally { DebugExitRule(GrammarFileName, "atomic_expression"); }
		return ret;

	}
	// $ANTLR end "atomic_expression"

	partial void EnterRule_factor();
	partial void LeaveRule_factor();
	// $ANTLR start "factor"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:40:1: factor returns [Queue ret] : ( '-' n= REAL |n= REAL | '-' Q= identifier_expression |Q= identifier_expression );
	[GrammarRule("factor")]
	private Queue factor()
	{
		EnterRule_factor();
		EnterRule("factor", 6);
		TraceIn("factor", 6);
		Queue ret = default(Queue);


		IToken n = default(IToken);
		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "factor");
		DebugLocation(40, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:41:3: ( '-' n= REAL |n= REAL | '-' Q= identifier_expression |Q= identifier_expression )
			int alt5=4;
			try { DebugEnterDecision(5, false);
			switch (input.LA(1))
			{
			case 11:
				{
				int LA5_2 = input.LA(2);

				if ((LA5_2==REAL))
				{
					alt5 = 1;
				}
				else if ((LA5_2==IDENTIFIER))
				{
					alt5 = 3;
				}
				else
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 1, input, 2);
					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case REAL:
				{
				alt5 = 2;
				}
				break;
			case IDENTIFIER:
				{
				alt5 = 4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 5, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:41:5: '-' n= REAL
				{
				DebugLocation(41, 5);
				Match(input,11,Follow._11_in_factor244); 
				DebugLocation(41, 10);
				n=(IToken)Match(input,REAL,Follow._REAL_in_factor248); 
				DebugLocation(41, 16);
				 ret=push_literal(new_queue(), "-" + (n!=null?n.Text:default(string))); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:42:5: n= REAL
				{
				DebugLocation(42, 6);
				n=(IToken)Match(input,REAL,Follow._REAL_in_factor258); 
				DebugLocation(42, 12);
				 ret=push_literal(new_queue(), (n!=null?n.Text:default(string))); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:43:5: '-' Q= identifier_expression
				{
				DebugLocation(43, 5);
				Match(input,11,Follow._11_in_factor266); 
				DebugLocation(43, 10);
				PushFollow(Follow._identifier_expression_in_factor270);
				Q=identifier_expression();
				PopFollow();

				DebugLocation(43, 33);
				 ret=push_operator(Q, Operator.Negate); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:44:5: Q= identifier_expression
				{
				DebugLocation(44, 6);
				PushFollow(Follow._identifier_expression_in_factor280);
				Q=identifier_expression();
				PopFollow();

				DebugLocation(44, 29);
				 ret=Q; 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("factor", 6);
			LeaveRule("factor", 6);
			LeaveRule_factor();
		}
		DebugLocation(45, 2);
		} finally { DebugExitRule(GrammarFileName, "factor"); }
		return ret;

	}
	// $ANTLR end "factor"

	partial void EnterRule_identifier_expression();
	partial void LeaveRule_identifier_expression();
	// $ANTLR start "identifier_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:47:1: identifier_expression returns [Queue ret] : a= IDENTIFIER ( '.' b= IDENTIFIER )* ;
	[GrammarRule("identifier_expression")]
	private Queue identifier_expression()
	{
		EnterRule_identifier_expression();
		EnterRule("identifier_expression", 7);
		TraceIn("identifier_expression", 7);
		Queue ret = default(Queue);


		IToken a = default(IToken);
		IToken b = default(IToken);

		try { DebugEnterRule(GrammarFileName, "identifier_expression");
		DebugLocation(47, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:48:3: (a= IDENTIFIER ( '.' b= IDENTIFIER )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:48:5: a= IDENTIFIER ( '.' b= IDENTIFIER )*
			{
			DebugLocation(48, 6);
			a=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_identifier_expression301); 
			DebugLocation(48, 18);
			 ret=push_identifier(new_queue(), (a!=null?a.Text:default(string))); 
			DebugLocation(48, 65);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:48:65: ( '.' b= IDENTIFIER )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, false);
				int LA6_1 = input.LA(1);

				if ((LA6_1==12))
				{
					alt6 = 1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:48:66: '.' b= IDENTIFIER
					{
					DebugLocation(48, 66);
					Match(input,12,Follow._12_in_identifier_expression306); 
					DebugLocation(48, 71);
					b=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_identifier_expression310); 
					DebugLocation(48, 83);
					 ret=push_operator(push_identifier(ret, (b!=null?b.Text:default(string))), Operator.MemberAccess); 

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("identifier_expression", 7);
			LeaveRule("identifier_expression", 7);
			LeaveRule_identifier_expression();
		}
		DebugLocation(49, 2);
		} finally { DebugExitRule(GrammarFileName, "identifier_expression"); }
		return ret;

	}
	// $ANTLR end "identifier_expression"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _addition_expression_in_eval56 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _multiply_expression_in_addition_expression77 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _10_in_addition_expression87 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _multiply_expression_in_addition_expression91 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _11_in_addition_expression98 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _multiply_expression_in_addition_expression102 = new BitSet(new ulong[]{0xC02UL});
		public static readonly BitSet _power_expression_in_multiply_expression125 = new BitSet(new ulong[]{0x2202UL});
		public static readonly BitSet _9_in_multiply_expression135 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _power_expression_in_multiply_expression139 = new BitSet(new ulong[]{0x2202UL});
		public static readonly BitSet _13_in_multiply_expression146 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _power_expression_in_multiply_expression150 = new BitSet(new ulong[]{0x2202UL});
		public static readonly BitSet _atomic_expression_in_power_expression173 = new BitSet(new ulong[]{0x4002UL});
		public static readonly BitSet _14_in_power_expression183 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _atomic_expression_in_power_expression187 = new BitSet(new ulong[]{0x4002UL});
		public static readonly BitSet _factor_in_atomic_expression211 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _7_in_atomic_expression219 = new BitSet(new ulong[]{0x8B0UL});
		public static readonly BitSet _addition_expression_in_atomic_expression223 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _8_in_atomic_expression225 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _11_in_factor244 = new BitSet(new ulong[]{0x20UL});
		public static readonly BitSet _REAL_in_factor248 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REAL_in_factor258 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _11_in_factor266 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _identifier_expression_in_factor270 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_expression_in_factor280 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_identifier_expression301 = new BitSet(new ulong[]{0x1002UL});
		public static readonly BitSet _12_in_identifier_expression306 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _IDENTIFIER_in_identifier_expression310 = new BitSet(new ulong[]{0x1002UL});
	}
	#endregion Follow sets
}

} // namespace SharpExpressions.parser
