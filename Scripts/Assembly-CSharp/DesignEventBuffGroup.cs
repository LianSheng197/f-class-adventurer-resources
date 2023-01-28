using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignEventBuffGroup")]
public class DesignEventBuffGroup : TableBase
{
	[Serializable]
	public class Data
	{
		public long _groupId;

		public bool _isActive;

		public bool _isInvisible;

		public int _orderNumber;

		public string _strStartTime;

		public string _strEndTime;

		public DateTime _startTime;

		public DateTime _endTime;

		public string _strNameList;

		public byte _dayOfWeek;

		public void ConvertDateTime()
		{
		}
	}

	public List<Data> _data;

	public Dictionary<long, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(long groupId)
	{
		return null;
	}
}
