using System.Collections.Generic;

public class FinishBattleRewardAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public string _exp;

	public List<ItemReward> FirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedRandomItemReward;
}
