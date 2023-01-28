using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class CheckNetObj : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRequest_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float elapseSeconds;

		public string addr;

		public CheckNetObj _003C_003E4__this;

		private string _003Cresponse_003E5__2;

		private UnityWebRequest _003Cwww_003E5__3;

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
		public _003CRequest_003Ed__7(int _003C_003E1__state)
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

	public CheckNet.CallBack _pingCallBack;

	public CheckNet.AvailableCallBack _availableCallBack;

	private short _maxCount;

	private short _count;

	private string _addr;

	public void initPing(string addr, short count, CheckNet.CallBack pingCallBack, CheckNet.AvailableCallBack availableCallBack)
	{
	}

	public void StartPing()
	{
	}

	[IteratorStateMachine(typeof(_003CRequest_003Ed__7))]
	private IEnumerator Request(string addr, float elapseSeconds)
	{
		return null;
	}

	public bool IsRetry()
	{
		return false;
	}

	public void OnRetry()
	{
	}

	private void ResultPing(bool isResult)
	{
	}
}
