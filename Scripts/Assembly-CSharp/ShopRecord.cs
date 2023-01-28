using System;

[Serializable]
public class ShopRecord
{
	public int _shopId;

	public DateTime _updateTime;

	public int _sumCount;

	private int count;

	public int _count
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public TimeSpan GetRemainResetTime()
	{
		return default(TimeSpan);
	}
}
