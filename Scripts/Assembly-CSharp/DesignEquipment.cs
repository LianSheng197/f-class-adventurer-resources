using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignEquipment")]
public class DesignEquipment : TableBase
{
	[Serializable]
	public class Data
	{
		public enum Slot
		{
			Weapon = 1,
			Armor = 2,
			Accessory = 3,
			Charm = 4,
			Artifact = 11,
			Max = 12
		}

		public int _id;

		public Slot _slot;

		public int _slotGrade;

		public int _group;

		public int _itemId;

		public int _needUpgradeCount;

		public int _needItemType;

		public long _needItemValue;

		public float _needItemPlusValue;

		public int _maxLevel;

		public List<ContentsFunctionData> _equipContentsFunctionData;

		public List<ContentsFunctionData> _contentsFunctionData;

		public int _enchantType;

		public int _expandLevelType;

		public TextureData _textureData;

		public long _altarExp;

		private Dictionary<int, List<ContentsFunctionData>> _equipContentsFunctionLevelData;

		private Dictionary<int, List<ContentsFunctionData>> _contentsFunctionLevelData;

		public Data GetNext(int jumpGrade = 1)
		{
			return null;
		}

		public List<ContentsFunctionData> GetEquipContentsFunction(int level)
		{
			return null;
		}

		public List<ContentsFunctionData> GetContentsFunction(int level)
		{
			return null;
		}

		private ContentsFunctionData MakeContentsFunction(ContentsFunctionData target, int level)
		{
			return null;
		}

		public bool IsCharm()
		{
			return false;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<Data.Slot, Dictionary<int, Data>> _dicSlotData;

	public Dictionary<Data.Slot, List<Data>> _dicSlotListData;

	public Dictionary<int, Data> _dicItemIdData;

	public Dictionary<Data.Slot, Dictionary<int, Data>> _dicItemIdGradeData;

	public Dictionary<int, int> _dicGroupMaxSlotGrade;

	public List<Data> _altarList;

	public List<int> _needTypeList;

	public List<int> _needTypeArtifactList;

	public Dictionary<Data.Slot, Tuple<int, int>> _dicItemIdRange;

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

	public Data GetData(Data.Slot slot, int itemId)
	{
		return null;
	}

	public Dictionary<int, Data> FindSlotDic(Data.Slot slot)
	{
		return null;
	}

	public List<Data> FindSlotList(Data.Slot slot)
	{
		return null;
	}

	public Data FindDataFromItemId(int itemId)
	{
		return null;
	}

	public Data FindSlotGrade(Data.Slot slot, int slotGrade)
	{
		return null;
	}

	public int GetGroupMaxSlotGrade(int group)
	{
		return 0;
	}

	public int Sort(Data a, Data b)
	{
		return 0;
	}

	public int AltarSort(Data a, Data b)
	{
		return 0;
	}

	public Tuple<int, int> GetItemIdRange(Data.Slot slot)
	{
		return null;
	}
}
