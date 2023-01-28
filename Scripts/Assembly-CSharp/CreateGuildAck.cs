using System;
using System.Collections.Generic;

public class CreateGuildAck : AckParam
{
	public int MemberID;

	public DateTime AttendedDate;

	public List<Item> RemainItems;

	public List<ItemMoney> RemainItemMonies;
}
