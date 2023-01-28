using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignGuideMission")]
public class DesignGuideMission : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _order;

		public CriteriaData _criteriaData;

		public int _rewardItemType;

		public long _rewardItemValue;

		public List<string> _step;

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
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

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

	public List<Data> GetDataFromCriteria(int criteriaType)
	{
		return null;
	}

	public Data GetNext(int id)
	{
		return null;
	}

	public int Sort(Data a, Data b)
	{
		return 0;
	}
}
