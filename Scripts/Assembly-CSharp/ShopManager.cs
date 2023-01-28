using System;
using System.Collections.Generic;

public class ShopManager
{
	private static ShopManager _instance;

	private Dictionary<int, ShopMonthly> _monthlyList;

	private Dictionary<int, ShopRecord> _recordList;

	private DateTime _noAutoAdsEndTime;

	public static ShopManager Instance => null;

	public void Init()
	{
	}

	public void SetShopMonthlyList(List<ShopMonthly> list)
	{
	}

	public void SetShopMonthly(ShopMonthly data)
	{
	}

	public bool IsNoAutoAds()
	{
		return false;
	}

	public bool IsNoAds()
	{
		return false;
	}

	public ShopMonthly GetShopMonthly(int shopId)
	{
		return null;
	}

	public List<ShopMonthly> GetShopMonthlyList()
	{
		return null;
	}

	public List<ShopRecord> GetShopRecordList()
	{
		return null;
	}

	public ShopRecord GetShopRecord(DesignShop.Data shopData)
	{
		return null;
	}

	public bool IsSoldOut(int ShopId)
	{
		return false;
	}

	public int GetOrder(int shopCategoryId, int shopId)
	{
		return 0;
	}

	public void SetShopRecordList(List<ShopRecord> list)
	{
	}

	public void SetShopRecord(ShopRecord data)
	{
	}

	public ShopStepUp GetShopStepUp()
	{
		return null;
	}

	public bool IsAvailableBuyNewMark(int shopId = 0)
	{
		return false;
	}
}
