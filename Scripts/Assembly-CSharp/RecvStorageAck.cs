using System.Collections.Generic;

public class RecvStorageAck : AckParam
{
	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<Character> _chars;

	public List<ItemReward> _rewardList;

	public string _prevUserName;

	public int _randomBoxItemId;

	public List<ShopMonthly> _monthlyList;

	public SpecialMissionGroupData _specialMissionGroup;

	public List<Storage> _recvStorageList;

	public List<ShopRecord> _recordList;

	public int _shopId;
}
