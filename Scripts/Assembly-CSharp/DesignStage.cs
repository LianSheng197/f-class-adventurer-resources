using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignStage")]
public class DesignStage : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Condition
		{
			None = 0,
			Fame = 1,
			FameBan = 2,
			Attribute = 3,
			AttributeBan = 4,
			Nation = 5,
			NationBan = 6,
			WorldId = 1001,
			TeamLevel = 1002,
			TowerLevel = 1003
		}

		public enum RespawnType
		{
			Normal = 0,
			Continual_Respawn = 1
		}

		public int _id;

		public int _worldId;

		public int _name;

		public int _description;

		public int _stage;

		public float _startingPositionX;

		public float _startingPositionY;

		public SpriteData _sprite;

		public string _battleBG;

		public int _attribute;

		public int _enemyPlusLevel;

		public long _rewardTeamExp;

		public List<int> _rewardItemType;

		public List<long> _rewardItemValue;

		public List<int> _rewardItemSeed;

		public List<int> _rewardCount;

		public List<int> _rewardCountSeed;

		public List<int> _firstRewardItemType;

		public List<long> _firstRewardItemValue;

		public List<int> _getArtifact;

		public List<int> _openStage;

		public Condition _startCondition;

		public int _startConditionValue;

		public List<int> _addSkillId;

		public RespawnType _respawnType;

		public int _respawnPositionType;

		public List<int> _respawnTime;

		public List<int> _respawnCharacterGroup;

		public List<int> _respawnCharacterGroupSeed;

		public int _defaultGroupCount;

		public float _groupAddTime;

		public int _bossRespawnPositionType;

		public int _bossCharacterId;

		public double _minBattlePoint;

		public int _victoryTime;

		public int _victoryKill;

		public float _pointMultiply;

		public double _damageProgressbar;

		public int _accessRewardCount;

		public float _accessRewardPercentage;

		public string _scenario;

		public int plusTreasureCount;

		public DesignWorld.Data GetDesignWorld()
		{
			return null;
		}

		public List<ItemReward> GetRewardList()
		{
			return null;
		}

		public List<ItemReward> GetBossRewardList()
		{
			return null;
		}

		public List<ItemReward> GetBossRandomRewardList()
		{
			return null;
		}

		public int NextOpenStageId()
		{
			return 0;
		}

		public string GetWorldName(DesignWorld.Data designWorld = null)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _dicDataWorld;

	public Dictionary<int, Dictionary<int, List<int>>> _dicOpenStageData;

	public Dictionary<int, int> _dicOpenNextWorldData;

	public Dictionary<int, List<DesignArtifact.Data>> _dicArtifactList;

	public List<Tuple<int, int, int>> _fieldBossData;

	public Dictionary<string, int> _scenarioData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public override void GlobalCalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetStage(int worldId, int stage)
	{
		return null;
	}

	public int GetLastStage(int worldId)
	{
		return 0;
	}

	public Dictionary<int, Data> GetDataFromWorld(int worldId)
	{
		return null;
	}

	public List<Data> FindStage(int startId, int endId)
	{
		return null;
	}

	public List<Data> GetNextStage(int worldId, int stage)
	{
		return null;
	}

	public int NextWorldId(int worldId)
	{
		return 0;
	}

	public List<DesignArtifact.Data> GetArtifactList(int worldId)
	{
		return null;
	}

	public int GetScenarioStageId(string scenario)
	{
		return 0;
	}
}
