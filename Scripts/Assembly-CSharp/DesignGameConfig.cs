using System;
using System.Collections.Generic;
using System.Numerics;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignGameConfig")]
public class DesignGameConfig : TableBase
{
	[Serializable]
	public class Data
	{
		public string _id;

		public string _value;
	}

	public List<Data> _data;

	public Dictionary<string, Data> _dicData;

	private List<long> _stageAutoRewardPrice;

	private List<long> _accessRewardPrice;

	private List<int> _ignoreSellListId;

	private Dictionary<DesignUpgrade.Data.Type, Dictionary<byte, Dictionary<int, long>>> _upgradeOpenPrice;

	public ItemReward _equipmentDivideCost;

	public string[] _openMenuCharacteristic;

	public string[] _openMenuTreasure;

	public int _openMenuAccessory;

	public int _openMenuCharm;

	public int _openAdsBuff;

	public int _openMenuDungeon;

	public int _artifactGachaGroup;

	public List<Tuple<int, int, BigInteger>> _exchangeExpItem;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(string id)
	{
		return null;
	}

	public string GetGameConfigString(string id)
	{
		return null;
	}

	public int GetGameConfigInt(string id)
	{
		return 0;
	}

	public long GetGameConfigLong(string id)
	{
		return 0L;
	}

	public short GetGameConfigShort(string id)
	{
		return 0;
	}

	public decimal GetGameConfigDecimal(string id)
	{
		return default(decimal);
	}

	public float GetGameConfigFloat(string id)
	{
		return 0f;
	}

	public double GetGameConfigDouble(string id)
	{
		return 0.0;
	}

	public long GetStageAutoRewardPrice(int count)
	{
		return 0L;
	}

	public long GetAccessRewardPrice(int count)
	{
		return 0L;
	}

	public bool IsIgnoreSellList(int itemId)
	{
		return false;
	}

	public Dictionary<int, long> GetUpgradeOpenPrice(DesignUpgrade.Data.Type type, byte slot)
	{
		return null;
	}
}
