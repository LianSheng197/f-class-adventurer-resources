using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacterSkill")]
public class DesignCharacterSkill : TableBase
{
	[Serializable]
	public class Data
	{
		public int _id;

		public int _skillId;

		public int _order;

		public int _name;

		public int _skillGrade;

		public SpriteData _sprite;

		public SpriteData _background;

		public List<int> _needItemType;

		public List<long> _needItemValue;

		public int _levelUpType;

		public int _fameUpType;

		public int _maxFame;

		public int _evolutionUpType;

		public int _maxEvolution;

		public Dictionary<int, long> _needItem;

		public void CalcData()
		{
		}
	}

	public const int _skillSlot = 10;

	public const int _skillEquip = 10;

	public const int _useSkillEquip = 6;

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public Dictionary<int, Data> _dicSkillIdData;

	private List<int> _calcBaseSkillLevel;

	private List<int> _calcContentsSkillLevel;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public override void GlobalCalcData()
	{
	}

	public Data GetData(int id)
	{
		return null;
	}

	public Data FindSkillId(int skillId)
	{
		return null;
	}

	public int Sort(Data a, Data b)
	{
		return 0;
	}

	public bool IsCharacterSkill(int skillId)
	{
		return false;
	}

	public string GetDescription(int skillId, Character character, int baseSkillLevel, int contentsSkillLevel, int evolution)
	{
		return null;
	}
}
