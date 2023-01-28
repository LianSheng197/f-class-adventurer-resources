using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignItemDetailType")]
public class DesignItemDetailType : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _itemDetailType;

		public int _name;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int itemDetailType)
	{
		return null;
	}
}
