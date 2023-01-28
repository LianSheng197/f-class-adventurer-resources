using System.Collections.Generic;
using UnityEngine;

public class EventViewRandomBox : EventView
{
	private EventRandomBox _eventList;

	private EventRandomBox.Data _data;

	private EventRandomBoxUserData _userData;

	private Dictionary<int, ItemCard> _randomBoxList;

	private EventRandomBox.Data _selectRandomBox;

	private UIGrid _grid;

	private List<AutoCurrency> _autoCurrency;

	private UIGrid _btnGrid;

	private UILabel _resetTimeLabel;

	private int _goShopItemId;

	protected override void GetData()
	{
	}

	public override void InitView(int id, EventTab tab)
	{
	}

	public override void UpdateView()
	{
	}

	public void NextSelect()
	{
	}

	public void SelectRandomBox(UIButton btn)
	{
	}

	public void SelectRandomBox(EventRandomBox.Data eventRandomBox)
	{
	}

	private EventRandomBox.Data GetEventRandomBox(int boxId)
	{
		return null;
	}

	private bool IsSoldOut(int boxId)
	{
		return false;
	}

	private void Message(UIButton btn)
	{
	}

	private void Buy(UIButton btn)
	{
	}

	public void GoShop(GameObject obj, UIButton btn)
	{
	}

	public override void UpdateRemainTimeLabel()
	{
	}
}
