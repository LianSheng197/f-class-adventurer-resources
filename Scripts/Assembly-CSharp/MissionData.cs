using System;

[Serializable]
public class MissionData
{
	public int _missionId;

	public DateTime _endDate;

	public bool _replay;

	public int _stepGroupId;

	public int _step;

	public MissionData()
	{
	}

	public MissionData(DesignMission.Data designMission)
	{
	}

	public DesignMission.Data GetDesignMission()
	{
		return null;
	}
}
