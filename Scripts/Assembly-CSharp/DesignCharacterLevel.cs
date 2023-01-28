using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterLevel")]
public class DesignCharacterLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _type;

		public int _level;

		public int _grade;

		public int _plusStat;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Dictionary<int, Data>>> _levelData;

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

	public Data GetData(int type, int grade, int level)
	{
		return null;
	}
}
