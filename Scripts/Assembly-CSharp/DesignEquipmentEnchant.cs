using System;
using System.Collections.Generic;
using System.Xml;

public class DesignEquipmentEnchant : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _enchantType;

		public int _enchantLevel;

		public List<int> _needItemType;

		public List<int> _needItemValue;

		public int _successRate;

		public int _multiplyValue;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}

		public Data Next()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Dictionary<int, Data>> _dicLevelListData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int designId)
	{
		return null;
	}

	public Dictionary<int, Data> GetDataListByEnchantType(int enchantType)
	{
		return null;
	}

	public Data GetDataByEnchantType(int enchantType, int enchantLevel)
	{
		return null;
	}
}
