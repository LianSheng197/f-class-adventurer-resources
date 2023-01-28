using System;
using System.Collections.Generic;

[Serializable]
public class EventLoginUserData : EventUserData
{
	public DateTime _loginEventStartTime;

	public List<EventLogin.Data.EventLoginDayInfo> _listData;

	public List<EventLogin.Data.EventLoginDayInfo> _successRewardData;

	public bool _isSuccessReward;
}
