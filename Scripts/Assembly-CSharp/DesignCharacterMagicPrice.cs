using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterMagicPrice")]
public class DesignCharacterMagicPrice : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _magicType;

		public int _holdCount;

		public List<int> _needItemType;

		public List<long> _needItemValue;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicMagicTypeData;

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

	public List<Data> GetMagicTypeData(int magicType)
	{
		return null;
	}

	public Data GetMagicTypeData(int magicType, int holdCount)
	{
		return null;
	}
}
