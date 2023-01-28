using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignLegendFame")]
public class DesignLegendFame : TableBase
{
	[Serializable]
	public class Data
	{
		public int _legendFame;

		public int _name;

		public SpriteData _sprite;
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

	public Data GetData(int legendFame)
	{
		return null;
	}
}
