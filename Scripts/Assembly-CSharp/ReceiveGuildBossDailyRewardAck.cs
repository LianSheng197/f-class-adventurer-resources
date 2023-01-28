using System.Collections.Generic;

public class ReceiveGuildBossDailyRewardAck : AckParam
{
	public int DesignGuildBossRankID;

	public ItemReward ReceivedItemReward;

	public List<Item> RemainingItems;

	public List<ItemMoney> RemainingItemMonies;
}
