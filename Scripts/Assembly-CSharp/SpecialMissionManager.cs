using System.Collections.Generic;

public class SpecialMissionManager
{
	private Dictionary<int, SpecialMissionGroupData> _specialMissionGroupList;

	private Dictionary<int, Dictionary<int, SpecialMissionRewardData>> _specialMissionNormalRewardList;

	private Dictionary<int, Dictionary<int, SpecialMissionRewardData>> _specialMissionPremiumRewardList;

	private static DesignSpecialMission _designSM;

	private Dictionary<int, SpecialMissionData> _specialMissionReqList;

	public void Clear()
	{
	}

	public void AddSpecialMissionGroup(List<SpecialMissionGroupData> specialMissionGroupList)
	{
	}

	public void AddSpecialMissionGroup(SpecialMissionGroupData specialMissionGroup)
	{
	}

	public SpecialMissionGroupData GetSpecialMissionGroup(int specialMissionId)
	{
		return null;
	}

	public void AddSpecialMissionReward(List<SpecialMissionRewardData> specialMissionList)
	{
	}

	public Dictionary<int, SpecialMissionRewardData> GetSpecialMissionRewardData(int specialMissionId, bool isPremium)
	{
		return null;
	}

	public SpecialMissionRewardData GetSpecialMissionRewardData(int specialMissionId, int criteriaValue, bool isPremium)
	{
		return null;
	}

	public bool IsNew(int specialMissionId)
	{
		return false;
	}

	public void DoneNew(int specialMissionId)
	{
	}

	public bool IsNew()
	{
		return false;
	}

	public void CheckComplete()
	{
	}

	public bool IsCompleteGroup(int groupId)
	{
		return false;
	}

	public List<DesignSpecialMission.Data> GetMissionList()
	{
		return null;
	}

	public List<DesignSpecialMission.Data> GetMissionList(DesignCriteria.Data.TYPE criteriaType)
	{
		return null;
	}

	public void UpdateProgress(DesignCriteria.Data.TYPE criteriaType, long addCount = 1L, bool isFix = false)
	{
	}

	private void AddQueue(SpecialMissionData data)
	{
	}

	public void Req(SpecialMissionRewardRequest rewardReq = null)
	{
	}
}
