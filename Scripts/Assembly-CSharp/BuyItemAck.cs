using System.Collections.Generic;

public class BuyItemAck : AckParam
{
	public enum eIAPError
	{
		failed = 0,
		succeed = 1,
		duplicated = 2
	}

	public eIAPError _error;

	public int _shopId;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<ShopRecord> _recordList;

	public List<ShopMonthly> _monthlyList;

	public List<Storage> _recvStorageList;

	public SpecialMissionGroupData _specialMissionGroup;

	public List<AdsData> _adsList;
}
