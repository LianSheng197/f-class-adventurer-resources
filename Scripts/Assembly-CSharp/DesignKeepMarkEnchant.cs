using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignKeepMarkEnchant")]
public class DesignKeepMarkEnchant : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int keepMarkType;

		public int level;

		public List<int> needItemType;

		public List<long> needItemValue;

		public int successRate;

		public int plusSuccessRate;

		public float multiplyValue;

		public Dictionary<int, long> _needItem;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public void CalcData()
		{
		}

		public Data Next()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Dictionary<int, Data>> _dicData;

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

	public Dictionary<int, Data> GetData(int type)
	{
		return null;
	}

	public Data GetData(int type, int level)
	{
		return null;
	}
}
