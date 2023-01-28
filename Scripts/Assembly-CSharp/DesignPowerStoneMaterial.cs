using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignPowerStoneMaterial")]
public class DesignPowerStoneMaterial : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _slot;

		public int _step;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}

		public Data GetNext()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _stepData;

	public List<int> _needTypeList;

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

	public Data GetData(int slot, int step)
	{
		return null;
	}

	public int GetStepCount(int slot)
	{
		return 0;
	}
}
