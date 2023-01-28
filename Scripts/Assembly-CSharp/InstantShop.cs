using System;
using System.Collections.Generic;

[Serializable]
public class InstantShop
{
	public int _designShopId;

	public DateTime _startTime;

	public int _remainMinute;

	public DateTime _endTime => default(DateTime);

	public bool IsActive(DateTime curTime)
	{
		return false;
	}

	public DesignShop.Data GetDesignShop()
	{
		return null;
	}

	public static List<InstantShop> CreateInstantShop_FirstClear(int worldId, int stage)
	{
		return null;
	}

	private static List<InstantShop> CreateInstantShop(DesignInstantShopCategory.eCondition condition, params int[] valueList)
	{
		return null;
	}

	public static bool IsInstatntShop()
	{
		return false;
	}
}
