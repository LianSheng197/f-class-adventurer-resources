using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRandomOptionMagic")]
public class DesignRandomOptionMagic : TableBase
{
	[Serializable]
	public class Data
	{
		public int id;

		public int randomOptionType;

		public int magicGrade;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int seed;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<Data>> _dicTypeData;

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

	public List<Data> FindList(int randomOptionType)
	{
		return null;
	}
}
