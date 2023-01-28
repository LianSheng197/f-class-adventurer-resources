using System.Collections.Generic;

public class LevelUpTreasureAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public TreasureData _data;
}
