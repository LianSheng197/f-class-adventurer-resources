using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignLegendGrade")]
public class DesignLegendGrade : TableBase
{
	[Serializable]
	public class Data
	{
		public int _legendGrade;

		public int _name;

		public SpriteData _backGround;

		public float _battlePointValue;

		public Color _textColor;
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

	public Data GetData(int legendGrade)
	{
		return null;
	}
}
