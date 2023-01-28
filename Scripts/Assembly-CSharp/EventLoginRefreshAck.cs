using System;
using System.Collections.Generic;

public class EventLoginRefreshAck : AckParam
{
	[Serializable]
	public class ConvertJsonData
	{
		public List<EventLoginUserData> _userData;
	}

	public List<ItemReward> _rewardList;

	public string _userDataList;
}
