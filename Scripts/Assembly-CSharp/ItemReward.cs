using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class ItemReward
{
	public enum eRewardListType
	{
		invisible = 0,
		each = 1,
		sum = 2
	}

	[JsonProperty]
	public readonly int _itemId;

	[JsonProperty]
	public readonly long _count;

	[JsonConstructor]
	public ItemReward(int itemId, long count)
	{
	}

	public Item GetItem()
	{
		return null;
	}

	public DesignItem.Data GetDesignItem()
	{
		return null;
	}

	public static eRewardListType[] GetListType(eRewardListType Currency = eRewardListType.sum, eRewardListType Normal = eRewardListType.sum)
	{
		return null;
	}

	public static List<ItemReward> GetList(List<ItemReward> list, eRewardListType[] listType)
	{
		return null;
	}
}
