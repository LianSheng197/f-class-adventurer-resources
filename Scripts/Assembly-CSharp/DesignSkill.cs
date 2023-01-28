using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkill")]
public class DesignSkill : TableBase
{
	[Serializable]
	public class Data
	{
		public enum ActiveTiming
		{
			Normal = 0,
			Immediately = 1
		}

		public enum Condition
		{
			None = 0,
			AttackSpeed = 1,
			Attack = 2,
			Hit = 3,
			HP_Rate_Less = 4,
			HP_Rate_Over = 5,
			Distance = 6
		}

		public enum CoolTimeType
		{
			None = 0,
			Init_MaxCoolTime = 1,
			Init_NoneCoolTime = 2
		}

		public enum Attribute
		{
			None = 0,
			Fire = 1,
			Ice = 2,
			Electric = 3,
			Wind = 4,
			Max = 5
		}

		public int _id;

		public int _evolution;

		public int _description;

		public ActiveTiming _activeTiming;

		public Condition _condition;

		public int _conditionValue;

		public int _priority;

		public int _activeCount;

		public int _needMP;

		public int _attribute;

		public float _damageCastingTime;

		public CoolTimeType _coolTimeType;

		public float _coolTime;

		public string _actionAnimation;

		public List<int> _attackEffect;

		public int _damageCastingTimeAttackEffect;

		public int _arrowEffectStartingPositionX;

		public int _arrowEffectStartingPositionY;

		public List<int> _skillFunctionId;

		public List<int> _skillFunctionLevel;

		public float _screenShaking;

		private List<DesignSkillFunction.Data> _result;

		public List<DesignSkillFunction.Data> GetSkillFunction(Character character, int baseSkillLevel, int contentsSkillLevel, ref List<int> calcBaseSkillLevel, ref List<int> contentsSkillLevelList)
		{
			return null;
		}

		public Data IsCustomSkillTarget()
		{
			return null;
		}
	}

	public List<Data> _data;

	public Dictionary<int, Dictionary<int, Data>> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public Data GetData(int id, int evolution)
	{
		return null;
	}
}
