using System.Collections.Generic;

public class BattleRewardAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<BattleRewardAckData> _ackDataList;
}
