using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignProhibitedWordsChat")]
public class DesignProhibitedWordsChat : TableBase
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

	public string CheckProhibitedWords(string check)
	{
		return null;
	}
}
