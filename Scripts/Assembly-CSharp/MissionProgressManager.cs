using System;
using System.Collections.Generic;
using UnityEngine;

public class MissionProgressManager : MonoBehaviour
{
	private static MissionProgressManager _Instance;

	private static Type _lastestUpdateCallClass;

	private static float _time;

	private const float delaySecond = 60f;

	public bool _isForce;

	private MissionListManager _missionListManager;

	private Dictionary<int, MissionProgressData> _missionProgressReq;

	private Dictionary<int, AchievementData> _achievementProgressReq;

	public bool _bStop;

	private List<UpgradeData> _upgradeDataList;

	private static DesignGuideMission _designGM;

	private static DesignUpdateGuideMission _designUGM;

	public static MissionProgressManager Instance => null;

	public void UpdateProgress()
	{
	}

	public void Init()
	{
	}

	public static void DestroyObj()
	{
	}

	private Type GetCallClass()
	{
		return null;
	}

	public void AddMissionProgress(DesignCriteria.Data.TYPE criteriaType, long addValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddMissionProgressList(DesignCriteria.Data.TYPE criteriaType, long addValue, int condition1, int condition2)
	{
	}

	public void AddMissionProgressSingle(int missionGroupId, int missionListId, long addValue = 1L, int condition1 = 0, int condition2 = 0, bool isFix = false)
	{
	}

	public void AddFixMissionProgress(DesignCriteria.Data.TYPE criteriaType, List<long> values)
	{
	}

	public void AddFixMissionProgress(DesignCriteria.Data.TYPE criteriaType, long curValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddFixMissionProgressList(DesignCriteria.Data.TYPE criteriaType, long curValue, int condition1, int condition2)
	{
	}

	private void AddAchievementProgressList(DesignCriteria.Data.TYPE criteriaType, long addValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddAchievementProgressSingle(DesignAchievement.Data designAchievement, long addValue = 1L, int condition1 = 0, int condition2 = 0, bool isFix = false)
	{
	}

	private bool CheckSlowAchievement(int criteriaType)
	{
		return false;
	}

	public void AddAchievementProgressSingle(int achievementId, long addValue = 1L, int condition1 = 0, int condition2 = 0, bool isFix = false)
	{
	}

	private void AddFixAchievementProgressList(DesignCriteria.Data.TYPE criteriaType, long curValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddGuideMissionProgressSingle(DesignCriteria.Data.TYPE criteriaType, long addValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddFixGuideMissionProgressList(DesignCriteria.Data.TYPE criteriaType, long curValue, int condition1, int condition2)
	{
	}

	public void AddUpdateGuideMissionProgressSingle(DesignCriteria.Data.TYPE criteriaType, long addValue = 1L, int condition1 = 0, int condition2 = 0)
	{
	}

	public void AddFixUpdateGuideMissionProgressList(DesignCriteria.Data.TYPE criteriaType, long curValue, int condition1, int condition2)
	{
	}

	public void UpdateItemMission(Dictionary<int, long> diffItemList)
	{
	}

	public void UpdateEquipItemMission(Dictionary<int, long> diffItemList)
	{
	}

	private void UpdateEquipCountMission(DesignCriteria.Data.TYPE criteriaType)
	{
	}

	private void UpdateEquipLevelMission(DesignCriteria.Data.TYPE criteriaType)
	{
	}

	public void UpdateMissionFixProgress(DesignCriteria.Data.TYPE criteriaType, bool isForce = false)
	{
	}

	public void UpdateMissionFixProgressList(List<DesignCriteria.Data.TYPE> criteriaTypeList, bool isQuickUpdate = false)
	{
	}

	public void UpdateCheckTower()
	{
	}

	public void UpdateCheckBoss()
	{
	}

	public void UpdateCheckEventTower()
	{
	}

	public void UpdateCheckEventBoss()
	{
	}

	public void UpdateCheckGuildBoss()
	{
	}

	public void UpdateCheckNormalStageClear()
	{
	}

	public void UpdateCheckNormalStage()
	{
	}

	public void UpdateCheckWorld()
	{
	}

	public void UpdateLoginDayMission()
	{
	}

	public void UpdateSkillMission(Dictionary<int, Skill> skillList)
	{
	}

	private void LowLevelUp(ref Dictionary<int, long> levelList, int needLevel, long count = 1L)
	{
	}

	private void LowLevelinMaxValue(ref Dictionary<int, long> levelList, int needLevel, long count = 1L)
	{
	}

	public void UpdateRelicMission(Dictionary<int, Relic> _relicList)
	{
	}

	public void UpdateLegendMission(Dictionary<int, Legend> legendList)
	{
	}

	public void UpdatePowerStoneMission(Dictionary<int, PowerStone> powerStoneList)
	{
	}

	public bool IsRemainProgressQueue()
	{
		return false;
	}

	public void Clear()
	{
	}

	private void Req()
	{
	}

	public void ReqMissionList(List<int> rewardSyncList = null)
	{
	}

	public void ReqAchievement(List<int> rewardSyncList = null)
	{
	}

	public void ReqGuideMission(bool isRewardSync = false)
	{
	}

	public void ReqUpdateGuideMission(bool isRewardSync = false)
	{
	}

	public void MissionTest()
	{
	}
}
