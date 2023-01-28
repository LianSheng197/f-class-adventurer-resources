using System.Collections.Generic;

public class FinishBossDealBattleAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public BossDealRankingData _data;

	public List<ItemReward> FirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedRandomItemReward;

	public Stage _stage;
}
