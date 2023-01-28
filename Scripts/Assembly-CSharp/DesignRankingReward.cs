using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignRankingReward")]
public class DesignRankingReward : TableBase
{
	[Serializable]
	public class Data
	{
		public enum RewardType
		{
			Rank = 1,
			RankRatio = 2,
			Score = 3
		}

		public int _id;

		public int _group;

		public RewardType _rewardType;

		public long _rewardCondition;

		public List<int> _rewardItems;

		public List<int> _rewardValues;

		public Color _textGradientTop;

		public Color _textGradientBottom;
	}

	public List<Data> _data;

	public Dictionary<int, List<Data>> _dataListPerGroup;

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

	public List<Data> GetDataListByGroup(int rankingGroupOfWorld)
	{
		return null;
	}
}
