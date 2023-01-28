using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignProhibitedWords")]
public class DesignProhibitedWords : TableBase
{
	[Serializable]
	public class Data
	{
		public string _value;
	}

	public List<Data> _data;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public bool CheckProhibitedWords(string check)
	{
		return false;
	}
}
