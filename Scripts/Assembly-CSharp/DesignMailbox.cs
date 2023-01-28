using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignMailbox")]
public class DesignMailbox : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _addresser;

		public int _description;

		public int _time;

		public int _minLevel;
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

	public Data GetData(int id)
	{
		return null;
	}
}
