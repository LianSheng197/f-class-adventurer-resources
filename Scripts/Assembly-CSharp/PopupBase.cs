using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Popup/PopupBase")]
public class PopupBase : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COpen_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupBase _003C_003E4__this;

		public string openAnimation;

		public bool isSound;

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
		public _003COpen_003Ed__8(int _003C_003E1__state)
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

	private Vector3 _orgPos;

	public virtual void Message(UIButton btn)
	{
	}

	public void SendPopupOpenCall()
	{
	}

	public virtual void PopupOpenCall()
	{
	}

	public void SendPopupCloseCall()
	{
	}

	public virtual void PopupCloseCall()
	{
	}

	public void OpenAnimation(PopupManager.PopupAnimation openAnimation)
	{
	}

	public void OpenAnimation(AnimationClip clip)
	{
	}

	[IteratorStateMachine(typeof(_003COpen_003Ed__8))]
	private IEnumerator Open(string openAnimation, bool isSound)
	{
		return null;
	}

	public void OpenAnimationAnd(GameObject popup)
	{
	}

	public virtual void UpdateNew()
	{
	}

	public virtual void UpdateCurrency()
	{
	}

	public virtual void UpdateItem()
	{
	}

	public virtual void UpdateItemAll()
	{
	}

	public virtual void UpdateCharacter()
	{
	}

	public virtual void UpdateEventBuff()
	{
	}
}
