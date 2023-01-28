using System;

[Serializable]
public class MissionProgressData
{
	public int _missionListId;

	public int _missionId;

	public long _curValue;

	public bool _isReward;

	public DateTime _progressTime;

	public MissionProgressData()
	{
	}

	public MissionProgressData(DesignMissionList.Data designMissionList)
	{
	}

	public void Update(MissionProgressData missionProgressData)
	{
	}

	public MissionProgressData Copy()
	{
		return null;
	}

	public DesignMissionList.Data GetDesignMissionList()
	{
		return null;
	}

	public DesignMission.Data GetDesignMission()
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
