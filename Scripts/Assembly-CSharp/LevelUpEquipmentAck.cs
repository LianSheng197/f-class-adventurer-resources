using System.Collections.Generic;

public class LevelUpEquipmentAck : AckParam
{
	public Equipment _equipment;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
