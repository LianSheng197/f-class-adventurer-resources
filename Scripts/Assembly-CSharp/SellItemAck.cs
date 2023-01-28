using System.Collections.Generic;

public class SellItemAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<Item> _addItems;

	public List<ItemMoney> _addItemMoneys;
}
