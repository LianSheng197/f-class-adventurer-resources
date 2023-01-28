using System.Collections.Generic;

public class FinishBattleAck : AckParam
{
	public bool _isAbusing;

	public Stage _stage;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public string _exp;

	public List<ItemReward> FirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedItemReward;

	public List<ItemReward> ItemRewardsWithoutFirstClearedRandomItemReward;

	public List<InstantShop> _instantShop;

	public int _prevRank;

	public int _curRank;
}
