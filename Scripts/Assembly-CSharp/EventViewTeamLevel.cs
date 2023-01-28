using System.Collections.Generic;
using UnityEngine;

public class EventViewTeamLevel : EventView
{
	private EventTeamLevel _eventList;

	private EventTeamLevel.Data _data;

	private EventTeamLevelUserData _userData;

	private UILabel _time;

	private Dictionary<int, GameObject> _objList;

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

	private EventTeamLevelUserData.Reward GetRewardInfo(int index)
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
