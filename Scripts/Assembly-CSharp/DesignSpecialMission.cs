using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSpecialMission")]
public class DesignSpecialMission : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public string _strStartDate;

		public string _strEndDate;

		public int _order;

		public int _buttonName;

		public int _description;

		public SpriteData _sprite;

		public int _criteriaType;

		public int _criteriaCondition;

		public string _criteriaValue;

		public string _rewardItemType;

		public string _rewardItemValue;

		public string _premiumRewardItemType;

		public string _premiumRewardItemValue;

		public int _stepGroup;

		public int _step;

		public string _strSellStartDate;

		public string _strSellEndDate;

		public DateTime _startDate;

		public DateTime _endDate;

		public DateTime _sellStartDate;

		public DateTime _sellEndDate;

		public void ConvertDateTime()
		{
		}

		public bool IsSellTime()
		{
			return false;
		}

		public bool IsBuy()
		{
			return false;
		}

		public List<RewardData> GetRewardDataList()
		{
			return null;
		}

		public Data GetPrevStepData()
		{
			return null;
		}

		public bool CheckCriteria(int criteriaValue, int criteriaCondition = 0)
		{
			return false;
		}

		public RewardData GetRewardData(int index)
		{
			return null;
		}

		public RewardData GetRewardDataByCriteriaValue(long criteriaValue)
		{
			return null;
		}
	}

	[Serializable]
	public class RewardData
	{
		public int _criteriaValue;

		public ItemReward _normalReward;

		public ItemReward _premiumReward;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<RewardData>> _dicRewardData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetData(int stepGroup, int step)
	{
		return null;
	}

	public List<Data> GetDataGroup(int stepGroup)
	{
		return null;
	}

	public List<Data> GetMissionList(DateTime now, bool isStepAll = false)
	{
		return null;
	}

	public List<RewardData> GetRewardDataList(int specialMissionId)
	{
		return null;
	}

	public RewardData GetRewardData(int specialMissionId, int index)
	{
		return null;
	}

	public RewardData GetRewardDataList(int specialMissionId, long criteriaValue)
	{
		return null;
	}
}
