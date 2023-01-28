using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignMission")]
public class DesignMission : TableBase
{
	[Serializable]
	public class Data
	{
		public enum ConditionType
		{
			All = 1,
			NewUser = 2,
			ReturnUser = 3
		}

		public int _id;

		public string _strStartDate;

		public string _strEndDate;

		public int _conditionType;

		public int _conditionValue;

		public int _order;

		public int _buttonName;

		public int _name;

		public bool _replay;

		public int _stepGroup;

		public int _step;

		public DateTime _startDate;

		public DateTime _endDate;

		public SpriteData _sprite;

		public int _location;

		public string _prefabName;

		public string _rewardPrefabName;

		public int _mailBoxID;

		public void CalcData()
		{
		}

		public bool IsOpenTime(DateTime curTime)
		{
			return false;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicStepGroupData;

	public override void ClearData()
	{
	}

	public override void CalcData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetPrevStep(int mission_id)
	{
		return null;
	}

	public Data GetNextStep(int mission_id)
	{
		return null;
	}

	public List<Data> GetMissionListGroup(int stepGroup)
	{
		return null;
	}

	public List<Data> GetMissionList()
	{
		return null;
	}

	public List<Data> GetMissionList(CUser user)
	{
		return null;
	}

	public List<Data> GetDailyMissionList(CUser user)
	{
		return null;
	}

	private int SortMission(Data a, Data b)
	{
		return 0;
	}
}
