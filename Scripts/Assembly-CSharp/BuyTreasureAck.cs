using System.Collections.Generic;

public class BuyTreasureAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<TreasureData> _list;
}
