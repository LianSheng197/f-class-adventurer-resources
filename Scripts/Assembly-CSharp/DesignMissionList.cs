using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignMissionList")]
public class DesignMissionList : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _missionId;

		public CriteriaData _criteriaData;

		public int _rewardItemType;

		public long _rewardItemValue;

		public DesignCriteria.Data GetDesignCriteria()
		{
			return null;
		}

		public List<ItemReward> GetRewardList()
		{
			return null;
		}

		public bool CheckCondition(int condition1 = 0, int condition2 = 0)
		{
			return false;
		}

		public DesignMission.Data GetDesignMission()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicMissionData;

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

	public List<Data> GetMissionListFromCriteria(int criteriaType)
	{
		return null;
	}

	public List<Data> GetMissionListFromCriteria(int missionGroupId, int criteriaType)
	{
		return null;
	}

	public List<CriteriaData> GetCriteriaDataList(DesignCriteria.Data.TYPE criteriaType)
	{
		return null;
	}

	public List<Data> GetMissionListWithMissionId(int missionId)
	{
		return null;
	}
}
