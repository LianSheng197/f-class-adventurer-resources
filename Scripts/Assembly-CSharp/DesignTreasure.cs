using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignTreasure")]
public class DesignTreasure : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int name;

		public SpriteData _sprite;

		public SpriteData _background;

		public int needTreasureCount;

		public int makeSeed;

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

	public int GetCount()
	{
		return 0;
	}

	public Data GetRandom(int treasureCount, List<int> skipIds)
	{
		return null;
	}
}
