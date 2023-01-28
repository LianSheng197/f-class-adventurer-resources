using System.Collections.Generic;

public class LevelUpKeepMarkAck : AckParam
{
	public KeepMark _mark;

	public RandomSeed _seed;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;
}
