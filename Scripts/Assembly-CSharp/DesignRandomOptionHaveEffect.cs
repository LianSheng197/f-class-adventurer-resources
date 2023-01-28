using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRandomOptionHaveEffect")]
public class DesignRandomOptionHaveEffect : TableBase
{
	[Serializable]
	public class Data
	{
		public int randomOptionHaveEffectType;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int openCondition;

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

	public Data GetData(int randomOptionHaveEffectType)
	{
		return null;
	}
}
