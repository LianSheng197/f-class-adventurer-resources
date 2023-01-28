using System;
using System.Collections.Generic;

[Serializable]
public class SpecialMissionRewardRequest
{
	public int _specialMissionId;

	public List<int> _criteriaValueNormalList;

	public List<int> _criteriaValuePremiumList;
}
