using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignGuildBossRank")]
public class DesignGuildBossRank : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _name;

		public double _point_DECIMAL;

		public string _point_String;

		public int _rewardItemType;

		public long _rewardItemValue;

		public Color _textGradientTop;

		public Color _textGradientBottom;
	}

	public List<Data> _dataByDescendingPoint;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void CalcData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetDataByPointBounded(double point_DECIMAL)
	{
		return null;
	}
}
