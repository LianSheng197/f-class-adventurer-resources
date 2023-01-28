using System.Collections.Generic;

public class RecvGachaRecordRewardAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<GachaRecordReward> _rewards;

	public List<ItemReward> _itemRewards;
}
