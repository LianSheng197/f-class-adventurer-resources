using System;

[Serializable]
public class GuideMissionProgressData
{
	public bool _isUpdateGuideMission;

	public int _missionId;

	public long _curValue;

	public bool _isReward;

	public DateTime _progressTime;

	public GuideMissionProgressData()
	{
	}

	public GuideMissionProgressData(DesignGuideMission.Data designGuideMission)
	{
	}

	public GuideMissionProgressData(DesignUpdateGuideMission.Data designGuideMission)
	{
	}

	public void Update(GuideMissionProgressData guideMissionProgressData)
	{
	}

	public GuideMissionProgressData Copy()
	{
		return null;
	}

	public DesignGuideMission.Data GetDesignGuideMission()
	{
		return null;
	}

	public DesignUpdateGuideMission.Data GetDesignUpdateGuideMission()
	{
		return null;
	}

	public bool CheckRewardOpen()
	{
		return false;
	}

	public bool CheckComplete()
	{
		return false;
	}

	public long GetMaxValue()
	{
		return 0L;
	}
}
