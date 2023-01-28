using System.Collections.Generic;

public class BuyRandomOptionAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<RandomOption> _randomOptions;

	public RandomSeed _seed;
}
