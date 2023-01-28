using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignDeleteItemSchedule")]
public class DesignDeleteItemSchedule : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public string _strDate;

		public DateTime _date;

		public List<int> _deleteItem;

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

	public List<int> GetDeleteItems(DateTime curTime, DateTime lastCheckTime)
	{
		return null;
	}

	public TimeSpan GetRemainTime(int itemId, DateTime curTime, DateTime lastCheckTime)
	{
		return default(TimeSpan);
	}
}
