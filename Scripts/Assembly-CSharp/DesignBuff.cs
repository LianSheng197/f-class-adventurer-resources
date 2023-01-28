using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignBuff")]
public class DesignBuff : TableBase
{
	[Serializable]
	public class Data
	{
		public enum BuffType
		{
			Buff = 0,
			DeBuff = 1,
			Invincible = 2
		}

		public int _id;

		public BuffType _buffType;

		public int _buffEffect;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, List<int>> _dicOpenWorldData;

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
