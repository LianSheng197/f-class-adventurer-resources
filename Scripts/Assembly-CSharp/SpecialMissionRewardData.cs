using System;

[Serializable]
public class SpecialMissionRewardData
{
	public int _specialMissionId;

	public int _criteriaValue;

	public bool _isPremium;

	public int _rewardId;

	public DateTime _rewardTime;

	private DesignSpecialMission.Data GetDesignSpecialMission()
	{
		return null;
	}
}
