using System.Collections.Generic;
using UnityEngine;

public class EventViewAccess : EventView
{
	private EventAccess _eventList;

	private EventAccess.Data _data;

	private EventAccessUserData _userData;

	private UILabel _accessTime;

	private UILabel _time;

	private Dictionary<int, GameObject> _objList;

	private const int _maxRewardStep = 5;

	protected override void GetData()
	{
	}

	public override void InitView(int id, EventTab tab)
	{
	}

	public override void UpdateView()
	{
	}

	private void UpdateTime()
	{
	}

	private void Message(UIButton btn)
	{
	}

	public override void UpdateRemainTimeLabel()
	{
	}
}
