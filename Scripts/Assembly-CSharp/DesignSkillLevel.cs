using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillLevel")]
public class DesignSkillLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _levelUpType;

		public int _level;

		public List<int> _needItemType;

		public List<long> _needItemValue;

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

	public Data GetData(int levelupType, int level)
	{
		return null;
	}
}
