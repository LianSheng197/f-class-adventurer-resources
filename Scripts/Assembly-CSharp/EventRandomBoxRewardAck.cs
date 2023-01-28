using System.Collections.Generic;

public class EventRandomBoxRewardAck : EventRewardAck
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public EventRandomBoxUserData _eventUserData => null;
}
