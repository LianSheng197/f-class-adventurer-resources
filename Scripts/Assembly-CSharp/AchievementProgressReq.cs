using System.Collections.Generic;

public class AchievementProgressReq : ReqParam
{
	public List<int> _groupList;

	public List<long> _curValueList;

	public List<int> rewardSyncList;

	public void SplitMissionProgressData(List<AchievementData> achievementDataList)
	{
	}

	public void SplitMissionProgressData(Dictionary<int, AchievementData> achievementDataList)
	{
	}

	public void AddMissionProgressData(AchievementData achievementProgressData)
	{
	}
}
