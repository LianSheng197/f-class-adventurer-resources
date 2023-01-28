using System.Collections.Generic;

public class ResetUpgradeAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<UpgradeData> _data;
}
