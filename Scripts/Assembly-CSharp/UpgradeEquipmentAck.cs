using System.Collections.Generic;

public class UpgradeEquipmentAck : AckParam
{
	public int _itemId;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
