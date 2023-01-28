using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignTeamLevel")]
public class DesignTeamLevel : TableBase
{
	[Serializable]
	public class Data
	{
		public int _teamLevel;

		public string _strTeamExp;

		public BigInteger _teamExp;

		public List<int> _rewardItemType;

		public List<long> _rewardItemValue;

		private static DesignTeamLevel _designTL;

		private static int _maxLevel;

		public Data PrevLevel()
		{
			return null;
		}

		public Data NextLevel()
		{
			return null;
		}

		public int MaxLevel()
		{
			return 0;
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public BigInteger GetReqExp(BigInteger curExp)
		{
			return default(BigInteger);
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

	public Data GetData(int teamLevel)
	{
		return null;
	}

	public Data GetLevel(BigInteger exp)
	{
		return null;
	}

	public Data GetMaxLevel()
	{
		return null;
	}
}
