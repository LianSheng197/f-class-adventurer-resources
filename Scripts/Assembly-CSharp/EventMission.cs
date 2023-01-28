using System;

[Serializable]
public class EventMission : EventList
{
	[Serializable]
	public class Data : EventListData
	{
	}

	public override bool IsActive()
	{
		return false;
	}

	public override bool CheckNew()
	{
		return false;
	}
}
