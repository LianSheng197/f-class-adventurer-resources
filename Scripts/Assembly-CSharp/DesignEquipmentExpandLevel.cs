using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignEquipmentExpandLevel")]
public class DesignEquipmentExpandLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _expandLevelType;

		public int _expandLevel;

		public int _maxLevel;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public float _multiplyValue;

		public float _levelUpPriceMultiplyValue;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}

		public Data Before()
		{
			return null;
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

	public Data GetData(int expandLevelType, int expandLevel)
	{
		return null;
	}

	public int MaxExpandLevel(int expandLevelType)
	{
		return 0;
	}

	public int MaxLevel(int expandLevelType, int expandLevel)
	{
		return 0;
	}

	public Dictionary<int, Data> GetExpandLevelList(int expandLevelType)
	{
		return null;
	}
}
