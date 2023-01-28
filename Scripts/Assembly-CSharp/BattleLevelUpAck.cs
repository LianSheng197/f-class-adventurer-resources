using System.Collections.Generic;

public class BattleLevelUpAck : AckParam
{
	public bool _isLevelUp;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
