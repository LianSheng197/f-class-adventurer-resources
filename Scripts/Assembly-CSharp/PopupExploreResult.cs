using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupExploreResult")]
public class PopupExploreResult : PopupCharacter10GatchaResult
{
	private int _gachaGroupIdx;

	private List<Character> _characters;

	private List<Item> _items;

	private List<ItemReward> _eventRewardList;

	private bool _isStepLevelUp;

	private int _gachaCountIndex;

	public void InitPopupOpen(int gachaGroupIdx, List<Character> characters, List<Item> items, List<ItemReward> eventRewardList, bool isStepLevelUp, int gachaCountIndex, bool isAutoGatcha = false)
	{
	}

	public override void InitPopup(int gachaGroupIdx, List<Character> characters, List<Item> items, List<ItemReward> eventRewardList, bool isStepLevelUp, int gachaCountIndex, bool isAutoGatcha = false)
	{
	}

	private void SetData(int gachaGroupIdx, List<Character> characters, List<Item> items, List<ItemReward> eventRewardList, bool isStepLevelUp, int gachaCountIndex, bool isAutoGatcha = false)
	{
	}

	private void EndAnimation(GameObject obj)
	{
	}

	private void Go()
	{
	}
}
