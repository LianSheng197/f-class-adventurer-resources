using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRelicLevel")]
public class DesignRelicLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _relicId;

		public int _level;

		public double _multiplyValue;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public float _needItemRubyValue;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}

		public Data Next()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _dicLevelData;

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

	public Data GetData(int relicId, int level)
	{
		return null;
	}

	public int GetMaxLevel(int relicId)
	{
		return 0;
	}
}
