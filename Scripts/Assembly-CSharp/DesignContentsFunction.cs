using System;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[AddComponentMenu("Table/DesignContentsFunction")]
public class DesignContentsFunction : TableBase
{
	[Serializable]
	public class Data
	{
		public enum FunctionType
		{
			tower_HP = 11,
			tower_defence = 12,
			stone_getValue = 21,
			stone_max = 22,
			summon_price = 23,
			summon_time = 24,
			reward_stone = 25,
			stone_getvalue_down = 26,
			monster_drop_count = 31,
			monster_exp = 32,
			stage_needItemValue = 33,
			monster_drop_percentage = 34,
			tower_drop_count = 35,
			boss_drop_count = 36,
			character_attack = 41,
			character_hp = 42,
			character_defence = 43,
			character_attackSpeed = 44,
			character_moveSpeed = 45,
			character_attackDistance = 46,
			character_attack_down = 47,
			character_mp = 48,
			defence_ignore = 49,
			critical_defence = 50,
			damage_up = 51,
			damage_down = 52,
			skill_damage = 53,
			skill_attribute_damage = 54,
			Upgrade_up = 56,
			Belt_Damage = 57,
			Ring_Damage = 58,
			minDamage = 61,
			maxDamage = 62,
			critical_percentage = 63,
			critical_damage = 64,
			critical2_percentage = 65,
			critical2_damage = 66,
			critical3_percentage = 67,
			critical3_damage = 68,
			heal_hp = 71,
			heal_hp_percentage = 72,
			killheal_hp = 73,
			killheal_hp_percentage = 74,
			attack_hp = 75,
			attack_hp_percentage = 76,
			attack_mp = 77,
			attack_mp_percentage = 78,
			heal_mp = 81,
			heal_mp_percentage = 82,
			killheal_mp = 83,
			killheal_mp_percentage = 84,
			Skill_Level = 91,
			Skill_CoolTime = 92,
			Skill_NeedMP = 93,
			Skill_Value = 94,
			Skill_TargetCount = 95,
			Skill_Distance = 96,
			Skill_Range = 97,
			normal_monster_damage_up = 101,
			boss_monster_damage_up = 102,
			continual_hit = 103,
			hp_percent_damage_up = 104,
			hp_percent_damage_down = 105,
			emergency_damage_down = 106,
			maximum_damage = 111,
			block = 112,
			avoid = 113
		}

		public enum FunctionTargetType
		{
			None = 0,
			ItemId = 1,
			ItemDetailType = 2,
			WorldId = 10,
			Enemy_CharacterFame = 21,
			Enemy_CharacterAttribute = 22,
			Enemy_CharacterType = 23,
			Enemy_CharacterNation = 24,
			Enemy_CharacterAttackType = 25,
			Enemy_CharacterGroundType = 26,
			Enemy_CharacterId = 27,
			User_CharacterFame = 31,
			User_CharacterAttribute = 32,
			User_CharacterType = 33,
			User_CharacterNation = 34,
			User_CharacterAttackType = 35,
			User_CharacterGroundType = 36,
			User_CharacterId = 37,
			Skill_Id = 41,
			Skill_Attribute = 42,
			Skill_Base = 43,
			UpgradeType = 51,
			UpgradeFunctionType = 52
		}

		public enum FormatType
		{
			Sum = 0,
			Multiply = 1,
			MultiplyMultiply = 2,
			Max = 3
		}

		public int _id;

		public int _name;

		public FunctionType _functionType;

		public FunctionTargetType _functionTargetType;

		public FormatType _formatType;

		public int _description;

		public int _value;

		public SpriteData _sprite;
	}

	public List<Data> _data;

	public Dictionary<int, Data> _dicData;

	public override void ClearData()
	{
	}

	public override void CalcData()
	{
	}

	public override void LoadXml(XmlNodeList nodeList)
	{
	}

	public Data GetData(int id)
	{
		return null;
	}
}
