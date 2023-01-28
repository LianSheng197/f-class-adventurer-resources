using System.Collections.Generic;

public class AttendGuildAck : AckParam
{
	public ItemReward AttendanceRewardItem;

	public List<Item> RemainItems;

	public List<ItemMoney> RemainItemMonies;
}
