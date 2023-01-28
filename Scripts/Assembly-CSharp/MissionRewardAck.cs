using System.Collections.Generic;

public class MissionRewardAck : AckParam
{
	public List<ItemReward> _rewardList;

	public List<MissionProgressData> _missionDataList;
}
