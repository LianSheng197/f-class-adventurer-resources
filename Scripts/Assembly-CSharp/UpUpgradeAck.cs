using System.Collections.Generic;

public class UpUpgradeAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public UpgradeData _before;

	public UpgradeData _data;
}
