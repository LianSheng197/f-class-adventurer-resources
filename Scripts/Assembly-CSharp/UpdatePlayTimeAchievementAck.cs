using System.Collections.Generic;

public class UpdatePlayTimeAchievementAck : AckParam
{
	public List<AchievementData> _achievementDataList;

	public List<MissionProgressData> _missionDataList;
}
