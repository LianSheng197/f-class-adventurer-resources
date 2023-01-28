using System;
using System.Collections.Generic;

[Serializable]
public class EventLogin : EventList
{
	[Serializable]
	public class Data : EventListData
	{
		public enum EVENT_TYPE
		{
			SuccessiveDay = 1,
			AccrueDay = 2,
			TargetDay = 3
		}

		[Serializable]
		public class LoginEventDataNew
		{
			public byte _day;

			public int _rewardType;

			public int _rewardValue;

			public int _mailId;
		}

		[Serializable]
		public class EventLoginDayInfo
		{
			public byte _day;

			public bool _checkDay;

			public bool _checkDayReward;
		}

		public const int LOGIN_EVENT_DATA = 25;

		public int _idx;

		public int _conditionType;

		public int _conditionValue;

		public DateTime _startTime;

		public DateTime _endTime;

		public DateTime _allEndTime;

		public EVENT_TYPE _type;

		public int _eventDay;

		public int _successCount;

		public List<LoginEventDataNew> _rewardData;

		public List<LoginEventDataNew> _successRewardData;

		public bool IsRewardState(EventLogin eventLogin, EventLoginUserData userData)
		{
			return false;
		}

		private int GetLoginEventSuccessCount(EventLoginUserData userData)
		{
			return 0;
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
