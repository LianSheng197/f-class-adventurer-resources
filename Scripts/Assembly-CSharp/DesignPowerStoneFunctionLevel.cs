using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignPowerStoneFunctionLevel")]
public class DesignPowerStoneFunctionLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _powerStoneFunctionType;

		public int _functionLevel;

		public int _seed;

		public double _contentsFunctionValue;

		public Data GetNext()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _levelData;

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

	public Data GetData(int powerStoneFunctionType, int functionLevel)
	{
		return null;
	}
}
