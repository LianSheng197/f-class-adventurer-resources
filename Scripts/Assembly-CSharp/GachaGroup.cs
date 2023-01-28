using System;
using System.Collections.Generic;

[Serializable]
public class GachaGroup
{
	public enum eGachaType
	{
		eNormal = 0,
		eEvent = 1,
		eSale = 2
	}

	public int _idx;

	public DateTime _startTime;

	public DateTime _endTime;

	public int _order;

	public int _saleType;

	public int _price;

	public int _itemId;

	public int _itemCount;

	public int _openLevel;

	public int _openStage;

	public List<int> _gachaCountList;

	public List<int> _freeSaleCoolTimeList;

	public int _gachaBonusGroupId;

	public int _gachaGroupId;

	public bool _isGradeJump;

	public byte _gachaType;

	public int _salePercent;

	public List<int> _eventRewardItemIdList;

	public List<int> _eventRewardItemCountList;

	public int _eventRewardMailId;

	public List<int> _bonusRewardPoint;

	public List<int> _bonusRewardCount;

	public int _bonusResetCount;

	public int _stepGroup;

	public int _step;

	public int _stepCompleteValue;

	public DesignShop.Data.LimitedType _limitedType;

	public int _limitCount;

	public int _buyLimitedType;

	public int _bannerGroupId;

	public int _changeId;

	public List<string> _name;

	public List<string> _longDescription;

	public List<string> _buttonUrl;

	public List<string> _bannerUrl;

	public List<GachaData> _gachaDataList;

	[NonSerialized]
	public Dictionary<int, GachaGroup> _stepGroupList;

	public int getMaxRewardPoint => 0;

	public int GetMaxStep()
	{
		return 0;
	}

	public GachaGroup Copy()
	{
		return null;
	}

	public eGachaType GetGachaType()
	{
		return default(eGachaType);
	}

	public bool IsGachaType(eGachaType type)
	{
		return false;
	}

	public List<ItemReward> GetEventItemRewardList(int gachaCountListIndex)
	{
		return null;
	}

	public static long GetPreSalePrice(GachaGroup groupData, long price)
	{
		return 0L;
	}

	public long GetPreSalePrice()
	{
		return 0L;
	}

	public bool IsActiveTime(DateTime curTime)
	{
		return false;
	}

	public GachaGroup GetCurrentStep(Dictionary<int, GachaRecord> recordList)
	{
		return null;
	}

	public GachaGroup GetNextStep()
	{
		return null;
	}

	public GachaGroup GetPrevStep()
	{
		return null;
	}

	public bool TryGetGachaCountByIndex(int gachaCountListIndex, out int result)
	{
		result = default(int);
		return false;
	}

	public bool TryGetFreeSaleCoolTimeByGachaCountIndex(int gachaCountListIndex, out int result)
	{
		result = default(int);
		return false;
	}
}
