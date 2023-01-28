using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShopIAP")]
public class DesignShopIAP : TableBase
{
	[Serializable]
	public class Data
	{
		public enum eMarketType
		{
			none = 0,
			Google = 1,
			Apple = 2,
			OneStore = 3,
			size = 4
		}

		public int _id;

		public eMarketType _type;

		public string _configName;

		public string _productValue;

		public int _tier;

		public string _KRW;

		public string _USD;

		public string _JPY;

		public string GetCurrencyString()
		{
			return null;
		}

		public DesignShop.Data GetShop()
		{
			return null;
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

	public Data GetData(int id)
	{
		return null;
	}

	public Data GetData(ePlatform platform, string productId)
	{
		return null;
	}

	public Data GetData(Data.eMarketType platform, string productId)
	{
		return null;
	}
}
