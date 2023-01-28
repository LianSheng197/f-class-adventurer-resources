using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupItemSelect")]
public class PopupItemSelect : PopupBase
{
	private Storage _storage;

	private WWWData.AckCallBack _callBack;

	private ItemCard _selectCard;

	private ItemCard _itemCard;

	private UILabel _name;

	private UILabel _grade;

	private Dictionary<int, ItemCard> _itemSelectList;

	public void InitPopup(Storage storage, WWWData.AckCallBack callBack)
	{
	}

	private void SelectItem(UIButton btn)
	{
	}

	private void UpdateSelect()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
