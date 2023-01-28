using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Popup/MsgBoxBase")]
public class MsgBoxBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpen_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MsgBoxBase _003C_003E4__this;

		public MsgBox.PopupAnimation openAnimation;

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
		public _003COpen_003Ed__1(int _003C_003E1__state)
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

	public void OpenAnimation(MsgBox.PopupAnimation openAnimation)
	{
	}

	[IteratorStateMachine(typeof(_003COpen_003Ed__1))]
	private IEnumerator Open(MsgBox.PopupAnimation openAnimation)
	{
		return null;
	}
}
