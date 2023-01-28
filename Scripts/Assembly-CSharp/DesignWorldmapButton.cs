using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignWorldmapButton")]
public class DesignWorldmapButton : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Condition
		{
			None = 0,
			TeamLevel = 1,
			Stage = 2
		}

		public int _id;

		public SpriteData _sprite;

		public int _name;
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
