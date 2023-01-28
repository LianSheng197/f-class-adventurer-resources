using System;

[Serializable]
public class AdsBuffData
{
	public enum eType
	{
		buff_1 = 1,
		buff_2 = 2,
		buff_3 = 3,
		buff_4 = 4
	}

	public int _buffType;

	public int _viewCount;

	public DateTime _lastUpdateTime;

	public int _buffRemainTimeSeconds;
}
