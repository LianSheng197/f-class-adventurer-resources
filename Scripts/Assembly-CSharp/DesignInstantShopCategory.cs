using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignInstantShopCategory")]
public class DesignInstantShopCategory : TableBase
{
	public enum eCondition
	{
		None = 0,
		LevelUp = 1,
		StageFirstClear = 2,
		Size = 3
	}

	[Serializable]
	public class Data
	{
		public int _id;

		public int _remainTimeMinutes;

		public List<int> _productList;

		public int _condition;

		public List<int> _conditionValue;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<eCondition, List<Data>> _dicDataByCondition;

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

	public List<Data> CreateShop(eCondition condition, params int[] valueList)
	{
		return null;
	}
}
