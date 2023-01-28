using System;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupCharacter_AltarLvUp")]
public class PopupCharacter_AltarLvUp : PopupBase
{
	private GameObject _rewardPrefab;

	private UIGrid _rewardGrid;

	private UISlider _exp;

	private UILabel _expLabel;

	private UISlider _expEffect;

	private UIScrollView _selectScrollView;

	private UIGrid _selectGrid;

	private GameObject _noSelectItem;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private GameObject _lvMax;

	private GameObject _effectPosition;

	private Dictionary<int, ItemCard> _selectCardList;

	private Dictionary<int, ItemCard> _itemCardList;

	private List<Tuple<int, long>> _addItems;

	private long _addExp;

	private List<ContentsFunctionData> _contentsFunctionData;

	private List<ContentsFunctionData> _addContentsFunctionData;

	public void InitPopup()
	{
	}

	public void UpdateView()
	{
	}

	private void MakeItemList()
	{
	}

	private void SelectItem(UIButton btn)
	{
	}

	private void DeleteItem(UIButton btn)
	{
	}

	private void AddSelectItem(int itemId, long count)
	{
	}

	private void DelSelectItem(int itemId, long count)
	{
	}

	private void AddSelectLongTouch(BaseCard card)
	{
	}

	private void DelSelectLongTouch(BaseCard card)
	{
	}

	private long GetSelectItemCount(int itemId)
	{
		return 0L;
	}

	private void CalcAltar()
	{
	}

	private void AllAltar()
	{
	}

	public void AckAltar()
	{
	}

	private void RequestAltarExp(UIButton btn)
	{
	}

	private void AskAltarMax(GameObject obj, UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
