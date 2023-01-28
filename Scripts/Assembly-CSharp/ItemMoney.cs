using System;

[Serializable]
public class ItemMoney : Item
{
	public double _timeDouble;

	public DateTime _time
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public void Copy(ref ItemMoney data)
	{
	}

	public new ItemMoney Copy()
	{
		return null;
	}
}
