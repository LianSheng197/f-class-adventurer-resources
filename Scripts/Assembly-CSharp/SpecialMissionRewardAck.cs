using System.Collections.Generic;

public class SpecialMissionRewardAck : AckParam
{
	public SpecialMissionGroupData _specialMissionGroup;

	public List<SpecialMissionRewardData> _specialMissionList;

	public List<ItemReward> _rewardList;
}
