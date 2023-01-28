using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimatorSequence : MonoBehaviour
{
	public delegate void AnimatorSequenceDelegate(GameObject obj);

	[CompilerGenerated]
	private sealed class _003CPlayAll_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimatorSequence _003C_003E4__this;

		private List<string>.Enumerator _003C_003E7__wrap1;

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
		public _003CPlayAll_003Ed__8(int _003C_003E1__state)
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
	private sealed class _003CWaitAnimation_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AnimatorSequence _003C_003E4__this;

		public string aniName;

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
		public _003CWaitAnimation_003Ed__9(int _003C_003E1__state)
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

	private AnimatorSequenceDelegate _animatorSequenceCallback;

	private Animator _animator;

	public List<string> _animationList;

	public float _delayTime;

	public static AnimatorSequence Add(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayAll_003Ed__8))]
	private IEnumerator PlayAll()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitAnimation_003Ed__9))]
	private IEnumerator WaitAnimation(string aniName)
	{
		return null;
	}

	public void PlaySequence(string aniName)
	{
	}

	public void PlaySequence(List<string> aniNameList)
	{
	}

	public void PlaySequence(string aniName, AnimatorSequenceDelegate callback)
	{
	}

	public void PlaySequence(List<string> aniNameList, AnimatorSequenceDelegate callback)
	{
	}

	public void PlaySequence(string aniName, float delayTime)
	{
	}

	public void PlaySequence(string aniName, float delayTime, AnimatorSequenceDelegate callback)
	{
	}

	public void PlaySequence(List<string> aniNameList, float delayTime)
	{
	}

	public void PlaySequence(List<string> aniNameList, float delayTime, AnimatorSequenceDelegate callback)
	{
	}

	private void Play()
	{
	}

	protected void DestroySelf()
	{
	}
}
