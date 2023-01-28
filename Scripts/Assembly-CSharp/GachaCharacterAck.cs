using System.Collections.Generic;

public class GachaCharacterAck : AckParam
{
	public GachaRecord _gachaRecord;

	public List<Character> _chars;

	public List<Item> _items;

	public List<ItemMoney> _itemMoneys;

	public List<Item> _existPieceItems;

	public List<Item> _existRewardItems;

	public List<ItemMoney> _existRewardItemMoneys;

	public List<ItemReward> _eventRewardItemList;
}
