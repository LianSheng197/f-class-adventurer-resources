using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignCharacter")]
public class DesignCharacter : TableBase
{
	[Serializable]
	public class Data
	{
		public enum GroundType
		{
			Ground = 1,
			Air = 2
		}

		public int _id;

		public int _name;

		public int _fame;

		public int _attribute;

		public int _nation;

		public List<int> _feature;

		public int _type;

		public int _attackType;

		public int _levelUpType;

		public int _upgradeType;

		public int _enchantType;

		public double _hp;

		public long _mp;

		public double _attack;

		public double _defence;

		public float _attackSpeed;

		public double _growHp;

		public double _growMp;

		public double _growAttack;

		public double _growDefence;

		public float _growAttackSpeed;

		public int _actorId;

		public string _skin;

		public List<int> _rewardItemType;

		public List<long> _rewardItemValue;

		public List<int> _rewardItemSeed;

		public int _rewardStone;

		public GroundType _groundType;

		public float _groundPositionY;

		public float _moveSpeed;

		public int _targetOrder;

		public List<int> _attackGroundType;

		public int _attackDistance;

		public List<int> _skill;

		public List<ContentsFunctionData> _contentsFunctionData;

		public bool _isEventOnly;

		public int _magicType;

		public long _rewardExp;

		public float _reactionDistance;

		private DesignActor.Data _designActor;

		private static DesignItem _designItem;

		private static DesignRandomSeed _designRS;

		public Character GetCharacter()
		{
			return null;
		}

		public DesignActor.Data GetDesignActor()
		{
			return null;
		}

		public List<ItemReward> GetRewardList()
		{
			return null;
		}

		public Dictionary<int, long> GetRewardDic()
		{
			return null;
		}

		public void GetRandomReward(ref List<ItemReward> rewards, int randomIndex, Character character, DesignStage.Data designStage)
		{
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
}
