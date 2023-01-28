using System.Collections.Generic;

public class EventManager
{
	private List<EventList> _eventList;

	public List<EventList> GetEventList(EventList.buttonType buttonType)
	{
		return null;
	}

	public EventList GetEvent(int eventIdx)
	{
		return null;
	}

	public void RemoveEventList(int eventIdx)
	{
	}

	public void ChangeUserData<T>(int eventIdx, T userData) where T : EventUserData
	{
	}

	public void ClearEventList()
	{
	}

	public void SetEventList<T1, T2>(List<T1> list, List<T2> listData) where T1 : EventList where T2 : EventList.EventListData
	{
	}

	public void SetEventList<T1, T2, T3>(List<T1> list, List<T2> listData, List<T3> listUserData) where T1 : EventList where T2 : EventList.EventListData where T3 : EventUserData
	{
	}

	public void RemoveEventTeamLevel()
	{
	}

	public bool CheckNew(EventList.buttonType buttonType, int eventIdx = 0)
	{
		return false;
	}

	public bool IsSpecialEventList()
	{
		return false;
	}
}
