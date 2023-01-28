using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShopPopupButton")]
public class DesignShopPopupButton : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public SpriteData _sprite;

		public int _btnName;

		public int _titleName;

		public int _order;

		public int _popupCategoryGroup;

		public DateTime _startDate;

		public DateTime _endDate;

		public bool isActive(int curWorldId = -1)
		{
			return false;
		}

		public bool isActiveItem()
		{
			return false;
		}

		public List<DesignShopCategory.Data> GetShopPopupCategoryList()
		{
			return null;
		}

		public List<DesignShop.Data> GetShopList()
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

	public Data GetActiveData(DesignShopCategory.Data categoryData)
	{
		return null;
	}
}
