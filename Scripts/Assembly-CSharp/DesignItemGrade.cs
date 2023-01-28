using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignItemGrade")]
public class DesignItemGrade : TableBase
{
	[Serializable]
	public class Data
	{
		public int _itemGrade;

		public int _name;

		public Color _textColor;

		public int _gradeJump_1;

		public int _gradeJump_2;

		public int _gradeJump_3;
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

	public Data GetData(int itemGrade)
	{
		return null;
	}
}
