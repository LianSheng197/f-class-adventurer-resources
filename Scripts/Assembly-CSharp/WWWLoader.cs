using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WWWLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoad_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WWWLoader _003C_003E4__this;

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
		public _003CLoad_003Ed__10(int _003C_003E1__state)
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

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	protected List<WWWData> _LoadDataList;

	protected List<WWWData> _asyncLoadDataList;

	private int _reqCount;

	private int _ackCount;

	private int _asyncReqCount;

	private int _asyncAckCount;

	private bool _bFailed;

	public virtual void Init()
	{
	}

	protected virtual void CheckNetState()
	{
	}

	protected void EndCheckNet(bool isResult)
	{
	}

	[IteratorStateMachine(typeof(_003CLoad_003Ed__10))]
	private IEnumerator Load()
	{
		return null;
	}

	private bool Req()
	{
		return false;
	}

	private bool AsyncReq()
	{
		return false;
	}

	protected virtual void ReleaseReq()
	{
	}

	public void Ack(WWWData www)
	{
	}

	public virtual void OnFailed()
	{
	}

	public virtual void AddData()
	{
	}

	public virtual void AddAsyncData()
	{
	}

	public virtual void CompletedLoad()
	{
	}
}
