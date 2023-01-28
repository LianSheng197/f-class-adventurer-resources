using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterUpgrade")]
public class DesignCharacterUpgrade : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _type;

		public int _grade;

		public int _maxLevel;

		public int _plusStat;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public Dictionary<int, long> _needItem;

		public int GetNeedLevel()
		{
			return 0;
		}

		public void CalcData()
		{
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _upgradeData;

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

	public Data GetData(int type, int grade)
	{
		return null;
	}

	public int GetMax(int type)
	{
		return 0;
	}

	public int FindGrade(int type, int level)
	{
		return 0;
	}

	public int FindMaxLevel(int type)
	{
		return 0;
	}
}
