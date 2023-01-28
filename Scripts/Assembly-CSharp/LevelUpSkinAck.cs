using System.Collections.Generic;

public class LevelUpSkinAck : AckParam
{
	public int newLevel;

	public List<Item> remainingItems;

	public List<ItemMoney> remainingItemMonies;
}
