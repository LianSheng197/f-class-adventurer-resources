public class ItemInven : Inven<Item>
{
	public enum ItemInvenType
	{
		Piece = 0,
		Money = 1,
		Max = 2
	}

	public ItemInvenType _itemInvenType;

	public override int Count()
	{
		return 0;
	}

	public ItemInven()
	{
		((Inven<>)(object)this)._002Ector();
	}
}
