using System.Collections.Generic;

public class FinishBossBattleAck : AckParam
{
	public List<Item> RemainingItems;

	public List<ItemMoney> RemainingItemMonies;

	public List<ItemReward> FirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedRandomItemReward;

	public Stage _stage;

	public int OldBossRank;

	public int NewBossRank;

	public List<AdsData> _adsList;
}
