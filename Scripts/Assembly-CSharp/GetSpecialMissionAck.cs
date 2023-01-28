using System.Collections.Generic;

public class GetSpecialMissionAck : AckParam
{
	public List<SpecialMissionGroupData> _specialMissionGroupList;

	public List<SpecialMissionRewardData> _specialMissionRewardList;
}
