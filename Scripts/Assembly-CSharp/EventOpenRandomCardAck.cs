using System.Collections.Generic;

public class EventOpenRandomCardAck : AckParam
{
	public List<EventRandomCardInfo> _list;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
