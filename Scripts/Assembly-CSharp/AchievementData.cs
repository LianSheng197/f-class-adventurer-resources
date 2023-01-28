using System;

[Serializable]
public class AchievementData
{
	public long _curValue;

	public int _stepGroup;

	public int _step;

	public int _rewardStep;

	public DateTime _lastProgressTime;

	public int _isReplay;

	public int _isRepetition;

	private static DesignAchievement _designAchievement;

	public DesignAchievement.Data GetDesignAchievement()
	{
		return null;
	}

	public long GetMaxValue()
	{
		return 0L;
	}

	public long GetRewardCount()
	{
		return 0L;
	}

	public bool IsComplete()
	{
		return false;
	}

	public bool IsReward()
	{
		return false;
	}

	public bool IsAdsReward()
	{
		return false;
	}

	public bool IsCondition()
	{
		return false;
	}
}
