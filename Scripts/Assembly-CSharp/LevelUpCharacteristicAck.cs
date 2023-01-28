using System.Collections.Generic;

public class LevelUpCharacteristicAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public CharacteristicData _data;
}
