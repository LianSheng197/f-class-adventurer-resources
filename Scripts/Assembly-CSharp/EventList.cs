using System;
using System.Collections.Generic;

[Serializable]
public class EventList
{
	public enum eventType
	{
		none = 0,
		banner = 1,
		login = 2,
		teamLevel = 3,
		access = 4,
		accessKeep = 5,
		randomBox = 6,
		specialMission = 7,
		size = 8,
		mission = 99
	}

	public enum buttonType
	{
		normal = 0,
		special = 1,
		size = 2
	}

	[Serializable]
	public class EventListData
	{
		public int _eventIdx;
	}

	public int _eventIdx;

	public bool _isActive;

	public DateTime _eventStartTime;

	public DateTime _eventEndTime;

	public eventType _eventType;

	public buttonType _buttonType;

	public string _prefabName;

	public int _orderNumber;

	public int _tabName;

	public int _name;

	public string _imgUrl;

	public string _imgUrlJpn;

	public string _imgUrlEng;

	public string _imgUrlChn;

	public string _imgUrlChnSimple;

	public List<EventListData> _dataList;

	public EventUserData _userData;

	public virtual EventListData GetEventData()
	{
		return null;
	}

	public virtual bool IsActive()
	{
		return false;
	}

	protected virtual bool GetRead()
	{
		return false;
	}

	public virtual void SetRead()
	{
	}

	public virtual void UpdateNew()
	{
	}

	public virtual bool CheckNew()
	{
		return false;
	}

	public virtual void SetNew()
	{
	}
}
