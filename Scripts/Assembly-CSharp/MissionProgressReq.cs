using System.Collections.Generic;

public class MissionProgressReq : ReqParam
{
	public List<int> _missionIdList;

	public List<long> _missionCurValueList;

	public List<int> rewardSyncList;

	public void SplitMissionProgressData(List<MissionProgressData> missionDataList)
	{
	}

	public void SplitMissionProgressData(Dictionary<int, MissionProgressData> missionDataList)
	{
	}

	public void AddMissionProgressData(MissionProgressData missionData)
	{
	}
}
