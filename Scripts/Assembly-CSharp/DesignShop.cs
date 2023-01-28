using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShop")]
public class DesignShop : TableBase
{
	[Serializable]
	public class Data
	{
		public enum BuyType
		{
			Free = -2,
			Ads = -1,
			IAP = 0,
			Item = 1
		}

		public enum LimitedType
		{
			None = 1,
			Account = 2,
			Day = 3,
			Week = 4,
			Month = 5
		}

		public enum ImageType
		{
			Atlas = 0,
			Item = 1
		}

		public enum FunctionType
		{
			None = 0,
			Montyly = 1,
			SpecialMissionPremium = 2,
			CharacterSkin = 3,
			StageRandomRewardDouble = 4,
			RandomBox = 11
		}

		public enum LabelIcon
		{
			Best = 1,
			Hot = 2,
			New = 3,
			Bonus = 4,
			Event = 5,
			Sale = 6,
			size = 7
		}

		public class SpecificSaleDate
		{
			public DateTime _startDate;

			public DateTime _endDate;
		}

		public int _id;

		public int _name;

		public int _description;

		public int _needLevel;

		public int _maxLevel;

		public int _needHonor;

		public int _maxHonor;

		public LimitedType _limitedType;

		public int _limitedCount;

		public int _refundNotice;

		public int _sellType;

		public int _price;

		public int _stepGroup;

		public int _step;

		public bool _stepHidden;

		public ImageType _imageType;

		public SpriteData _sprite;

		public string _label;

		public List<int> _itemType;

		public List<long> _itemValue;

		public FunctionType _functionType;

		public List<int> _functionValue;

		public bool _noAutoAds;

		public bool _noAds;

		public int _multiple;

		public int _iosProductId;

		public int _androidProductId;

		public int _oneStoreProductId;

		public int _mailBoxId;

		public int _noDetail;

		public int _legendIdCheck;

		public bool _availableBuyNewMark;

		public bool _soldOutHide;

		public int _needClearStage;

		private List<SpecificSaleDate> _specificSaleDate;

		private List<DesignShopCategory.Data> _parentCategory;

		public bool IsLimit()
		{
			return false;
		}

		public DesignShopIAP.Data GetIAP(DesignShopIAP.Data.eMarketType marketType)
		{
			return null;
		}

		public DesignShopIAP.Data GetIAP(ePlatform ePlatformType)
		{
			return null;
		}

		public BuyType GetBuyType()
		{
			return default(BuyType);
		}

		public bool IsStorageWarningLabel()
		{
			return false;
		}

		public void AddParentCategory(DesignShopCategory.Data parent)
		{
		}

		public void AddSpecificSaleDate(DateTime startDate, DateTime endDate)
		{
		}

		public bool IsSpecificSaleDate()
		{
			return false;
		}

		public SpecificSaleDate GetActiveSpecificSaleDate()
		{
			return null;
		}

		public bool CheckSaleTime()
		{
			return false;
		}

		public bool IsActive()
		{
			return false;
		}

		public bool IsStepUp()
		{
			return false;
		}

		public string GetShopItemName()
		{
			return null;
		}

		public string GetDescription()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, SortedDictionary<int, Data>> _dicStepUpData;

	public Dictionary<int, Data> _dicDataForSpecialMission;

	public Dictionary<int, Data> _availableBuyNewMarkList;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void GlobalCalcData()
	{
	}

	public override void CalcData()
	{
	}

	private void CalcStepUpData(Data data)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetDataForSpecialMission(int id)
	{
		return null;
	}

	public Dictionary<int, Data> GetAvailableBuyNewMarkList()
	{
		return null;
	}
}
