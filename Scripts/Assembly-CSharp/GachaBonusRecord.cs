using System;

[Serializable]
public class GachaBonusRecord
{
	public int _userId;

	public int _gachaBonusGroupId;

	public long _bonusPoint;

	public int _bonusStep;

	public long _bonusRewardPoint;

	public DateTime _changeTime;

	public GachaBonusRecord(int userId, int gachaBonusGroupId)
	{
	}

	public bool GetBonusGacha(GachaGroup gachaGroup)
	{
		return false;
	}

	public void AddBonusPoint(int addPoint, GachaGroup gachaGroup)
	{
	}

	private void ResetBonusCount(GachaGroup gachaGroup)
	{
	}

	private bool IsEnd(GachaGroup gachaGroup)
	{
		return false;
	}

	private int GetStep(long point, GachaGroup gachaGroup)
	{
		return 0;
	}

	private int GetCycle(long point, GachaGroup gachaGroup)
	{
		return 0;
	}
}
