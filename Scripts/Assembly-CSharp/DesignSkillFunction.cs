using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignSkillFunction")]
public class DesignSkillFunction : TableBase
{
	[Serializable]
	public class Data
	{
		public enum TargetTeam
		{
			Enemy = 1,
			User = 2,
			All = 3,
			My = 4
		}

		public enum TargetFilterType
		{
			None = 0,
			Fame = 1,
			Attribute = 2,
			Type = 3,
			Nation = 4,
			AttackGroundType = 5,
			GroundType = 6
		}

		public enum TargetPriorityType
		{
			Distance = 0,
			HP_Value = 1,
			HP_Percent = 2,
			Attack = 3,
			HP_Max = 4,
			Defence = 5,
			Self = 9,
			Random = 99
		}

		public enum TargetPriorityValue
		{
			None = 0,
			Ascending = 1,
			Descending = 2
		}

		public enum FunctionType
		{
			Attack = 1,
			Critical_Attack_notuse = 2,
			Multiple_Attack = 3,
			Penetrate_Attack_notuse = 4,
			Burn = 5,
			Poison = 6,
			KnockBack = 11,
			Stun = 12,
			Freeze = 13,
			Gather = 14,
			KnockBack_Axis = 15,
			Shield_HP = 21,
			Shield_Count = 22,
			Shield_Percent = 23,
			Reflect = 24,
			Attack_Buff = 25,
			Defence_Buff = 26,
			HP_Buff = 27,
			MoveSpeed_Buff = 28,
			AttackSpeed_Buff = 29,
			Reflect_Rate = 30,
			Reflect_Buff = 31,
			Use_MP_Buff = 32,
			Skill_GlobalCoolTime_Buff = 33,
			Critical_Damage_Buff = 34,
			Skill_OffsetValue_Buff = 35,
			Skill_CoolTime_Buff = 36,
			CounterAttack = 37,
			CounterAttack2 = 38,
			HP_Heal = 41,
			MP_Heal = 42,
			HP_Dot_Heal = 43,
			MP_Dot_Heal = 44,
			Dash = 51,
			JumpDash = 52,
			Summon_Reflect_Buff = 71,
			Summon_Dash = 72,
			Summon_Reflect_Buff_NotMove = 73,
			Penetrate_Resist = 104,
			Burn_Resist = 105,
			Poison_Resist = 106,
			Attribute_Immune = 110,
			KnockBack_Resist = 111,
			Stun_Resist = 112,
			Freeze_Resist = 113,
			Gather_Resist = 114,
			Buff_Remover = 131,
			Debuff_Remover = 132,
			Stun_Remover = 133,
			Freeze_Remover = 134,
			Shield_HP_Remover = 135,
			Shield_Count_Remover = 136,
			Penetrate_Debuff = 204,
			Attack_Debuff = 225,
			Defence_Debuff = 226,
			MoveSpeed_Debuff = 228,
			AttackSpeed_Debuff = 229
		}

		public enum AttackDistanceType
		{
			None = 0,
			CharacterAttackPlus = 1
		}

		public int _id;

		public int _targetGroup;

		public TargetTeam _targetTeam;

		public List<int> _targetFilterType;

		public List<int> _targetFilterValue;

		public bool _targetFilterCharacterSize;

		public TargetPriorityType _targetPriorityType;

		public TargetPriorityValue _targetPriorityValue;

		public int _targetCount;

		public AttackDistanceType _attackDistanceType;

		public int _attackDistance;

		public int _range;

		public float _plusAttackDistance;

		public float _plusRange;

		public FunctionType _functionType;

		public List<float> _value;

		public List<float> _plusValue;

		public List<float> _contentsFunctionPlusValue;

		public int _buffSkillId;

		public int _arrowEffect;

		public int _damageEffect;

		public int _actionEffect;

		public int _attackEnemyEffect;

		public List<int> _convertBuffValues;

		public void CalcData()
		{
		}

		public bool IsRemover()
		{
			return false;
		}

		public bool IsFreezeAction()
		{
			return false;
		}
	}

	public List<Data> _data;

	public Dictionary<int, List<Data>> _dicData;

	public override void ClearData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public override void CalcData()
	{
	}

	public List<Data> GetData(int id)
	{
		return null;
	}
}
