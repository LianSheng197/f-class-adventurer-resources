using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignGachaLevelBonus")]
public class DesignGachaLevelBonus : TableBase
{
	[Serializable]
	public class Data
	{
		public int gachaIndex;

		public List<int> itemId;

		public List<long> itemValue;

		public Dictionary<int, long> _rewardItem;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public void CalcData()
		{
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
