using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignTreasurePrice")]
public class DesignTreasurePrice : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int treasureCount;

		public List<int> needItemType;

		public List<long> needItemValue;

		public Dictionary<int, long> _needItem;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public void CalcData()
		{
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public List<int> _needTypeList;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int treasureCount)
	{
		return null;
	}
}
