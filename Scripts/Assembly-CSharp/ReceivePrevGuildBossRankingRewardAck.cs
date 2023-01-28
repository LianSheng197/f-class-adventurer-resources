using System;
using System.Collections.Generic;

public class ReceivePrevGuildBossRankingRewardAck : AckParam
{
	public DateTime ReceivedAt;

	public List<ItemReward> ReceivedItemRewards;

	public List<Item> RemainingItems;

	public List<ItemMoney> RemainingItemMonies;
}
