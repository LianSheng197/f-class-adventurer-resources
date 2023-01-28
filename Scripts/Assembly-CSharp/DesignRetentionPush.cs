using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRetentionPush")]
public class DesignRetentionPush : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public bool _enable;

		public int _time;

		public int _messageTitleId;

		public int _messageId;

		public int _mailId;

		public int _remainTime;

		public List<int> _rewardType;

		public List<long> _rewardValue;

		public List<int> _targetLanguage;
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

	public void RegisterPush()
	{
	}

	public bool CheckRetentionPush()
	{
		return false;
	}
}
