using System.Collections.Generic;

public class AchievementRewardAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<ItemReward> _rewardList;

	public List<AchievementData> _achievementList;

	public List<AdsData> _adsList;
}
