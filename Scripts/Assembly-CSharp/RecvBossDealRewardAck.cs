using System.Collections.Generic;

public class RecvBossDealRewardAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public BossDealRankingData _data;
}
