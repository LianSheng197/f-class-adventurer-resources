using System.Collections.Generic;

public class UpGradeCharacterAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<Character> _chars;
}
