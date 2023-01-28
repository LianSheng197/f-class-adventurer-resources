using System.Collections.Generic;

public class SpecialMissionRewardReq : ReqParam
{
	public int _specialMissionId;

	public List<int> _criteriaValueNormalList;

	public List<int> _criteriaValuePremiumList;
}
