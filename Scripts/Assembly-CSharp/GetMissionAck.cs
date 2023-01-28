using System.Collections.Generic;

public class GetMissionAck : AckParam
{
	public List<MissionData> _listData;

	public List<MissionProgressData> _listProgressData;

	public List<AchievementData> _achievementList;

	public GuideMissionProgressData _guideMission;

	public GuideMissionProgressData _updateGuideMission;
}
