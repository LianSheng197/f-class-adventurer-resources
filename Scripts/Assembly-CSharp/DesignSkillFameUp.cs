using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillFameUp")]
public class DesignSkillFameUp : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _fameUpType;

		public int _fame;

		public int _plusNeedMp;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public int _maxLevel;

		public List<ContentsFunctionData> _contentsFunctionData;

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

	public Dictionary<int, Dictionary<int, Data>> _fameData;

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

	public Data GetData(int fameUpType, int fame)
	{
		return null;
	}

	public int MaxFameUp(int fameUpType)
	{
		return 0;
	}

	public int MaxLevel(int fameUpType, int fame)
	{
		return 0;
	}
}
