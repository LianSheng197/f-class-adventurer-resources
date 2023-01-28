using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacteristic")]
public class DesignCharacteristic : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int name;

		public SpriteData _sprite;

		public int x;

		public int y;

		public int connectLine;

		public int levelUpType;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

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
}
