using System;

[Serializable]
public class Storage
{
	public enum eType
	{
		NormalStorage = 0,
		size = 1
	}

	public long _idx;

	public int _itemId;

	public long _count;

	public eType _type;

	public DateTime _createTime;

	public short _remainHour;

	public short _mailBoxId;

	public int _value1;

	public int _value2;
}
