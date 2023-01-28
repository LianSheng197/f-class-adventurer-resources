using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class WWWRequest : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWWW_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WebFormat data;

		public WWWRequest _003C_003E4__this;

		public callBack callBack;

		private long _003CrequestStartTime_003E5__2;

		private WWWAddMonitHistory _003CwwwMonit_003E5__3;

		private long _003CmonitDelayMS_003E5__4;

		private string _003CrequestParamJson_003E5__5;

		private UnityWebRequest _003Cwww_003E5__6;

		private long _003CrequestEndTime_003E5__7;

		private long _003CrequestTime_003E5__8;

		private bool _003CIsValid_003E5__9;

		private string _003CresponseMessage_003E5__10;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWWW_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWWWCheck_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public callBack callBack;

		public WWWRequest _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWWWCheck_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	private WebFormat _data;

	private callBack _callBack;

	private const bool _isEditorLog = false;

	public static void Request(WebFormat data, callBack callBack)
	{
	}

	private void Request()
	{
	}

	private UnityWebRequest UnityWebRequestBuilder(WebFormat data, ref string requestParamJson)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWWW_003Ed__6))]
	private IEnumerator WWW(WebFormat data, callBack callBack)
	{
		return null;
	}

	public static void Check(string url, callBack callBack)
	{
	}

	private void CheckRequest()
	{
	}

	[IteratorStateMachine(typeof(_003CWWWCheck_003Ed__9))]
	private IEnumerator WWWCheck(string url, callBack callBack)
	{
		return null;
	}
}
