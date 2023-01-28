using System;

[Serializable]
public class AdsData
{
	public enum eType
	{
		buff = 0,
		shopItem = 1,
		ticket = 2,
		dailyMission = 3
	}

	public int _type;

	public int _designId;

	public DateTime _updateTime;

	public int _accumCount;

	public int _count;

	public int GetCount()
	{
		return 0;
	}

	public void AddCount(int addCount = 1)
	{
	}
}
