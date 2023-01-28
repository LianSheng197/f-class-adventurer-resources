using System;
using System.Collections.Generic;

[Serializable]
public class EventTeamLevel : EventList
{
	[Serializable]
	public class Data : EventListData
	{
		[Serializable]
		public class rewardData
		{
			public int _rewardLevel;

			public int _rewardType;

			public int _rewardValue;

			public int _mailId;
		}

		public int _idx;

		public DateTime _startTime;

		public DateTime _endTime;

		public DateTime _joinEndTime;

		public int _levelMin;

		public int _levelMax;

		public List<rewardData> _rewardList;

		public bool IsClear(EventTeamLevelUserData userData)
		{
			return false;
		}

		public bool IsRewardState(EventTeamLevel eventTeamLevel, EventTeamLevelUserData userData)
		{
			return false;
		}
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
