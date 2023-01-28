using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("Popup/PopupCharacter10GatchaResult")]
public class PopupCharacter10GatchaResult : PopupBase
{
	[CompilerGenerated]
	private sealed class _003COnGachaAnimation_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PopupCharacter10GatchaResult _003C_003E4__this;

		private Transform _003CaxisForm_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003COnGachaAnimation_003Ed__31(int _003C_003E1__state)
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

	private GachaGroup _gachaGroup;

	private bool _isStepLevelUp;

	private bool _isOneMore;

	private List<Character> _resultCharacterList;

	private List<Item> _resultItemList;

	private GameObject _allOpen;

	private GameObject _inputTouch;

	private UIGrid _btnGrid;

	private GameObject _onemore;

	private GameObject _close;

	private GameObject _auto;

	private GameObject _Lv;

	private Transform _fxSkip;

	private GachaConsumeState _consumeData;

	private List<AutoCurrency> _autoCurrencyList;

	private List<int> _curSellTypeList;

	private int _index;

	private List<ItemReward> _eventRewardList;

	private int _gachaCountIndex;

	public bool _isAutoGatcha;

	private bool _isChangeStep;

	private bool _isFxSkip;

	private bool isWaitOneMore;

	private float oneMoreAutoTime;

	private float _btnShowTime;

	private bool _isWaitBtnShow;

	private Dictionary<string, bool> _soundList;

	private DesignItem.Data _moveDesignItem;

	private void UpdateConsumeData()
	{
	}

	public virtual void InitPopup(int gachaGroupIdx, List<Character> characters, List<Item> items, List<ItemReward> eventRewardList, bool isStepLevelUp, int gachaCountIndex, bool isAutoGatcha = false)
	{
	}

	private void Update()
	{
	}

	private void InitStepUpExp()
	{
	}

	[IteratorStateMachine(typeof(_003COnGachaAnimation_003Ed__31))]
	private IEnumerator OnGachaAnimation()
	{
		return null;
	}

	private void ShowEventReward()
	{
	}

	private bool CheckAnimation()
	{
		return false;
	}

	private void OnGachaEnd()
	{
	}

	private void ShowButtons()
	{
	}

	private void CancelAnimation()
	{
	}

	private void OnOneMore()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void OnAutoGatcha(bool isAutoGatcha)
	{
	}

	private void OnFxSkip(bool isFxSkip)
	{
	}

	public void GoShop(GameObject obj, UIButton btn)
	{
	}

	private void Buy(int count)
	{
	}

	public void OnUpdate(GameObject obj, UIButton btn)
	{
	}

	public void InitCurrency()
	{
	}
}
