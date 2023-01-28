using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCardEvent")]
public class DesignCardEvent : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Type
		{
			None = 0,
			CardEvent = 1,
			CardSelectEvent = 2,
			Max = 3
		}

		public int id;

		public int page;

		public Type type;

		public int order;

		public int buttonLanguage;

		public int titleLanguage;

		public string startDate;

		public string endDate;

		public int changeNeedItemType;

		public int changeNeedItemValue;

		public int needItemType;

		public int needItemValue;

		public List<int> itemType;

		public List<long> itemValue;

		public List<int> itemSeed;

		public List<int> itemLimitCount;

		public int mailId;

		public DateTime _startDate;

		public DateTime _endDate;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public void CalcData()
		{
		}

		public void SetRootData(Data root)
		{
		}
	}

	public List<Data> _data;

	public Dictionary<int, Dictionary<int, Data>> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void GlobalCalcData()
	{
	}

	public override void CalcData()
	{
	}

	public Dictionary<int, Data> GetData(int id)
	{
		return null;
	}

	public Data GetData(int id, int page)
	{
		return null;
	}

	public int GetMaxPage(int id)
	{
		return 0;
	}

	public List<Data> GetActiveList()
	{
		return null;
	}
}
