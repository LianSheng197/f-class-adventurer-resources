using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignAdsBuffLevel")]
public class DesignAdsBuffLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _levelType;

		public int _level;

		public int _needCount;

		public double _contentsFunctionValue;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _dicDataForLevel;

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

	public Data GetDataForExp(int levelType, int exp)
	{
		return null;
	}

	public Data GetDataForLevel(int levelType, int level)
	{
		return null;
	}

	public int GetRemainExp(int levelType, int exp)
	{
		return 0;
	}
}
