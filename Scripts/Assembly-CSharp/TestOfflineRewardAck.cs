using System.Collections.Generic;

public class TestOfflineRewardAck : AckParam
{
	public int _stageId;

	public int _rewardTime;

	public string _exp;

	public List<ItemReward> _rewardList;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
