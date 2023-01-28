using System;
using System.Collections.Generic;

[Serializable]
public class EventAccessUserData : EventUserData
{
	[Serializable]
	public class Reward
	{
		public int rewardId;

		public DateTime _rewardTime;
	}

	public List<Reward> _list;
}
