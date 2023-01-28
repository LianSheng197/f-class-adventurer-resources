using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoadingScene : SceneBase
{
	[CompilerGenerated]
	private sealed class _003CinitGameDataLoad_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScene _003C_003E4__this;

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
		public _003CinitGameDataLoad_003Ed__2(int _003C_003E1__state)
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

	public static GameObject _Loader;

	public static string _currentSceneName;

	[IteratorStateMachine(typeof(_003CinitGameDataLoad_003Ed__2))]
	private IEnumerator initGameDataLoad()
	{
		return null;
	}

	public override void InitScene()
	{
	}

	public override void EnterScene()
	{
	}

	private void ClearResource()
	{
	}

	public static void SuccessResourceClear()
	{
	}

	private static void GotoNextScene()
	{
	}

	public override bool AndroidBackButton()
	{
		return false;
	}

	public override void InitSceneStart()
	{
	}

	public override void InitSceneEnd()
	{
	}

	public override void EnterSceneStart()
	{
	}

	public override void EnterSceneEnd()
	{
	}

	public GameObject GetLoaderObject()
	{
		return null;
	}
}
