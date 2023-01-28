using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupEquipment")]
public class PopupEquipment : PopupBase
{
	private DesignEquipment.Data.Slot _curFilter;

	private RadioGroup _radioGroup;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UISprite _drag;

	private EquipmentCard _selectCard;

	private Dictionary<int, EquipmentCard> _cardList;

	private Transform _detailInfo;

	private Transform _itemCardPosition;

	private GameObject _left;

	private GameObject _right;

	private UILabel _itemName;

	private UILabel _itemGrade;

	private GameObject _prefabStat;

	private UIScrollView _statScrollView;

	private UIGrid _statGrid;

	private GameObject _prefabHaveStat;

	private UIScrollView _haveStatScrollView;

	private UIGrid _haveStatGrid;

	private Transform _lvUpOn;

	private Transform _lvUpOff;

	private Transform _lvUpMax;

	private Transform _expand;

	private Transform _enchantOn;

	private Transform _enchantOff;

	private Transform _enchantMax;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private GameObject _equipNew;

	private AutoButtonPush _autoPush;

	private GameObject _effectPosition;

	private GameObject _levelUpEffect;

	private GameObject _equipEffect;

	private GameObject _expandEffect;

	private Transform _divideOn;

	private Transform _divideOff;

	private Dictionary<int, long> _checkNeedItem;

	public void InitPopup()
	{
	}

	public void InitAutoCurrency(Dictionary<int, long> needItem)
	{
	}

	private void SelectFilter(string select)
	{
	}

	private bool CheckFilter(string select)
	{
		return false;
	}

	private void ChangeTab()
	{
	}

	private void UpdateEquipNew()
	{
	}

	public override void UpdateItem()
	{
	}

	public void UpdateCardList()
	{
	}

	public int GetSiblingIndex(int id)
	{
		return 0;
	}

	public EquipmentCard GetEquipCard(int index)
	{
		return null;
	}

	public int GetGridCount()
	{
		return 0;
	}

	public void UpdateSelectCard(EquipmentCard card)
	{
	}

	private void SelectItem(UIButton btn)
	{
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private void ShowDetailInfoEnchant(bool isShow)
	{
	}

	private bool CheckUpgradeAllNew()
	{
		return false;
	}

	private void AutoPushCall(UIButton btn, AutoButtonPush.DelegateState state)
	{
	}

	private bool AsyncLevelUp()
	{
		return false;
	}

	public void AckLevelUp()
	{
	}

	private void RequestAsync(UIButton btn)
	{
	}

	public void AckEquipment()
	{
	}

	public void AckExpandLevel()
	{
	}

	private void EndEffect(GameObject obj)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void LvUp(UIButton btn)
	{
	}

	private void OnEnchant(UIButton btn)
	{
	}

	public override void PopupCloseCall()
	{
	}
}
