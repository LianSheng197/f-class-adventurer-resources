using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Popup/PopupBattleResultGuildBoss")]
public class PopupBattleResultGuildBoss : PopupBase
{
	[CompilerGenerated]
	private sealed class _003CUpdateRemainCloseTime_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupBattleResultGuildBoss _003C_003E4__this;

		private UILabel _003CtimeLabel_003E5__2;

		private float _003CcloseTime_003E5__3;

		private float _003Cspan_003E5__4;

		private float _003CprevSpan_003E5__5;

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
		public _003CUpdateRemainCloseTime_003Ed__5(int _003C_003E1__state)
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

	private const float REWARD_SHOW_TIME = 0.1f;

	private int _rewardShow;

	private int _rewardCount;

	private UIGrid _rewardGrid;

	public void InitPopup(WWWData wwwData, BattleData battleData)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateRemainCloseTime_003Ed__5))]
	private IEnumerator UpdateRemainCloseTime()
	{
		return null;
	}

	private void GotoMain()
	{
	}

	private void NextReward()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
