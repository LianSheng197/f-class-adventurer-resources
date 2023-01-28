using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignEventBuff")]
public class DesignEventBuff : TableBase
{
	[Serializable]
	public class Data
	{
		public long _idx;

		public long _groupId;

		public int _orderNumber;

		public string _strNameList;

		public int _type;

		public string _strValueList;

		public int _conditionType1;

		public string _strConditionValueList1;

		public int _conditionType2;

		public string _strConditionValueList2;

		public int _conditionType3;

		public string _strConditionValueList3;

		public int _conditionType4;

		public string _strConditionValueList4;

		public int _conditionType5;

		public string _strConditionValueList5;

		public int _conditionType6;

		public string _strConditionValueList6;

		public int _conditionType7;

		public string _strConditionValueList7;

		public int _conditionType8;

		public string _strConditionValueList8;

		public int _conditionType9;

		public string _strConditionValueList9;

		public int _conditionType10;

		public string _strConditionValueList10;

		public int _conditionType11;

		public string _strConditionValueList11;

		public int _conditionType12;

		public string _strConditionValueList12;

		public int _conditionType13;

		public string _strConditionValueList13;

		public int _conditionType14;

		public string _strConditionValueList14;

		public int _conditionType15;

		public string _strConditionValueList15;
	}

	public List<Data> _data;

	public Dictionary<long, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(long idx)
	{
		return null;
	}

	public List<Data> GetDataList(long groupId)
	{
		return null;
	}
}
