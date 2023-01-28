using System.Collections.Generic;

public class EnchantEquipmentAck : AckParam
{
	public Equipment _equipment;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
