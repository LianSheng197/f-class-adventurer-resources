using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRandomOptionMagicGrade")]
public class DesignRandomOptionMagicGrade : TableBase
{
	[Serializable]
	public class Data
	{
		public int randomOptionMagicGrade;

		public int name;

		public string textColor;

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

	public Data GetData(int randomOptionMagicGrade)
	{
		return null;
	}
}
