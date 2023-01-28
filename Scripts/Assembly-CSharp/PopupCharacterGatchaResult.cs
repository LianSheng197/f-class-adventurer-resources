using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupCharacterGatchaResult")]
public class PopupCharacterGatchaResult : PopupBase
{
	private static List<BaseObject> _resultList;

	private GachaGroup _gachaGroup;

	private Character _character;

	private int _buyItemId;

	private long _buyItemCount;

	private bool _isOneMore;

	private bool _IsStepLevelUp;

	private CheckConsume _checkConsume;

	private GameObject _onemore;

	private GameObject _close;

	private GameObject _close1btn;

	private List<ItemReward> _eventRewardList;

	private UIGrid _grid;

	public void InitPopup(List<BaseObject> resultList)
	{
	}

	public void InitPopup(List<BaseObject> resultList, List<ItemReward> eventRewardList, bool IsStepLevelUp)
	{
	}

	public void InitPopup(Character character, List<ItemReward> eventRewardList, bool IsStepLevelUp)
	{
	}

	public void InitPopup(int gachaGroupIdx, Character character, List<ItemReward> eventRewardList, bool IsStepLevelUp)
	{
	}

	public void ShowClearRewardLabel()
	{
	}

	private void AnimationEnd(GameObject obj)
	{
	}

	private void AnimationRewardEnd(GameObject obj)
	{
	}

	public void OnBtnShow()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void GoShop(GameObject obj, UIButton btn)
	{
	}
}
