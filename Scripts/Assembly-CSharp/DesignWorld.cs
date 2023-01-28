using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignWorld")]
public class DesignWorld : TableBase
{
	[Serializable]
	public class Data
	{
		public enum WorldMapType
		{
			Normal = 1,
			Tower = 2,
			Boss = 3,
			GuildBoss = 4,
			BossScarecrow = 5,
			TrialTower = 8,
			Trial = 9,
			Promotion = 10,
			Normal2 = 11,
			Normal3 = 12,
			Dungeon = 13,
			Adventure = 21,
			Event = 99,
			EventTower = 100,
			EventBoss = 101,
			Scarecrow = 102,
			Max = 103
		}

		public enum NormalWorldType
		{
			Normal1 = 0,
			Normal2 = 1,
			Normal3 = 2,
			Max = 3
		}

		public int _id;

		public WorldMapType _worldMapType;

		public int _name;

		public SpriteData _sprite;

		public TextureData _background;

		public int _order;

		public float _posX;

		public float _posY;

		public int _openLevel;

		public int _openWorld;

		public int _clearLimit;

		public int _needItemType;

		public int _needItemValue;

		public int _rewardItemType;

		public int _rewardItemValue;

		public string _strStartDate;

		public string _strEndDate;

		public DateTime _startDate;

		public DateTime _endDate;

		public List<DayOfWeek> _openDayOfWeek;

		public string _strStartHour;

		public string _strEndHour;

		public List<DateHour> _startHour;

		public List<DateHour> _endHour;

		public List<int> _majorReward;

		public int _isRanking;

		public string _guideName;

		public string _scenario;

		public string _clearScenario;

		public string _openScenario;

		public int _rankingType;

		public int _rankingGroup;

		public int _eventDealRewardGroup;

		public int _skillEffectType;

		public void ConvertDateTime()
		{
		}

		public bool IsActiveTime(DateTime curTime, out int OutDayOfWeek, out DateHour OutStartHour, out DateHour OutEndHour)
		{
			OutDayOfWeek = default(int);
			OutStartHour = null;
			OutEndHour = null;
			return false;
		}

		private bool CheckDay(DateTime curTime, out int OutDayOfWeek)
		{
			OutDayOfWeek = default(int);
			return false;
		}

		private bool CheckHour(DateTime curTime, out DateHour OutStartHour, out DateHour OutEndHour)
		{
			OutStartHour = null;
			OutEndHour = null;
			return false;
		}

		public bool IsNormalWorld()
		{
			return false;
		}

		public NormalWorldType GetNormalWorldType()
		{
			return default(NormalWorldType);
		}

		public string GetNormalWorldTypeString()
		{
			return null;
		}

		public bool IsTimeWorld()
		{
			return false;
		}

		public bool IsEventWorld()
		{
			return false;
		}

		public bool IsAdventure()
		{
			return false;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<int>> _dicOpenWorldData;

	public Dictionary<Data.WorldMapType, List<Data>> _dicWorldMapType;

	public Dictionary<Data.NormalWorldType, int> _normalWorldFirstStage;

	public Dictionary<Data.NormalWorldType, int> _normalWorldIdCalc;

	public List<Data> _rankingWorldList;

	public List<int> _trialWorldIdList;

	public List<int> _trialTowerWorldIdList;

	public List<int> _promotionWorldIdList;

	public List<Data> _adventureWorldList;

	public Dictionary<string, int> _scenarioData;

	public Dictionary<string, int> _clearScenarioData;

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

	public List<int> FindOpenWorld(int worldId)
	{
		return null;
	}

	public void GetWorldIdRange(Data.WorldMapType worldMapType, out int minWorldId, out int maxWorldId)
	{
		minWorldId = default(int);
		maxWorldId = default(int);
	}

	public List<Data> GetWorldMapTypeList(Data.WorldMapType worldMapType)
	{
		return null;
	}

	public Data GetWorldRankingFirst()
	{
		return null;
	}

	public Data GetGuildBossWorld()
	{
		return null;
	}

	public int GetNormalFirstStage(Data.NormalWorldType type)
	{
		return 0;
	}

	public int CalcNormalId(Data.NormalWorldType type, int worldId)
	{
		return 0;
	}

	public int GetScenarioWorldId(string scenario)
	{
		return 0;
	}

	public int GetClearScenarioWorldId(string scenario)
	{
		return 0;
	}
}
