using System.Collections.Generic;

public class FinishGuildBossBattleAck : AckParam
{
	public List<ItemReward> ItemRewards;

	public List<Item> RemainingItems;

	public List<ItemMoney> RemainingItemMonies;

	public List<AdsData> _adsList;
}
