using System;
using System.Collections.Generic;

[Serializable]
public class ShopMonthly
{
	public const int MAX_MONTHLY_DATA = 30;

	public int _shopId;

	public DateTime _startTime;

	public DateTime _endTime;

	public DateTime _lastRewardTime;

	public List<bool> _rewardByDay;

	public int GetCurrentDayCount()
	{
		return 0;
	}

	public bool IsReward()
	{
		return false;
	}

	public bool IsEnd()
	{
		return false;
	}
}
