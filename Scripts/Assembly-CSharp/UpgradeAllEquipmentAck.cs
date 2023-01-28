using System.Collections.Generic;

public class UpgradeAllEquipmentAck : AckParam
{
	public List<int> _makeItemIdList;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public long _upgradeCount;
}
