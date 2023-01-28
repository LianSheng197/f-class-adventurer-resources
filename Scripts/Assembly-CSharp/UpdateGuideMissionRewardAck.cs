using System.Collections.Generic;

public class UpdateGuideMissionRewardAck : AckParam
{
	public GuideMissionProgressData _guideMissionData;

	public List<ItemReward> _rewardList;

	public List<Item> remainingItems;

	public List<ItemMoney> remainingItemMonies;
}
