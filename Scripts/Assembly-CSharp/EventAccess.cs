using System;

[Serializable]
public class EventAccess : EventList
{
	[Serializable]
	public class Data : EventListData
	{
		public int _idx;

		public DateTime _startTime;

		public DateTime _endTime;

		public int _value1;

		public int _mailboxId;

		public byte _day;

		public string _itemIds;

		public string _itemCounts;

		public bool _isReward;

		public bool _isComplete;

		public bool _isPrevComplete;

		public double _remainSeconds;

		public static int SortEventAccess(EventListData aSource, EventListData bSource)
		{
			return 0;
		}

		public static int SortEventAccessKeep(EventListData aSource, EventListData bSource)
		{
			return 0;
		}

		public bool IsRewardStateEventAccess(EventAccess eventAccess, EventAccessUserData userData)
		{
			return false;
		}

		public bool IsRewardStateEventAccessKeep(int rowCount, EventAccess eventAccess, EventAccessUserData userData)
		{
			return false;
		}

		public void CalcAccess(EventAccess eventAccess, EventAccessUserData userData, ref bool isReward)
		{
		}

		public void CalcAccessKeep(int rowCount, EventAccess eventAccess, EventAccessUserData userData, ref bool isReward)
		{
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
