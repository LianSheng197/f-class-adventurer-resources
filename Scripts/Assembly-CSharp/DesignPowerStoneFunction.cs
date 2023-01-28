using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignPowerStoneFunction")]
public class DesignPowerStoneFunction : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _name;

		public SpriteData _sprite;

		public int _contentsFunctionType;

		public int _contentsFunctionCondition;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public DesignPowerStoneFunctionLevel.Data GetPowerStoneFunctionLevel(int level)
		{
			return null;
		}

		public List<ContentsFunctionData> GetContentsFunction(int level)
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

	public Data GetData(int id)
	{
		return null;
	}
}
