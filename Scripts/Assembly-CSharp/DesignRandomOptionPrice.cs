using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRandomOptionPrice")]
public class DesignRandomOptionPrice : TableBase
{
	[Serializable]
	public class Data
	{
		public int randomOptionPriceType;

		public int holdCount;

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

	public Dictionary<int, Data> GetData(int randomOptionPriceType)
	{
		return null;
	}

	public Data GetData(int randomOptionPriceType, int holdCount)
	{
		return null;
	}
}
