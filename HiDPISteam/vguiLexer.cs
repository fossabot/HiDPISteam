//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4 C:\\Users\\Robert Hencke\\Documents\\vgui.g 2012-11-26 21:28:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;
using ConditionalAttribute = System.Diagnostics.ConditionalAttribute;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4")]
[System.CLSCompliant(false)]
public partial class vguiLexer : Antlr.Runtime.Lexer
{
	public const int EOF=-1;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int ASSIGNMENT=4;
	public const int COMMENT=5;
	public const int GROUP=6;
	public const int HIDDEN=7;
	public const int STRING=8;
	public const int TAG=9;
	public const int WS=10;

    // delegates
    // delegators

	public vguiLexer()
	{
		OnCreated();
	}

	public vguiLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public vguiLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{

		OnCreated();
	}
	public override string GrammarFileName { get { return "C:\\Users\\Robert Hencke\\Documents\\vgui.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];

	[Conditional("ANTLR_TRACE")]
	protected virtual void OnCreated() {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void EnterRule(string ruleName, int ruleIndex) {}
	[Conditional("ANTLR_TRACE")]
	protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_T__11() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_T__11() {}

    // $ANTLR start "T__11"
    [GrammarRule("T__11")]
    private void mT__11()
    {
    	EnterRule_T__11();
    	EnterRule("T__11", 1);
    	TraceIn("T__11", 1);
    		try
    		{
    		int _type = T__11;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:7:7: ( '=' )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:7:9: '='
    		{
    		DebugLocation(7, 9);
    		Match('='); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("T__11", 1);
    		LeaveRule("T__11", 1);
    		LeaveRule_T__11();
        }
    }
    // $ANTLR end "T__11"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_T__12() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_T__12() {}

    // $ANTLR start "T__12"
    [GrammarRule("T__12")]
    private void mT__12()
    {
    	EnterRule_T__12();
    	EnterRule("T__12", 2);
    	TraceIn("T__12", 2);
    		try
    		{
    		int _type = T__12;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:8:7: ( '{' )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:8:9: '{'
    		{
    		DebugLocation(8, 9);
    		Match('{'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("T__12", 2);
    		LeaveRule("T__12", 2);
    		LeaveRule_T__12();
        }
    }
    // $ANTLR end "T__12"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_T__13() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_T__13() {}

    // $ANTLR start "T__13"
    [GrammarRule("T__13")]
    private void mT__13()
    {
    	EnterRule_T__13();
    	EnterRule("T__13", 3);
    	TraceIn("T__13", 3);
    		try
    		{
    		int _type = T__13;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:9:7: ( '}' )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:9:9: '}'
    		{
    		DebugLocation(9, 9);
    		Match('}'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("T__13", 3);
    		LeaveRule("T__13", 3);
    		LeaveRule_T__13();
        }
    }
    // $ANTLR end "T__13"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_TAG() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_TAG() {}

    // $ANTLR start "TAG"
    [GrammarRule("TAG")]
    private void mTAG()
    {
    	EnterRule_TAG();
    	EnterRule("TAG", 4);
    	TraceIn("TAG", 4);
    		try
    		{
    		int _type = TAG;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:34:5: ( '[' (~ ']' )* ']' )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:34:7: '[' (~ ']' )* ']'
    		{
    		DebugLocation(34, 7);
    		Match('['); 
    		DebugLocation(34, 11);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:34:11: (~ ']' )*
    		try { DebugEnterSubRule(1);
    		while (true)
    		{
    			int alt1=2;
    			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
    			int LA1_0 = input.LA(1);

    			if (((LA1_0>='\u0000' && LA1_0<='\\')||(LA1_0>='^' && LA1_0<='\uFFFF')))
    			{
    				alt1 = 1;
    			}


    			} finally { DebugExitDecision(1); }
    			switch ( alt1 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Users\\Robert Hencke\\Documents\\vgui.g:
    				{
    				DebugLocation(34, 11);
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

    		DebugLocation(34, 17);
    		Match(']'); 

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("TAG", 4);
    		LeaveRule("TAG", 4);
    		LeaveRule_TAG();
        }
    }
    // $ANTLR end "TAG"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_COMMENT() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_COMMENT() {}

    // $ANTLR start "COMMENT"
    [GrammarRule("COMMENT")]
    private void mCOMMENT()
    {
    	EnterRule_COMMENT();
    	EnterRule("COMMENT", 5);
    	TraceIn("COMMENT", 5);
    		try
    		{
    		int _type = COMMENT;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:36:9: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:36:11: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
    		{
    		DebugLocation(36, 11);
    		Match("//"); 

    		DebugLocation(36, 16);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:36:16: (~ ( '\\n' | '\\r' ) )*
    		try { DebugEnterSubRule(2);
    		while (true)
    		{
    			int alt2=2;
    			try { DebugEnterDecision(2, decisionCanBacktrack[2]);
    			int LA2_0 = input.LA(1);

    			if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
    			{
    				alt2 = 1;
    			}


    			} finally { DebugExitDecision(2); }
    			switch ( alt2 )
    			{
    			case 1:
    				DebugEnterAlt(1);
    				// C:\\Users\\Robert Hencke\\Documents\\vgui.g:
    				{
    				DebugLocation(36, 16);
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

    		DebugLocation(36, 30);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:36:30: ( '\\r' )?
    		int alt3=2;
    		try { DebugEnterSubRule(3);
    		try { DebugEnterDecision(3, decisionCanBacktrack[3]);
    		int LA3_0 = input.LA(1);

    		if ((LA3_0=='\r'))
    		{
    			alt3 = 1;
    		}
    		} finally { DebugExitDecision(3); }
    		switch (alt3)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Users\\Robert Hencke\\Documents\\vgui.g:36:30: '\\r'
    			{
    			DebugLocation(36, 30);
    			Match('\r'); 

    			}
    			break;

    		}
    		} finally { DebugExitSubRule(3); }

    		DebugLocation(36, 36);
    		Match('\n'); 
    		DebugLocation(36, 41);
    		_channel=HIDDEN;

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("COMMENT", 5);
    		LeaveRule("COMMENT", 5);
    		LeaveRule_COMMENT();
        }
    }
    // $ANTLR end "COMMENT"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_STRING() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_STRING() {}

    // $ANTLR start "STRING"
    [GrammarRule("STRING")]
    private void mSTRING()
    {
    	EnterRule_STRING();
    	EnterRule("STRING", 6);
    	TraceIn("STRING", 6);
    		try
    		{
    		int _type = STRING;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:39:8: ( '\"' (~ '\"' )* '\"' | (~ ( '{' | '}' | '[' | ']' | '\"' | '=' | ' ' | '\\t' | '\\r' | '\\n' ) )+ )
    		int alt6=2;
    		try { DebugEnterDecision(6, decisionCanBacktrack[6]);
    		int LA6_0 = input.LA(1);

    		if ((LA6_0=='\"'))
    		{
    			alt6 = 1;
    		}
    		else if (((LA6_0>='\u0000' && LA6_0<='\b')||(LA6_0>='\u000B' && LA6_0<='\f')||(LA6_0>='\u000E' && LA6_0<='\u001F')||LA6_0=='!'||(LA6_0>='#' && LA6_0<='<')||(LA6_0>='>' && LA6_0<='Z')||LA6_0=='\\'||(LA6_0>='^' && LA6_0<='z')||LA6_0=='|'||(LA6_0>='~' && LA6_0<='\uFFFF')))
    		{
    			alt6 = 2;
    		}
    		else
    		{
    			NoViableAltException nvae = new NoViableAltException("", 6, 0, input);
    			DebugRecognitionException(nvae);
    			throw nvae;
    		}
    		} finally { DebugExitDecision(6); }
    		switch (alt6)
    		{
    		case 1:
    			DebugEnterAlt(1);
    			// C:\\Users\\Robert Hencke\\Documents\\vgui.g:39:10: '\"' (~ '\"' )* '\"'
    			{
    			DebugLocation(39, 10);
    			Match('\"'); 
    			DebugLocation(39, 14);
    			// C:\\Users\\Robert Hencke\\Documents\\vgui.g:39:14: (~ '\"' )*
    			try { DebugEnterSubRule(4);
    			while (true)
    			{
    				int alt4=2;
    				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
    				int LA4_0 = input.LA(1);

    				if (((LA4_0>='\u0000' && LA4_0<='!')||(LA4_0>='#' && LA4_0<='\uFFFF')))
    				{
    					alt4 = 1;
    				}


    				} finally { DebugExitDecision(4); }
    				switch ( alt4 )
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Users\\Robert Hencke\\Documents\\vgui.g:
    					{
    					DebugLocation(39, 14);
    					input.Consume();


    					}
    					break;

    				default:
    					goto loop4;
    				}
    			}

    			loop4:
    				;

    			} finally { DebugExitSubRule(4); }

    			DebugLocation(39, 20);
    			Match('\"'); 

    			}
    			break;
    		case 2:
    			DebugEnterAlt(2);
    			// C:\\Users\\Robert Hencke\\Documents\\vgui.g:40:4: (~ ( '{' | '}' | '[' | ']' | '\"' | '=' | ' ' | '\\t' | '\\r' | '\\n' ) )+
    			{
    			DebugLocation(40, 4);
    			// C:\\Users\\Robert Hencke\\Documents\\vgui.g:40:4: (~ ( '{' | '}' | '[' | ']' | '\"' | '=' | ' ' | '\\t' | '\\r' | '\\n' ) )+
    			int cnt5=0;
    			try { DebugEnterSubRule(5);
    			while (true)
    			{
    				int alt5=2;
    				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
    				int LA5_0 = input.LA(1);

    				if (((LA5_0>='\u0000' && LA5_0<='\b')||(LA5_0>='\u000B' && LA5_0<='\f')||(LA5_0>='\u000E' && LA5_0<='\u001F')||LA5_0=='!'||(LA5_0>='#' && LA5_0<='<')||(LA5_0>='>' && LA5_0<='Z')||LA5_0=='\\'||(LA5_0>='^' && LA5_0<='z')||LA5_0=='|'||(LA5_0>='~' && LA5_0<='\uFFFF')))
    				{
    					alt5 = 1;
    				}


    				} finally { DebugExitDecision(5); }
    				switch (alt5)
    				{
    				case 1:
    					DebugEnterAlt(1);
    					// C:\\Users\\Robert Hencke\\Documents\\vgui.g:
    					{
    					DebugLocation(40, 4);
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
    		TraceOut("STRING", 6);
    		LeaveRule("STRING", 6);
    		LeaveRule_STRING();
        }
    }
    // $ANTLR end "STRING"

    [Conditional("ANTLR_TRACE")]
    protected virtual void EnterRule_WS() {}
    [Conditional("ANTLR_TRACE")]
    protected virtual void LeaveRule_WS() {}

    // $ANTLR start "WS"
    [GrammarRule("WS")]
    private void mWS()
    {
    	EnterRule_WS();
    	EnterRule("WS", 7);
    	TraceIn("WS", 7);
    		try
    		{
    		int _type = WS;
    		int _channel = DefaultTokenChannel;
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:43:6: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:43:8: ( ' ' | '\\t' | '\\r' | '\\n' )
    		{
    		DebugLocation(43, 8);
    		if ((input.LA(1)>='\t' && input.LA(1)<='\n')||input.LA(1)=='\r'||input.LA(1)==' ')
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

    		DebugLocation(43, 29);
    		_channel=HIDDEN;

    		}

    		state.type = _type;
    		state.channel = _channel;
    	}
    	finally
    	{
    		TraceOut("WS", 7);
    		LeaveRule("WS", 7);
    		LeaveRule_WS();
        }
    }
    // $ANTLR end "WS"

    public override void mTokens()
    {
    	// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:8: ( T__11 | T__12 | T__13 | TAG | COMMENT | STRING | WS )
    	int alt7=7;
    	try { DebugEnterDecision(7, decisionCanBacktrack[7]);
    	try
    	{
    		alt7 = dfa7.Predict(input);
    	}
    	catch (NoViableAltException nvae)
    	{
    		DebugRecognitionException(nvae);
    		throw;
    	}
    	} finally { DebugExitDecision(7); }
    	switch (alt7)
    	{
    	case 1:
    		DebugEnterAlt(1);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:10: T__11
    		{
    		DebugLocation(1, 10);
    		mT__11(); 

    		}
    		break;
    	case 2:
    		DebugEnterAlt(2);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:16: T__12
    		{
    		DebugLocation(1, 16);
    		mT__12(); 

    		}
    		break;
    	case 3:
    		DebugEnterAlt(3);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:22: T__13
    		{
    		DebugLocation(1, 22);
    		mT__13(); 

    		}
    		break;
    	case 4:
    		DebugEnterAlt(4);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:28: TAG
    		{
    		DebugLocation(1, 28);
    		mTAG(); 

    		}
    		break;
    	case 5:
    		DebugEnterAlt(5);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:32: COMMENT
    		{
    		DebugLocation(1, 32);
    		mCOMMENT(); 

    		}
    		break;
    	case 6:
    		DebugEnterAlt(6);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:40: STRING
    		{
    		DebugLocation(1, 40);
    		mSTRING(); 

    		}
    		break;
    	case 7:
    		DebugEnterAlt(7);
    		// C:\\Users\\Robert Hencke\\Documents\\vgui.g:1:47: WS
    		{
    		DebugLocation(1, 47);
    		mWS(); 

    		}
    		break;

    	}

    }


	#region DFA
	DFA7 dfa7;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa7 = new DFA7(this, SpecialStateTransition7);
	}

	private class DFA7 : DFA
	{
		private const string DFA7_eotS =
			"\x5\xFFFF\x1\x6\x2\xFFFF\x2\x6\x1\xFFFF";
		private const string DFA7_eofS =
			"\xB\xFFFF";
		private const string DFA7_minS =
			"\x1\x0\x4\xFFFF\x1\x2F\x2\xFFFF\x2\x0\x1\xFFFF";
		private const string DFA7_maxS =
			"\x1\xFFFF\x4\xFFFF\x1\x2F\x2\xFFFF\x2\xFFFF\x1\xFFFF";
		private const string DFA7_acceptS =
			"\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\xFFFF\x1\x6\x1\x7\x2\xFFFF\x1\x5";
		private const string DFA7_specialS =
			"\x1\x2\x7\xFFFF\x1\x1\x1\x0\x1\xFFFF}>";
		private static readonly string[] DFA7_transitionS =
			{
				"\x9\x6\x2\x7\x2\x6\x1\x7\x12\x6\x1\x7\xE\x6\x1\x5\xD\x6\x1\x1\x1D\x6"+
				"\x1\x4\x1\x6\x1\xFFFF\x1D\x6\x1\x2\x1\x6\x1\x3\xFF82\x6",
				"",
				"",
				"",
				"",
				"\x1\x8",
				"",
				"",
				"\x9\x9\x2\xA\x2\x9\x1\xA\x12\x9\x1\xA\x1\x9\x1\xA\x1A\x9\x1\xA\x1D"+
				"\x9\x1\xA\x1\x9\x1\xA\x1D\x9\x1\xA\x1\x9\x1\xA\xFF82\x9",
				"\x9\x9\x2\xA\x2\x9\x1\xA\x12\x9\x1\xA\x1\x9\x1\xA\x1A\x9\x1\xA\x1D"+
				"\x9\x1\xA\x1\x9\x1\xA\x1D\x9\x1\xA\x1\x9\x1\xA\xFF82\x9",
				""
			};

		private static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
		private static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
		private static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
		private static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
		private static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
		private static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
		private static readonly short[][] DFA7_transition;

		static DFA7()
		{
			int numStates = DFA7_transitionS.Length;
			DFA7_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA7_transition[i] = DFA.UnpackEncodedString(DFA7_transitionS[i]);
			}
		}

		public DFA7( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 7;
			this.eot = DFA7_eot;
			this.eof = DFA7_eof;
			this.min = DFA7_min;
			this.max = DFA7_max;
			this.accept = DFA7_accept;
			this.special = DFA7_special;
			this.transition = DFA7_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( T__11 | T__12 | T__13 | TAG | COMMENT | STRING | WS );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition7(DFA dfa, int s, IIntStream _input)
	{
		IIntStream input = _input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA7_9 = input.LA(1);

				s = -1;
				if (((LA7_9>='\t' && LA7_9<='\n')||LA7_9=='\r'||LA7_9==' '||LA7_9=='\"'||LA7_9=='='||LA7_9=='['||LA7_9==']'||LA7_9=='{'||LA7_9=='}')) {s = 10;}

				else if (((LA7_9>='\u0000' && LA7_9<='\b')||(LA7_9>='\u000B' && LA7_9<='\f')||(LA7_9>='\u000E' && LA7_9<='\u001F')||LA7_9=='!'||(LA7_9>='#' && LA7_9<='<')||(LA7_9>='>' && LA7_9<='Z')||LA7_9=='\\'||(LA7_9>='^' && LA7_9<='z')||LA7_9=='|'||(LA7_9>='~' && LA7_9<='\uFFFF'))) {s = 9;}

				else s = 6;

				if (s >= 0) return s;
				break;

			case 1:
				int LA7_8 = input.LA(1);

				s = -1;
				if (((LA7_8>='\u0000' && LA7_8<='\b')||(LA7_8>='\u000B' && LA7_8<='\f')||(LA7_8>='\u000E' && LA7_8<='\u001F')||LA7_8=='!'||(LA7_8>='#' && LA7_8<='<')||(LA7_8>='>' && LA7_8<='Z')||LA7_8=='\\'||(LA7_8>='^' && LA7_8<='z')||LA7_8=='|'||(LA7_8>='~' && LA7_8<='\uFFFF'))) {s = 9;}

				else if (((LA7_8>='\t' && LA7_8<='\n')||LA7_8=='\r'||LA7_8==' '||LA7_8=='\"'||LA7_8=='='||LA7_8=='['||LA7_8==']'||LA7_8=='{'||LA7_8=='}')) {s = 10;}

				else s = 6;

				if (s >= 0) return s;
				break;

			case 2:
				int LA7_0 = input.LA(1);

				s = -1;
				if ((LA7_0=='=')) {s = 1;}

				else if ((LA7_0=='{')) {s = 2;}

				else if ((LA7_0=='}')) {s = 3;}

				else if ((LA7_0=='[')) {s = 4;}

				else if ((LA7_0=='/')) {s = 5;}

				else if (((LA7_0>='\u0000' && LA7_0<='\b')||(LA7_0>='\u000B' && LA7_0<='\f')||(LA7_0>='\u000E' && LA7_0<='\u001F')||(LA7_0>='!' && LA7_0<='.')||(LA7_0>='0' && LA7_0<='<')||(LA7_0>='>' && LA7_0<='Z')||LA7_0=='\\'||(LA7_0>='^' && LA7_0<='z')||LA7_0=='|'||(LA7_0>='~' && LA7_0<='\uFFFF'))) {s = 6;}

				else if (((LA7_0>='\t' && LA7_0<='\n')||LA7_0=='\r'||LA7_0==' ')) {s = 7;}

				if (s >= 0) return s;
				break;
		}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 7, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}
 
	#endregion

}
