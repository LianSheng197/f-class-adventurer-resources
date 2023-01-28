using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ScenarioManager : MonoBehaviour
{
	public delegate void ScenarioEnd();

	[CompilerGenerated]
	private sealed class _003CFadeOut_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScenarioManager _003C_003E4__this;

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
		public _003CFadeOut_003Ed__16(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CFadeIn_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScenarioManager _003C_003E4__this;

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
		public _003CFadeIn_003Ed__17(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CEndFinishFadeOut_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ScenarioManager _003C_003E4__this;

		public float time;

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
		public _003CEndFinishFadeOut_003Ed__22(int _003C_003E1__state)
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

	private static ScenarioManager _instance;

	private ScenarioEnd _scenarioEnd;

	private Texture2D _texture;

	private Color _drawColor;

	private bool _isFade;

	private float _fadeTime;

	private float _fadeMaxTime;

	private bool _isEnd;

	private GameObject _curScenarioObj;

	private Animation _curScenarioAnimation;

	private int _animationIndex;

	private List<string> _animationNames;

	public static ScenarioManager Instance => null;

	private void OnGUI()
	{
	}

	[IteratorStateMachine(typeof(_003CFadeOut_003Ed__16))]
	private IEnumerator FadeOut()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CFadeIn_003Ed__17))]
	private IEnumerator FadeIn()
	{
		return null;
	}

	public void Init()
	{
	}

	public void StartScenario(GameObject prefab, bool changeWeapon, ScenarioEnd scenarioEnd = null)
	{
	}

	private void NextScenario()
	{
	}

	private void EndAnimation(GameObject obj)
	{
	}

	[IteratorStateMachine(typeof(_003CEndFinishFadeOut_003Ed__22))]
	private IEnumerator EndFinishFadeOut(float time)
	{
		return null;
	}

	private void Message(UIButton btn)
	{
	}
}
