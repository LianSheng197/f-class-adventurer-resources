using System.Collections.Generic;

public class RewardCollectionAck : AckParam
{
	public int _collectionId;

	public List<ItemReward> _rewards;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
