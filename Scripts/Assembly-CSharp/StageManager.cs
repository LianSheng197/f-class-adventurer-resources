using System;
using System.Collections.Generic;
using UnityEngine;

public class StageManager
{
	public class ScheduleData
	{
		public DesignWorld.Data _designWorld;

		public bool _isActive;

		public DateTime _pivotTime;

		public TimeSpan _sp;

		public GameObject _object;
	}

	public class ClearStageData
	{
		public enum ClearType
		{
			Clear_Stage = 0,
			Attribute_Stage = 1,
			Victory_Type_Stage = 2
		}

		private Dictionary<ClearType, Dictionary<int, int>> _clearStageList;

		public void UpdateData(Dictionary<int, Dictionary<int, Stage>> stage)
		{
		}

		public void AddClearStageData(int worldId, Dictionary<int, Stage> stageDataList, ClearType clearType)
		{
		}

		public void AddClearStageData(Stage stageData, ClearType clearType)
		{
		}

		public Dictionary<int, int> GetClearType(ClearType clearType)
		{
			return null;
		}

		public int GetClearType(ClearType clearType, int key)
		{
			return 0;
		}
	}

	private static StageManager _Instance;

	private Dictionary<int, Dictionary<int, Stage>> _stage;

	private Dictionary<DesignWorld.Data.WorldMapType, List<int>> _clearNormalWorld;

	private Dictionary<int, StageReward> _stageReward;

	private List<ContentsFunctionData> _contentsFunctionData;

	public int _playStageId;

	public int _lastPlayStageId;

	public List<int> _trialNewData;

	public bool _isFirstClear;

	private List<int> _normalWorldOpenAlert;

	private ClearStageData _clearStageData;

	public DateTime _stageStatUpdateTime;

	public long _totalUser;

	private Dictionary<int, Dictionary<int, StatGetStage>> _stageStat;

	public static StageManager Instance => null;

	public void SetStageRewardList(List<StageReward> list)
	{
	}

	public void SetStageReward(int stageId)
	{
	}

	public StageReward GetStageReward(int stageId)
	{
		return null;
	}

	public void SetStageList(List<Stage> list, bool withClear)
	{
	}

	public void SetStage(Stage data, bool contentsFunctionDataUpdate = false)
	{
	}

	public Stage GetStage(int worldId, int stage)
	{
		return null;
	}

	public Dictionary<int, Stage> GetStage(int worldId)
	{
		return null;
	}

	public Stage GetStage(DesignStage.Data designStage)
	{
		return null;
	}

	public bool IsClearStage(int stageId)
	{
		return false;
	}

	public List<int> GetClearNormalWorld(DesignWorld.Data.WorldMapType worldMapType)
	{
		return null;
	}

	public int GetMaxClearNormalWorld(DesignWorld.Data.WorldMapType worldMapType)
	{
		return 0;
	}

	private void UpdateContentsFunction()
	{
	}

	public void GetTrialTowerContentsFunctionData(ref List<ContentsFunctionData> list)
	{
	}

	public void GetPromotionContentsFunctionData(ref List<ContentsFunctionData> list)
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public int GetLastStage(int worldId)
	{
		return 0;
	}

	public int GetStageClearCount(int worldId, int stage)
	{
		return 0;
	}

	public Stage GetMaxClearStage(int worldId)
	{
		return null;
	}

	public Dictionary<int, Dictionary<int, Stage>> GetClearList(DesignWorld.Data.WorldMapType worldMapType)
	{
		return null;
	}

	public bool IsActive(int worldId)
	{
		return false;
	}

	public bool IsActive(int worldId, int stage)
	{
		return false;
	}

	public bool IsCurrent(int worldId, int stage)
	{
		return false;
	}

	public bool IsOpen(DesignStage.Data designStage)
	{
		return false;
	}

	public bool IsOpenNormal(DesignStage.Data designStage)
	{
		return false;
	}

	public bool IsClear(DesignStage.Data design)
	{
		return false;
	}

	public bool IsClear(int worldId, int stage)
	{
		return false;
	}

	public int IsClearCount(int worldId)
	{
		return 0;
	}

	public bool IsClearWorld(int worldId)
	{
		return false;
	}

	public bool IsEventWorld()
	{
		return false;
	}

	public int GetFistEventStageStage()
	{
		return 0;
	}

	public bool AlertWorld(DesignWorld.Data.WorldMapType worldMapType)
	{
		return false;
	}

	public bool GetRemainTime(int worldId, out DateTime endTime, out TimeSpan ts)
	{
		endTime = default(DateTime);
		ts = default(TimeSpan);
		return false;
	}

	public bool GetRemainTime(int worldId, out double percent)
	{
		percent = default(double);
		return false;
	}

	public string GetRemainTimeString(int worldId)
	{
		return null;
	}

	public void CalcClearStageData()
	{
	}

	public ClearStageData GetClearStageData()
	{
		return null;
	}

	public bool IsTrialNew(int worldId = -1)
	{
		return false;
	}

	public void UpdateTrialNew()
	{
	}

	public void SetStageStat(List<StatGetStage> list)
	{
	}

	public StatGetStage GetStageStat(int worldId, int stageId)
	{
		return null;
	}

	public List<ScheduleData> GetActiveWorldList(DesignWorld.Data.WorldMapType worldMapType)
	{
		return null;
	}

	public int GetLastPlayStage()
	{
		return 0;
	}

	public int GetNormalLastPlayStage(DesignWorld.Data.NormalWorldType type)
	{
		return 0;
	}

	public void SetLastPlayStage(int stageId)
	{
	}

	public void BackLastPlayStage()
	{
	}

	public bool IsOpenCharacteristic()
	{
		return false;
	}

	public bool IsOpenTreasure()
	{
		return false;
	}

	public bool IsOpenAccessory()
	{
		return false;
	}

	public bool IsOpenCharm()
	{
		return false;
	}

	public bool IsOpenDungeon()
	{
		return false;
	}

	private bool IsClearScenario(string scenario)
	{
		return false;
	}

	public void InitNormalWorldOpenAlert()
	{
	}

	public void SaveNormalWorldOpenAlert(DesignWorld.Data.NormalWorldType type)
	{
	}

	public bool IsNormalWorldOpenAlert(DesignWorld.Data.NormalWorldType type)
	{
		return false;
	}

	public bool IsOpenNormalWorld(DesignWorld.Data.NormalWorldType type)
	{
		return false;
	}

	public int GetTreasureCount()
	{
		return 0;
	}

	public bool IsPromotionNew()
	{
		return false;
	}
}
