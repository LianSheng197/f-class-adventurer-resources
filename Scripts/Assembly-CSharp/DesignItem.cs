using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignItem")]
public class DesignItem : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Type
		{
			Currency = 1,
			Normal = 2,
			Max = 3
		}

		public enum MoneyType
		{
			None = 0,
			Money = 1,
			FreeMoney = 2,
			EventMoney = 3
		}

		public enum CurrencyType
		{
			None = 0,
			Currency = 1,
			Ticket = 2,
			Max = 3
		}

		public enum UseFunctionType
		{
			None = 0,
			Character_Summon = 1,
			ItemEquipSupplement_Enchant = 2,
			Skin = 3,
			Name_Change = 4,
			Montyly = 11,
			SpecialMissionPremium = 12,
			ItemSelect = 21,
			RandomBox = 22,
			Shop = 31,
			Abusing_Warning = 32,
			Max = 33
		}

		public enum ApChargeType
		{
			None = 0,
			Second = 1,
			Hour = 2,
			Day = 3,
			Max = 4
		}

		public int _id;

		public int _name;

		public Type _type;

		public int _detailType;

		public int _grade;

		public int _subGrade;

		public MoneyType _moneyType;

		public CurrencyType _currencyType;

		public SpriteData _sprite;

		public SpriteData _roundSprite;

		public SpriteData _background;

		public SpriteData _ticket;

		public SpriteData _mark;

		public int _sellItemType;

		public int _sellItemValue;

		public UseFunctionType _useFunctionType;

		public int _useFunctionValue;

		public int _useFunctionCondition;

		public ApChargeType _apChargeType;

		public long _apChargePeriod;

		public long _apCharge;

		public long _apChargeMax;

		public int _description;

		public int _skillDescription;

		public int _linkShopId;

		public int _stageLink;

		public Color _textColor;

		public Color _bgGradientTop;

		public Color _bgGradientBottom;

		public int _randomRewardType;

		public string _strStartDate;

		public DateTime _startDate;

		public Item MakeItem()
		{
			return null;
		}

		public void ConvertDateTime()
		{
		}

		public bool IsCash()
		{
			return false;
		}
	}

	public const int _moneyId = 1;

	public const int _cashId = 12;

	public const int _eventCashId = 2;

	public const int _redStoneId = 31;

	public const int _rubyId = 13;

	public const int _eventRubyId = 3;

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Data> _dicDataCurrency;

	private List<int> _listEventMoneyIds;

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

	public Item MakeItem(int id)
	{
		return null;
	}

	public Data.MoneyType GetMoneyType(int id)
	{
		return default(Data.MoneyType);
	}

	public int[] GetEventMoneyIds()
	{
		return null;
	}
}
