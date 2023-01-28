using System.Collections.Generic;

public class BattleStageBossAck : AckParam
{
	public Stage _stage;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<ItemReward> _firstRewards;
}
