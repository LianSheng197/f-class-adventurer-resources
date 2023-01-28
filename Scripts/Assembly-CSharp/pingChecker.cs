using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class pingChecker : MonoBehaviour
{
	public class pingData
	{
		public DateTime _reqTime;
	}

	public enum eLevel
	{
		bad = 0,
		good = 1
	}

	[CompilerGenerated]
	private sealed class _003CRequest_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public pingData obj;

		public string addr;

		public pingChecker _003C_003E4__this;

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
		public _003CRequest_003Ed__16(int _003C_003E1__state)
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

	private bool _isActive;

	private Queue<bool> _resultQueue;

	private string _addr;

	private int _badCount;

	private int _queueCount;

	private int _activeSeconds;

	private int _gElapseSeconds;

	private int _bElapseSeconds;

	private DateTime _lastTime;

	public void init(bool isActive, string addr, int activeSeconds, int gElapseSeconds, int bElapseSeconds, int queueCount, int badCount)
	{
	}

	public void SetAddress(string IP, int port)
	{
	}

	public eLevel GetLevel()
	{
		return default(eLevel);
	}

	private int GetElapseSeconds()
	{
		return 0;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRequest_003Ed__16))]
	private IEnumerator Request(string addr, pingData obj)
	{
		return null;
	}

	private void ResultPing(bool isResult)
	{
	}
}
