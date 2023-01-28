using System.Collections.Generic;
using UnityEngine;

public class EventViewLogin : EventView
{
	private EventLogin _eventList;

	private EventLogin.Data _data;

	private EventLoginUserData _userData;

	private UILabel _refreshTime;

	private Dictionary<byte, GameObject> _objList;

	protected override void GetData()
	{
	}

	public override void InitView(int id, EventTab tab)
	{
	}

	public override void UpdateView()
	{
	}

	public byte GetLoginEventToday()
	{
		return 0;
	}

	private EventLogin.Data.EventLoginDayInfo GetDayInfo(byte day)
	{
		return null;
	}

	private void Message(UIButton btn)
	{
	}

	public override void UpdateRemainTimeLabel()
	{
	}
}
