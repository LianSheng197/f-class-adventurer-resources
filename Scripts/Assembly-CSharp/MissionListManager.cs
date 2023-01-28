using System.Collections.Generic;

public class MissionListManager
{
	private static MissionListManager _Instance;

	private List<MissionData> _missionDataList;

	private Dictionary<int, List<MissionProgressData>> _missionProgressList;

	private Dictionary<int, AchievementData> _achievementProgressList;

	private static DesignMissionList _designML;

	private static DesignAchievement _designAchievement;

	public static MissionListManager Instance => null;

	public void Clear()
	{
	}

	public void SetMissionList(List<MissionData> missionDataList)
	{
	}

	public void SetMission(MissionData missionData)
	{
	}

	public MissionData GetMission(int missionId)
	{
		return null;
	}

	public void SetMissionProgress(MissionProgressData missionProgressData)
	{
	}

	public List<MissionProgressData> GetMissionProgressList(int missionId)
	{
		return null;
	}

	public MissionProgressData GetMissionProgress(int missionListId)
	{
		return null;
	}

	public MissionProgressData GetMissionProgress(int missionId, int missionListId)
	{
		return null;
	}

	public MissionProgressData UpdateMissionProgress(int missionId, int missionListId, long addVal, bool isFix = false)
	{
		return null;
	}

	public bool CheckDailyMissionList()
	{
		return false;
	}

	public bool CheckDailyAchievementList()
	{
		return false;
	}

	public List<MissionData> GetMissionList()
	{
		return null;
	}

	public List<DesignMissionList.Data> GetMissionListFromCriteria(DesignCriteria.Data.TYPE criteriaType)
	{
		return null;
	}

	public List<DesignAchievement.Data> GetAchievementFromCriteria(DesignCriteria.Data.TYPE criteriaType)
	{
		return null;
	}

	public void SetAchievement(AchievementData achievementProgress)
	{
	}

	public AchievementData GetAchievement(int stepGroup)
	{
		return null;
	}

	public List<AchievementData> GetAchievementRewardOpenList(int category)
	{
		return null;
	}

	public bool IsNewAchievementReward()
	{
		return false;
	}

	public AchievementData GetAchievementWithStepGroup(int stepGroup)
	{
		return null;
	}

	public AchievementData GetAchievementWithStepGroupLastStep(int stepGroup)
	{
		return null;
	}

	public AchievementData MakeEmptyAchievement(int stepGroup)
	{
		return null;
	}

	private AchievementData MakeEmptyAchievement(DesignAchievement.Data designAchievement)
	{
		return null;
	}

	public bool CheckMissionRewardOpen(EventList.buttonType buttonType)
	{
		return false;
	}

	public bool CheckMissionRewardOpen(int missionId)
	{
		return false;
	}

	public bool CheckMissionCompleted(int missionId)
	{
		return false;
	}

	public bool CheckAchievementRewardOpen()
	{
		return false;
	}

	public bool CheckAchievementRewardOpen(int category)
	{
		return false;
	}
}
