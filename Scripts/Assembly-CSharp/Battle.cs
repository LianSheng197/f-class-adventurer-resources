using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Battle : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoroutineClearResource_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CCoroutineClearResource_003Ed__18(int _003C_003E1__state)
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

	private const float CLEAR_RESOURCE_REPEAT_TIME = 0f;

	private const float GC_REPEAT_TIME = 30f;

	private GameObject _battleRoot;

	private BattleData _battleData;

	private int _curClearWorldScenarioWorldId;

	public bool _isClearWorldScenarioAble;

	public void InitBattle()
	{
	}

	public void StartPlay()
	{
	}

	private void EndWorldScenario()
	{
	}

	private void EndStageScenario()
	{
	}

	private void EndClearWorldScenario()
	{
	}

	private void EndScenario()
	{
	}

	private void Play(GameObject obj)
	{
	}

	public BattleData GetBattleData()
	{
		return null;
	}

	public void SetMainSceneMode()
	{
	}

	public void RefreshUser()
	{
	}

	private void Message(UIButton btn)
	{
	}

	private void ClearResource()
	{
	}

	[IteratorStateMachine(typeof(_003CCoroutineClearResource_003Ed__18))]
	private IEnumerator CoroutineClearResource()
	{
		return null;
	}

	private void GCCollect()
	{
	}
}
