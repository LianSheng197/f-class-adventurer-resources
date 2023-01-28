using System.Collections.Generic;

public class ResetDailyMissionAck : AckParam
{
	public List<MissionData> _listData;

	public List<MissionProgressData> _listProgressData;

	public List<AchievementData> _achievementList;
}
