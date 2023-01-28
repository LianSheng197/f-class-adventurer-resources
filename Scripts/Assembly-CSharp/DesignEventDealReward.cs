using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignEventDealReward")]
public class DesignEventDealReward : TableBase
{
	[Serializable]
	public class Data
	{
		public enum DealType
		{
			None = 0,
			Maximum = 1,
			Accumulate = 2,
			Max = 3
		}

		public enum RewardResetType
		{
			EventTime = 0,
			Day = 1,
			Week = 2,
			Max = 3
		}

		public int id;

		public int group;

		public DealType dealType;

		public RewardResetType rewardResetType;

		public double point;

		public int rewardItemType;

		public long rewardItemValue;

		public int mailboxId;

		public Data LoadXml(XmlNode node)
		{
			return null;
		}

		public DesignMailbox.Data GetMailbox()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<Data.DealType, List<Data>>> _dicGroupData;

	public Dictionary<int, double> _dicMaxAccumulatePoint;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public override void GlobalCalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Dictionary<Data.DealType, List<Data>> GetDataGroup(int group)
	{
		return null;
	}

	public List<Data> GetData(int group, Data.DealType dealType)
	{
		return null;
	}

	public double GetMaxAccumulatePoint(int group)
	{
		return 0.0;
	}
}
