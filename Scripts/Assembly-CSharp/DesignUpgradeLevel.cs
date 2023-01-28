using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignUpgradeLevel")]
public class DesignUpgradeLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _levelupType;

		public int _level;

		public float _multiplyValue;

		public long _refundValue;

		public int _needItemType;

		public long _needItemValue;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _levelData;

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

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetData(int type, int level)
	{
		return null;
	}

	public Data FindMaxLevel(int type)
	{
		return null;
	}
}
