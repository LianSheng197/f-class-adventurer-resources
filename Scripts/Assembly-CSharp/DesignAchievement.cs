using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignAchievement")]
public class DesignAchievement : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _order;

		public CriteriaData _criteriaData;

		public int _rewardItemType;

		public long _rewardItemValue;

		public int _stepGroup;

		public int _step;

		public int _category;

		public int _repetition;

		public int _replay;

		public DesignCriteria.Data GetDesignCriteria()
		{
			return null;
		}

		public List<ItemReward> GetRewardList(long x = 1L)
		{
			return null;
		}

		public bool CheckCondition(int condition1 = 0, int condition2 = 0)
		{
			return false;
		}

		public Data GetNextStep()
		{
			return null;
		}

		public Data GetPrevStep()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicStepGroupData;

	public Dictionary<int, List<Data>> _dicCriteriaData;

	public Dictionary<int, List<int>> _dicCategoryData;

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

	public List<Data> GetStepGroup(int stepGroup)
	{
		return null;
	}

	public Data GetStep(int stepGroup, int step)
	{
		return null;
	}

	public Data GetPrevStep(int achievement_id)
	{
		return null;
	}

	public Data GetNextStep(int achievement_id)
	{
		return null;
	}

	public List<Data> GetMissionListFromCriteria(int criteriaType)
	{
		return null;
	}

	public List<int> GetCategoryGroupList(int category)
	{
		return null;
	}

	public List<Data> GetDaliyList()
	{
		return null;
	}
}
