using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterEnchant")]
public class DesignCharacterEnchant : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _type;

		public int _enchantLevel;

		public List<int> _needItemType;

		public List<ContentsFunctionData> _needItemContentsFunction;

		public List<ContentsFunctionData> _contentsFunction;
	}

	public const int _equipSlot = 6;

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _enchantData;

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

	public Data GetData(int type, int enchant)
	{
		return null;
	}

	public int GetMax(int type)
	{
		return 0;
	}
}
