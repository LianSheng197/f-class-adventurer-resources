using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignLegend")]
public class DesignLegend : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Category
		{
			Normal = 1,
			Trial = 2,
			Event = 3,
			Max = 4
		}

		public int _id;

		public int _order;

		public int _name;

		public Category _category;

		public int _legendGrade;

		public SpriteData _sprite;

		public int _needItemId;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public List<int> _levelUpNeedItemType;

		public List<long> _levelUpNeedItemValue;

		public List<float> _levelUpNeedItemPlusValue;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int _fameUpType;

		public int _characterId;

		public bool _isWeaponImg;

		public int _randomOptionHaveEffectType;

		public List<int> _randomOptionOpenCondition;

		public int _randomOptionPriceType;

		public int _randomOptionRandomType;

		public Dictionary<int, long> _needItem;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public void CalcData()
		{
		}

		public List<ContentsFunctionData> GetContentsFunction(int level)
		{
			return null;
		}

		public Dictionary<int, long> GetLevelUpNeedItem(int level)
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<Data.Category, List<Data>> _dicCategoryData;

	public List<int> _needTypeList;

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

	public List<Data> FindCategory(Data.Category category)
	{
		return null;
	}

	public int Sort(Data a, Data b)
	{
		return 0;
	}
}
