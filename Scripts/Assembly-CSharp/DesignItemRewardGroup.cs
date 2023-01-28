using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignItemRewardGroup")]
public class DesignItemRewardGroup : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _groupId;

		public int _itemId;

		public long _itemValue;

		public int _itemSeed;

		public bool _fakeFlag;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicGroupData;

	public Dictionary<int, Dictionary<int, Data>> _dicGroupItemIdData;

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

	public List<Data> FindGroup(int groupId)
	{
		return null;
	}

	public Data IsExistItemId(int groupId, int itemId)
	{
		return null;
	}

	public void GetRandomList(int groupId, int count, int rewardItemId, ref List<Data> fakes, ref List<Data> others)
	{
	}
}
