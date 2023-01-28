using System;
using System.Runtime.CompilerServices;

[Serializable]
public class GachaRecord
{
	public int _userId;

	public bool _isFree;

	public int _gachaGroupIdx;

	public DateTime _changeTime;

	public DateTime _stepLimitChangeTime;

	public int _accumBuyCount;

	public int _limitCount;

	public DateTime _buyLimitChangeTime;

	public int _stepCount
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public GachaRecord(int userId, int gachaGroupIdx)
	{
	}

	public int GetStepCount(GachaGroup gachaGroup)
	{
		return 0;
	}

	public int GetBuyCount(GachaGroup gachaGroup)
	{
		return 0;
	}

	public bool CheckResetBuyCount(GachaGroup gachaGroup)
	{
		return false;
	}
}
