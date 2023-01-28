public class RandomOption
{
	public enum eType
	{
		None = 0,
		Legend = 1,
		Max = 2
	}

	public int type;

	public int _itemId;

	public int _slot;

	public int _designId;

	public bool _isLock;

	public eType _type => default(eType);

	public string ToLog()
	{
		return null;
	}
}
