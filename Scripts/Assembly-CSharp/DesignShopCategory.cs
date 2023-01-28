using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignShopCategory")]
public class DesignShopCategory : TableBase
{
	[Serializable]
	public class Data
	{
		public enum CategoryType
		{
			Normal = 1
		}

		[NonSerialized]
		public List<Data> _childDataList;

		public int _childRefCount;

		public int _id;

		public int _popupGroup;

		public int _group;

		public int _order;

		public int _name;

		public int _subGroup;

		public int _subOrder;

		public int _subName;

		public CategoryType _type;

		public List<string> _value;

		public List<int> _openWorldIdList;

		public string _strStartDate;

		public string _strEndDate;

		public DateTime _startDate;

		public DateTime _endDate;

		public bool _blindDate;

		public List<string> GetShopIdList()
		{
			return null;
		}

		private List<string> GetShopIds()
		{
			return null;
		}

		public void ConvertDateTime()
		{
		}

		public bool IsActive()
		{
			return false;
		}

		public bool IsActive(int curWorldId)
		{
			return false;
		}

		public List<DesignShop.Data> GetShopList()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	private const int _childPivotNum = 100000000;

	public override void CalcData()
	{
	}

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public virtual List<Data> GetDesign()
	{
		return null;
	}

	public virtual Data GetParentData(int groupId, int subGroupId)
	{
		return null;
	}

	public virtual List<Data> GetActiveCategoryGroup(int popupGroup, bool isPopupShop)
	{
		return null;
	}

	public virtual List<Data> GetActiveCategorySubGroup(int popupGroup, int categoryGroup)
	{
		return null;
	}

	public virtual bool IsGetActiveShopPopupButton(Data cat)
	{
		return false;
	}

	public virtual Data GetActiveCategoryGroupByItemId(int itemId)
	{
		return null;
	}

	public virtual Data GetActiveCategoryGroupByShopId(int shopId)
	{
		return null;
	}

	public virtual List<int> GetSellTypeList(int popupGroup, int categoryGroup)
	{
		return null;
	}

	public virtual void IsPopupWarningLabel(int popupGroup, int categoryGroup, out bool IsStorageLabel, out int refundString)
	{
		IsStorageLabel = default(bool);
		refundString = default(int);
	}

	public override void GlobalCalcData()
	{
	}
}
