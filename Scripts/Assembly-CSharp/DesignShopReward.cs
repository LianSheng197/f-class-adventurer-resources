using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShopReward")]
public class DesignShopReward : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _shopId;

		public int _rewardDay;

		public List<int> _rewardItemType;

		public List<long> _rewardItemValue;

		public int _mailId;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _dicDataFormShopId;

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

	public Dictionary<int, Data> GetShopReward(int shopId)
	{
		return null;
	}

	public Data GetShopReward(int shopId, int rewardDay)
	{
		return null;
	}

	public int GetMaxRewardDay(int shopId)
	{
		return 0;
	}
}
