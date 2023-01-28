using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignUpgrade")]
public class DesignUpgrade : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Type
		{
			Stat = 1,
			Upgrade = 2,
			Max = 3
		}

		public int _id;

		public int _name;

		public SpriteData _sprite;

		public SpriteData _miniSprite;

		public Type _type;

		public int _order;

		public int _needCharacterLevel;

		public List<int> _needUpgrade;

		public int _description;

		public int _contentsFunctionType;

		public int _contentsFunctionCondition;

		public float _contentsFunctionValue;

		public float _contentsFunctionPlusValue;

		public int _levelupType;

		public int _priceMultiplyValue;

		public bool _hidden;

		private Dictionary<int, ContentsFunctionData> _contentsFunctionLevelData;

		public void CalcData()
		{
		}

		public int MaxLevel()
		{
			return 0;
		}

		public ContentsFunctionData GetContentsFunction(int level)
		{
			return null;
		}

		public double GetFunctionValue(int level)
		{
			return 0.0;
		}
	}

	public static readonly byte _maxSlot;

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<Data.Type, List<Data>> _dicTypeData;

	public Dictionary<int, List<int>> _dicNeedCharacterLevelData;

	public Dictionary<int, List<int>> _dicNeedUpgradeLevelData;

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

	public List<Data> GetDataList(Data.Type type)
	{
		return null;
	}

	public List<Data> GetSort()
	{
		return null;
	}

	public int Sort(Data a, Data b)
	{
		return 0;
	}

	public List<int> FindNeedCharacterLevelData(int teamLevel)
	{
		return null;
	}

	public List<int> FindNeedUpgradeLevelData(int id)
	{
		return null;
	}
}
