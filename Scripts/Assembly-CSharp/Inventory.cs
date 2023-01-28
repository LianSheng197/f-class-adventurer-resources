using System;
using System.Collections.Generic;

public class Inventory
{
	private delegate void InsertItemTimeDelegate(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange);

	private delegate void UpdateItemTimeDelegate(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange);

	public CharInven _char;

	public ItemInven _item;

	public ItemInven _itemMoney;

	private MissionProgressManager _missionProgressManager;

	public Dictionary<int, long> _consumeTempData;

	private static DesignItem _designItem;

	private static InsertItemTimeDelegate[] _insertItemTimeDelegate;

	private static UpdateItemTimeDelegate[] _updateItemTimeDelegate;

	public void Init()
	{
	}

	public void Add(List<Character> characters)
	{
	}

	public void Add(Character add)
	{
	}

	public void Add(List<Item> items, bool isInit = false)
	{
	}

	public void Add(List<ItemMoney> items)
	{
	}

	public void Add(Item add)
	{
	}

	public bool CheckItem(int itemId)
	{
		return false;
	}

	public long GetCount(int itemId)
	{
		return 0L;
	}

	public void AddConsumeTempData(Dictionary<int, long> consumeTempData)
	{
	}

	public void ClearConsumeTempData()
	{
	}

	public static bool IsApType(int itemId)
	{
		return false;
	}

	public static long ApMax(int itemId)
	{
		return 0L;
	}

	private static void InsertItemTimeNone(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void InsertItemTimeSecond(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void InsertItemTimeHour(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void InsertItemTimeDay(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void UpdateItemTimeNone(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void UpdateItemTimeSecond(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void UpdateItemTimeHour(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	private static void UpdateItemTimeDay(ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, long apMax, long apPeriod, long apChange)
	{
	}

	public static void GetAp(int itemId, ref long ap, ref DateTime apTime, ref TimeSpan apTimeSpan, ref long apMax, ref long apPeriod)
	{
	}

	public static long GetApCur(int itemId)
	{
		return 0L;
	}

	public static TimeSpan GetApRemainTime(int itemId)
	{
		return default(TimeSpan);
	}
}
