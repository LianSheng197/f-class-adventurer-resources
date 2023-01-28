using System;
using System.Collections.Generic;

public class EventBuffManager
{
	public const int _maxDelaySecond = 600;

	public const int _refreshSecond = 60;

	private static EventBuffManager _instance;

	private List<EventBuffGroup> _eventBuffGroupList;

	private DateTime _getBuffListTime;

	public static EventBuffManager instance => null;

	public void SetBuffList(List<EventBuffGroup> list)
	{
	}

	public bool CheckLastGettingTime(int second)
	{
		return false;
	}

	public List<EventBuffGroup> GetClientBuffGroupList(EventBuff.type[] typeList = null, bool checkInvisible = false)
	{
		return null;
	}

	public Dictionary<long, EventBuffGroup> GetClientBuffGroupDictionary(EventBuff.type[] typeList = null, bool checkInvisible = false)
	{
		return null;
	}

	public long GetValue(List<EventBuffGroup> list, long baseValue, EventBuff.type type, EventBuffUserValue userValue)
	{
		return 0L;
	}

	public decimal GetValue(List<EventBuffGroup> list, decimal baseValue, EventBuff.type type, EventBuffUserValue userValue)
	{
		return default(decimal);
	}

	public long GetValue(List<EventBuffGroup> list, long baseValue, EventBuff.type type, EventBuffUserValue userValue, List<Character> partyList)
	{
		return 0L;
	}

	public decimal GetValue(List<EventBuffGroup> list, decimal baseValue, EventBuff.type type, EventBuffUserValue userValue, List<Character> partyList)
	{
		return default(decimal);
	}

	private decimal GetBuffValue(List<EventBuffGroup> list, EventBuff.type type, EventBuffUserValue userValue, List<Character> partyList)
	{
		return default(decimal);
	}

	private List<EventBuff> GetBuff(List<EventBuffGroup> eventBuffGroupList, EventBuff.type type, EventBuffUserValue userValue, Dictionary<int, Character> partyDic)
	{
		return null;
	}

	public long GetBattleBuff_ExpUp(List<EventBuffGroup> list, CUser User, BattleData.BattleType battleType, long getExp, int designWorldId, int designStageId, List<Character> partyList)
	{
		return 0L;
	}

	public List<ItemReward> GetBattleBuff_RewardUp(List<EventBuffGroup> list, CUser User, BattleData.BattleType battleType, EventBuff.type buffType, List<ItemReward> rewardList, int designWorldId, int designStageId, List<Character> partyList)
	{
		return null;
	}

	public bool IsBattleBuff_RewardUp(List<EventBuffGroup> list, CUser User, BattleData.BattleType battleType, EventBuff.type buffType, int designWorldId, int designStageId, List<Character> partyList)
	{
		return false;
	}

	public static bool IsCharacterBuff(EventBuff.type buffType, int charcterId, int characterLevel)
	{
		return false;
	}
}
