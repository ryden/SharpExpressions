//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.5.0.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.5.0.2 C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g 2015-05-06 00:56:37

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
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "IDENTIFIER", "REAL", "WS", "'!'", "'!='", "'&&'", "'('", "')'", "'*'", "'+'", "'-'", "'.'", "'/'", "'<'", "'<='", "'=='", "'>'", "'>='", "'^'", "'false'", "'true'", "'||'"
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
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:14:8: public eval returns [Queue queue] :Q= expression ;
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
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:3: (Q= expression )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:15:5: Q= expression
			{
			DebugLocation(15, 5);
			 allocate_queues(5); 
			DebugLocation(15, 30);
			PushFollow(Follow._expression_in_eval56);
			Q=expression();
			PopFollow();

			DebugLocation(15, 42);
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

	partial void EnterRule_expression();
	partial void LeaveRule_expression();
	// $ANTLR start "expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:18:1: expression returns [Queue ret] : Q= boolean_expression ;
	[GrammarRule("expression")]
	private Queue expression()
	{
		EnterRule_expression();
		EnterRule("expression", 2);
		TraceIn("expression", 2);
		Queue ret = default(Queue);


		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(18, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:19:3: (Q= boolean_expression )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:19:5: Q= boolean_expression
			{
			DebugLocation(19, 6);
			PushFollow(Follow._boolean_expression_in_expression77);
			Q=boolean_expression();
			PopFollow();

			DebugLocation(19, 26);
			 ret = Q; 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expression", 2);
			LeaveRule("expression", 2);
			LeaveRule_expression();
		}
		DebugLocation(20, 2);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return ret;

	}
	// $ANTLR end "expression"

	partial void EnterRule_boolean_expression();
	partial void LeaveRule_boolean_expression();
	// $ANTLR start "boolean_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:22:1: boolean_expression returns [Queue ret] : Q1= comparison ( '&&' Q2= comparison | '||' Q2= comparison )* ;
	[GrammarRule("boolean_expression")]
	private Queue boolean_expression()
	{
		EnterRule_boolean_expression();
		EnterRule("boolean_expression", 3);
		TraceIn("boolean_expression", 3);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "boolean_expression");
		DebugLocation(22, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:23:3: (Q1= comparison ( '&&' Q2= comparison | '||' Q2= comparison )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:23:5: Q1= comparison ( '&&' Q2= comparison | '||' Q2= comparison )*
			{
			DebugLocation(23, 7);
			PushFollow(Follow._comparison_in_boolean_expression98);
			Q1=comparison();
			PopFollow();

			DebugLocation(23, 19);
			 ret=Q1; 
			DebugLocation(24, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:24:5: ( '&&' Q2= comparison | '||' Q2= comparison )*
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=3;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if ((LA1_1==9))
				{
					alt1 = 1;
				}
				else if ((LA1_1==25))
				{
					alt1 = 2;
				}


				} finally { DebugExitDecision(1); }
				switch ( alt1 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:24:7: '&&' Q2= comparison
					{
					DebugLocation(24, 7);
					Match(input,9,Follow._9_in_boolean_expression108); 
					DebugLocation(24, 14);
					PushFollow(Follow._comparison_in_boolean_expression112);
					Q2=comparison();
					PopFollow();

					DebugLocation(24, 26);
					 ret=push_operation(ret, Operator.And, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:25:4: '||' Q2= comparison
					{
					DebugLocation(25, 4);
					Match(input,25,Follow._25_in_boolean_expression119); 
					DebugLocation(25, 11);
					PushFollow(Follow._comparison_in_boolean_expression123);
					Q2=comparison();
					PopFollow();

					DebugLocation(25, 23);
					 ret=push_operation(ret, Operator.Or,  Q2); 

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
			TraceOut("boolean_expression", 3);
			LeaveRule("boolean_expression", 3);
			LeaveRule_boolean_expression();
		}
		DebugLocation(26, 2);
		} finally { DebugExitRule(GrammarFileName, "boolean_expression"); }
		return ret;

	}
	// $ANTLR end "boolean_expression"

	partial void EnterRule_comparison();
	partial void LeaveRule_comparison();
	// $ANTLR start "comparison"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:28:1: comparison returns [Queue ret] : Q1= addition_expression ( '>=' Q2= addition_expression | '>' Q2= addition_expression | '<=' Q2= addition_expression | '<' Q2= addition_expression | '==' Q2= addition_expression | '!=' Q2= addition_expression )* ;
	[GrammarRule("comparison")]
	private Queue comparison()
	{
		EnterRule_comparison();
		EnterRule("comparison", 4);
		TraceIn("comparison", 4);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "comparison");
		DebugLocation(28, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:29:3: (Q1= addition_expression ( '>=' Q2= addition_expression | '>' Q2= addition_expression | '<=' Q2= addition_expression | '<' Q2= addition_expression | '==' Q2= addition_expression | '!=' Q2= addition_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:29:5: Q1= addition_expression ( '>=' Q2= addition_expression | '>' Q2= addition_expression | '<=' Q2= addition_expression | '<' Q2= addition_expression | '==' Q2= addition_expression | '!=' Q2= addition_expression )*
			{
			DebugLocation(29, 7);
			PushFollow(Follow._addition_expression_in_comparison146);
			Q1=addition_expression();
			PopFollow();

			DebugLocation(29, 28);
			 ret=Q1; 
			DebugLocation(30, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:30:5: ( '>=' Q2= addition_expression | '>' Q2= addition_expression | '<=' Q2= addition_expression | '<' Q2= addition_expression | '==' Q2= addition_expression | '!=' Q2= addition_expression )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=7;
				try { DebugEnterDecision(2, false);
				switch (input.LA(1))
				{
				case 21:
					{
					alt2 = 1;
					}
					break;
				case 20:
					{
					alt2 = 2;
					}
					break;
				case 18:
					{
					alt2 = 3;
					}
					break;
				case 17:
					{
					alt2 = 4;
					}
					break;
				case 19:
					{
					alt2 = 5;
					}
					break;
				case 8:
					{
					alt2 = 6;
					}
					break;
				}

				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:30:7: '>=' Q2= addition_expression
					{
					DebugLocation(30, 7);
					Match(input,21,Follow._21_in_comparison156); 
					DebugLocation(30, 14);
					PushFollow(Follow._addition_expression_in_comparison160);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(30, 35);
					 ret=push_operation(ret, Operator.GreaterOrEqual, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:31:4: '>' Q2= addition_expression
					{
					DebugLocation(31, 4);
					Match(input,20,Follow._20_in_comparison167); 
					DebugLocation(31, 11);
					PushFollow(Follow._addition_expression_in_comparison172);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(31, 32);
					 ret=push_operation(ret, Operator.GreaterThan, Q2); 

					}
					break;
				case 3:
					DebugEnterAlt(3);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:32:4: '<=' Q2= addition_expression
					{
					DebugLocation(32, 4);
					Match(input,18,Follow._18_in_comparison179); 
					DebugLocation(32, 11);
					PushFollow(Follow._addition_expression_in_comparison183);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(32, 32);
					 ret=push_operation(ret, Operator.LessOrEqual, Q2); 

					}
					break;
				case 4:
					DebugEnterAlt(4);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:33:4: '<' Q2= addition_expression
					{
					DebugLocation(33, 4);
					Match(input,17,Follow._17_in_comparison190); 
					DebugLocation(33, 11);
					PushFollow(Follow._addition_expression_in_comparison195);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(33, 32);
					 ret=push_operation(ret, Operator.LessThan, Q2); 

					}
					break;
				case 5:
					DebugEnterAlt(5);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:34:4: '==' Q2= addition_expression
					{
					DebugLocation(34, 4);
					Match(input,19,Follow._19_in_comparison202); 
					DebugLocation(34, 11);
					PushFollow(Follow._addition_expression_in_comparison206);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(34, 32);
					 ret=push_operation(ret, Operator.Equals, Q2); 

					}
					break;
				case 6:
					DebugEnterAlt(6);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:35:4: '!=' Q2= addition_expression
					{
					DebugLocation(35, 4);
					Match(input,8,Follow._8_in_comparison213); 
					DebugLocation(35, 11);
					PushFollow(Follow._addition_expression_in_comparison217);
					Q2=addition_expression();
					PopFollow();

					DebugLocation(35, 32);
					 ret=push_operation(ret, Operator.NotEquals, Q2); 

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
			TraceOut("comparison", 4);
			LeaveRule("comparison", 4);
			LeaveRule_comparison();
		}
		DebugLocation(36, 2);
		} finally { DebugExitRule(GrammarFileName, "comparison"); }
		return ret;

	}
	// $ANTLR end "comparison"

	partial void EnterRule_addition_expression();
	partial void LeaveRule_addition_expression();
	// $ANTLR start "addition_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:38:1: addition_expression returns [Queue ret] : Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )* ;
	[GrammarRule("addition_expression")]
	private Queue addition_expression()
	{
		EnterRule_addition_expression();
		EnterRule("addition_expression", 5);
		TraceIn("addition_expression", 5);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "addition_expression");
		DebugLocation(38, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:39:3: (Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:39:5: Q1= multiply_expression ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )*
			{
			DebugLocation(39, 7);
			PushFollow(Follow._multiply_expression_in_addition_expression240);
			Q1=multiply_expression();
			PopFollow();

			DebugLocation(39, 28);
			 ret=Q1; 
			DebugLocation(40, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:40:5: ( '+' Q2= multiply_expression | '-' Q2= multiply_expression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=3;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1==13))
				{
					alt3 = 1;
				}
				else if ((LA3_1==14))
				{
					alt3 = 2;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:40:7: '+' Q2= multiply_expression
					{
					DebugLocation(40, 7);
					Match(input,13,Follow._13_in_addition_expression250); 
					DebugLocation(40, 13);
					PushFollow(Follow._multiply_expression_in_addition_expression254);
					Q2=multiply_expression();
					PopFollow();

					DebugLocation(40, 34);
					 ret=push_operation(ret, Operator.Add, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:41:4: '-' Q2= multiply_expression
					{
					DebugLocation(41, 4);
					Match(input,14,Follow._14_in_addition_expression261); 
					DebugLocation(41, 10);
					PushFollow(Follow._multiply_expression_in_addition_expression265);
					Q2=multiply_expression();
					PopFollow();

					DebugLocation(41, 31);
					 ret=push_operation(ret, Operator.Sub, Q2); 

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
			TraceOut("addition_expression", 5);
			LeaveRule("addition_expression", 5);
			LeaveRule_addition_expression();
		}
		DebugLocation(42, 2);
		} finally { DebugExitRule(GrammarFileName, "addition_expression"); }
		return ret;

	}
	// $ANTLR end "addition_expression"

	partial void EnterRule_multiply_expression();
	partial void LeaveRule_multiply_expression();
	// $ANTLR start "multiply_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:44:1: multiply_expression returns [Queue ret] : Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )* ;
	[GrammarRule("multiply_expression")]
	private Queue multiply_expression()
	{
		EnterRule_multiply_expression();
		EnterRule("multiply_expression", 6);
		TraceIn("multiply_expression", 6);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "multiply_expression");
		DebugLocation(44, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:45:3: (Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:45:5: Q1= power_expression ( '*' Q2= power_expression | '/' Q2= power_expression )*
			{
			DebugLocation(45, 7);
			PushFollow(Follow._power_expression_in_multiply_expression288);
			Q1=power_expression();
			PopFollow();

			DebugLocation(45, 25);
			 ret=Q1; 
			DebugLocation(46, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:46:5: ( '*' Q2= power_expression | '/' Q2= power_expression )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=3;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1==12))
				{
					alt4 = 1;
				}
				else if ((LA4_1==16))
				{
					alt4 = 2;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:46:7: '*' Q2= power_expression
					{
					DebugLocation(46, 7);
					Match(input,12,Follow._12_in_multiply_expression298); 
					DebugLocation(46, 13);
					PushFollow(Follow._power_expression_in_multiply_expression302);
					Q2=power_expression();
					PopFollow();

					DebugLocation(46, 31);
					 ret=push_operation(ret, Operator.Mul, Q2); 

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:47:4: '/' Q2= power_expression
					{
					DebugLocation(47, 4);
					Match(input,16,Follow._16_in_multiply_expression309); 
					DebugLocation(47, 10);
					PushFollow(Follow._power_expression_in_multiply_expression313);
					Q2=power_expression();
					PopFollow();

					DebugLocation(47, 28);
					 ret=push_operation(ret, Operator.Div, Q2); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("multiply_expression", 6);
			LeaveRule("multiply_expression", 6);
			LeaveRule_multiply_expression();
		}
		DebugLocation(48, 2);
		} finally { DebugExitRule(GrammarFileName, "multiply_expression"); }
		return ret;

	}
	// $ANTLR end "multiply_expression"

	partial void EnterRule_power_expression();
	partial void LeaveRule_power_expression();
	// $ANTLR start "power_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:50:1: power_expression returns [Queue ret] : Q1= negation ( '^' Q2= negation )* ;
	[GrammarRule("power_expression")]
	private Queue power_expression()
	{
		EnterRule_power_expression();
		EnterRule("power_expression", 7);
		TraceIn("power_expression", 7);
		Queue ret = default(Queue);


		Queue Q1 = default(Queue);
		Queue Q2 = default(Queue);

		try { DebugEnterRule(GrammarFileName, "power_expression");
		DebugLocation(50, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:51:3: (Q1= negation ( '^' Q2= negation )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:51:5: Q1= negation ( '^' Q2= negation )*
			{
			DebugLocation(51, 7);
			PushFollow(Follow._negation_in_power_expression336);
			Q1=negation();
			PopFollow();

			DebugLocation(51, 17);
			 ret=Q1; 
			DebugLocation(52, 5);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:52:5: ( '^' Q2= negation )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1==22))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:52:7: '^' Q2= negation
					{
					DebugLocation(52, 7);
					Match(input,22,Follow._22_in_power_expression346); 
					DebugLocation(52, 13);
					PushFollow(Follow._negation_in_power_expression350);
					Q2=negation();
					PopFollow();

					DebugLocation(52, 23);
					 ret=push_operation(ret, Operator.Pow, Q2); 

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("power_expression", 7);
			LeaveRule("power_expression", 7);
			LeaveRule_power_expression();
		}
		DebugLocation(53, 2);
		} finally { DebugExitRule(GrammarFileName, "power_expression"); }
		return ret;

	}
	// $ANTLR end "power_expression"

	partial void EnterRule_negation();
	partial void LeaveRule_negation();
	// $ANTLR start "negation"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:55:1: negation returns [Queue ret] : ( '-' Q= atomic_expression | '!' Q= atomic_expression |Q= atomic_expression );
	[GrammarRule("negation")]
	private Queue negation()
	{
		EnterRule_negation();
		EnterRule("negation", 8);
		TraceIn("negation", 8);
		Queue ret = default(Queue);


		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "negation");
		DebugLocation(55, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:56:3: ( '-' Q= atomic_expression | '!' Q= atomic_expression |Q= atomic_expression )
			int alt6=3;
			try { DebugEnterDecision(6, false);
			switch (input.LA(1))
			{
			case 14:
				{
				alt6 = 1;
				}
				break;
			case 7:
				{
				alt6 = 2;
				}
				break;
			case IDENTIFIER:
			case REAL:
			case 10:
			case 23:
			case 24:
				{
				alt6 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 6, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:56:5: '-' Q= atomic_expression
				{
				DebugLocation(56, 5);
				Match(input,14,Follow._14_in_negation372); 
				DebugLocation(56, 10);
				PushFollow(Follow._atomic_expression_in_negation376);
				Q=atomic_expression();
				PopFollow();

				DebugLocation(56, 29);
				 ret=push_operator(Q, Operator.Negate); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:57:5: '!' Q= atomic_expression
				{
				DebugLocation(57, 5);
				Match(input,7,Follow._7_in_negation384); 
				DebugLocation(57, 10);
				PushFollow(Follow._atomic_expression_in_negation388);
				Q=atomic_expression();
				PopFollow();

				DebugLocation(57, 29);
				 ret=push_operator(Q, Operator.Negate); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:58:5: Q= atomic_expression
				{
				DebugLocation(58, 6);
				PushFollow(Follow._atomic_expression_in_negation398);
				Q=atomic_expression();
				PopFollow();

				DebugLocation(58, 25);
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
			TraceOut("negation", 8);
			LeaveRule("negation", 8);
			LeaveRule_negation();
		}
		DebugLocation(59, 2);
		} finally { DebugExitRule(GrammarFileName, "negation"); }
		return ret;

	}
	// $ANTLR end "negation"

	partial void EnterRule_atomic_expression();
	partial void LeaveRule_atomic_expression();
	// $ANTLR start "atomic_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:61:1: atomic_expression returns [Queue ret] : (n= REAL |Q= boolean_terminal |Q= identifier_expression | '(' Q= addition_expression ')' );
	[GrammarRule("atomic_expression")]
	private Queue atomic_expression()
	{
		EnterRule_atomic_expression();
		EnterRule("atomic_expression", 9);
		TraceIn("atomic_expression", 9);
		Queue ret = default(Queue);


		IToken n = default(IToken);
		Queue Q = default(Queue);

		try { DebugEnterRule(GrammarFileName, "atomic_expression");
		DebugLocation(61, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:62:3: (n= REAL |Q= boolean_terminal |Q= identifier_expression | '(' Q= addition_expression ')' )
			int alt7=4;
			try { DebugEnterDecision(7, false);
			switch (input.LA(1))
			{
			case REAL:
				{
				alt7 = 1;
				}
				break;
			case 23:
			case 24:
				{
				alt7 = 2;
				}
				break;
			case IDENTIFIER:
				{
				alt7 = 3;
				}
				break;
			case 10:
				{
				alt7 = 4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:62:5: n= REAL
				{
				DebugLocation(62, 6);
				n=(IToken)Match(input,REAL,Follow._REAL_in_atomic_expression419); 
				DebugLocation(62, 12);
				 ret=push_literal(new_queue(), (n!=null?n.Text:default(string))); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:63:5: Q= boolean_terminal
				{
				DebugLocation(63, 6);
				PushFollow(Follow._boolean_terminal_in_atomic_expression429);
				Q=boolean_terminal();
				PopFollow();

				DebugLocation(63, 24);
				 ret=Q; 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:64:5: Q= identifier_expression
				{
				DebugLocation(64, 6);
				PushFollow(Follow._identifier_expression_in_atomic_expression439);
				Q=identifier_expression();
				PopFollow();

				DebugLocation(64, 29);
				 ret=Q; 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:65:5: '(' Q= addition_expression ')'
				{
				DebugLocation(65, 5);
				Match(input,10,Follow._10_in_atomic_expression447); 
				DebugLocation(65, 10);
				PushFollow(Follow._addition_expression_in_atomic_expression451);
				Q=addition_expression();
				PopFollow();

				DebugLocation(65, 31);
				Match(input,11,Follow._11_in_atomic_expression453); 
				DebugLocation(65, 35);
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
			TraceOut("atomic_expression", 9);
			LeaveRule("atomic_expression", 9);
			LeaveRule_atomic_expression();
		}
		DebugLocation(66, 2);
		} finally { DebugExitRule(GrammarFileName, "atomic_expression"); }
		return ret;

	}
	// $ANTLR end "atomic_expression"

	partial void EnterRule_identifier_expression();
	partial void LeaveRule_identifier_expression();
	// $ANTLR start "identifier_expression"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:68:1: identifier_expression returns [Queue ret] : a= IDENTIFIER ( '.' b= IDENTIFIER )* ;
	[GrammarRule("identifier_expression")]
	private Queue identifier_expression()
	{
		EnterRule_identifier_expression();
		EnterRule("identifier_expression", 10);
		TraceIn("identifier_expression", 10);
		Queue ret = default(Queue);


		IToken a = default(IToken);
		IToken b = default(IToken);

		try { DebugEnterRule(GrammarFileName, "identifier_expression");
		DebugLocation(68, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:69:3: (a= IDENTIFIER ( '.' b= IDENTIFIER )* )
			DebugEnterAlt(1);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:69:5: a= IDENTIFIER ( '.' b= IDENTIFIER )*
			{
			DebugLocation(69, 6);
			a=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_identifier_expression474); 
			DebugLocation(69, 18);
			 ret=push_identifier(new_queue(), (a!=null?a.Text:default(string))); 
			DebugLocation(69, 65);
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:69:65: ( '.' b= IDENTIFIER )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, false);
				int LA8_1 = input.LA(1);

				if ((LA8_1==15))
				{
					alt8 = 1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:69:66: '.' b= IDENTIFIER
					{
					DebugLocation(69, 66);
					Match(input,15,Follow._15_in_identifier_expression479); 
					DebugLocation(69, 71);
					b=(IToken)Match(input,IDENTIFIER,Follow._IDENTIFIER_in_identifier_expression483); 
					DebugLocation(69, 83);
					 ret=push_operator(push_identifier(ret, (b!=null?b.Text:default(string))), Operator.MemberAccess); 

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("identifier_expression", 10);
			LeaveRule("identifier_expression", 10);
			LeaveRule_identifier_expression();
		}
		DebugLocation(70, 2);
		} finally { DebugExitRule(GrammarFileName, "identifier_expression"); }
		return ret;

	}
	// $ANTLR end "identifier_expression"

	partial void EnterRule_boolean_terminal();
	partial void LeaveRule_boolean_terminal();
	// $ANTLR start "boolean_terminal"
	// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:72:1: boolean_terminal returns [Queue ret] : ( 'true' | 'false' );
	[GrammarRule("boolean_terminal")]
	private Queue boolean_terminal()
	{
		EnterRule_boolean_terminal();
		EnterRule("boolean_terminal", 11);
		TraceIn("boolean_terminal", 11);
		Queue ret = default(Queue);


		try { DebugEnterRule(GrammarFileName, "boolean_terminal");
		DebugLocation(72, 2);
		try
		{
			// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:73:3: ( 'true' | 'false' )
			int alt9=2;
			try { DebugEnterDecision(9, false);
			int LA9_1 = input.LA(1);

			if ((LA9_1==24))
			{
				alt9 = 1;
			}
			else if ((LA9_1==23))
			{
				alt9 = 2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 9, 0, input, 1);
				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(9); }
			switch (alt9)
			{
			case 1:
				DebugEnterAlt(1);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:73:5: 'true'
				{
				DebugLocation(73, 5);
				Match(input,24,Follow._24_in_boolean_terminal504); 
				DebugLocation(73, 12);
				 ret=push_boolean(new_queue(), true); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// C:\\workspace\\SharpExpressions\\Lib\\\\SharpExpressions.g:74:5: 'false'
				{
				DebugLocation(74, 5);
				Match(input,23,Follow._23_in_boolean_terminal512); 
				DebugLocation(74, 13);
				 ret=push_boolean(new_queue(), false); 

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
			TraceOut("boolean_terminal", 11);
			LeaveRule("boolean_terminal", 11);
			LeaveRule_boolean_terminal();
		}
		DebugLocation(75, 2);
		} finally { DebugExitRule(GrammarFileName, "boolean_terminal"); }
		return ret;

	}
	// $ANTLR end "boolean_terminal"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _expression_in_eval56 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolean_expression_in_expression77 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _comparison_in_boolean_expression98 = new BitSet(new ulong[]{0x2000202UL});
		public static readonly BitSet _9_in_boolean_expression108 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _comparison_in_boolean_expression112 = new BitSet(new ulong[]{0x2000202UL});
		public static readonly BitSet _25_in_boolean_expression119 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _comparison_in_boolean_expression123 = new BitSet(new ulong[]{0x2000202UL});
		public static readonly BitSet _addition_expression_in_comparison146 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _21_in_comparison156 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison160 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _20_in_comparison167 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison172 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _18_in_comparison179 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison183 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _17_in_comparison190 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison195 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _19_in_comparison202 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison206 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _8_in_comparison213 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_comparison217 = new BitSet(new ulong[]{0x3E0102UL});
		public static readonly BitSet _multiply_expression_in_addition_expression240 = new BitSet(new ulong[]{0x6002UL});
		public static readonly BitSet _13_in_addition_expression250 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _multiply_expression_in_addition_expression254 = new BitSet(new ulong[]{0x6002UL});
		public static readonly BitSet _14_in_addition_expression261 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _multiply_expression_in_addition_expression265 = new BitSet(new ulong[]{0x6002UL});
		public static readonly BitSet _power_expression_in_multiply_expression288 = new BitSet(new ulong[]{0x11002UL});
		public static readonly BitSet _12_in_multiply_expression298 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _power_expression_in_multiply_expression302 = new BitSet(new ulong[]{0x11002UL});
		public static readonly BitSet _16_in_multiply_expression309 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _power_expression_in_multiply_expression313 = new BitSet(new ulong[]{0x11002UL});
		public static readonly BitSet _negation_in_power_expression336 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _22_in_power_expression346 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _negation_in_power_expression350 = new BitSet(new ulong[]{0x400002UL});
		public static readonly BitSet _14_in_negation372 = new BitSet(new ulong[]{0x1800430UL});
		public static readonly BitSet _atomic_expression_in_negation376 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _7_in_negation384 = new BitSet(new ulong[]{0x1800430UL});
		public static readonly BitSet _atomic_expression_in_negation388 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _atomic_expression_in_negation398 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _REAL_in_atomic_expression419 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _boolean_terminal_in_atomic_expression429 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_expression_in_atomic_expression439 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _10_in_atomic_expression447 = new BitSet(new ulong[]{0x18044B0UL});
		public static readonly BitSet _addition_expression_in_atomic_expression451 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _11_in_atomic_expression453 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENTIFIER_in_identifier_expression474 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _15_in_identifier_expression479 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _IDENTIFIER_in_identifier_expression483 = new BitSet(new ulong[]{0x8002UL});
		public static readonly BitSet _24_in_boolean_terminal504 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _23_in_boolean_terminal512 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}

} // namespace SharpExpressions.parser
