using System;
using System.Collections.Generic;

[Serializable]
public class EventBuff
{
	public enum type
	{
		none = 0,
		battle_stat_attack_up = 1,
		battle_stat_hp_up = 2,
		battle_stat_defence_up = 3,
		battle_stat_attack_speed_up = 4,
		battle_stat_move_speed_up = 5,
		character_levelUp_price_down = 11,
		tower_levelUp_price_down_notUse = 21,
		tower_skill_levelUp_price_down_notUse = 22,
		upgrade_levelUp_price_down = 31,
		item_sell_price_up = 41,
		exp_reward_up = 101,
		random_reward_up = 103,
		specific_reward_up = 104,
		size = 105
	}

	public enum condition
	{
		none = 0,
		condition_teamLevel = 1,
		condition_characterId = 11,
		condition_characterFame = 12,
		condition_characterAttribute = 13,
		condition_characterType = 14,
		condition_characterNation = 15,
		condition_characterAttackType = 16,
		condition_characterSummonCoolTime = 17,
		condition_characterSummonPrice = 18,
		condition_characterLevel = 19,
		condition_towerLevel = 31,
		condition_skillLevel = 32,
		condition_skillId = 33,
		condition_upgradeLevel = 41,
		condition_upgradeId = 42,
		condition_upgradeType = 43,
		condition_itemId = 51,
		condition_worldId = 71,
		condition_stageId = 72,
		condition_stageVictoryType_notUse = 73,
		condition_stageAttribute = 74,
		condition_reilicGrade = 81,
		size = 82
	}

	[Serializable]
	public class conditionData
	{
		public bool _existsCondition;

		public condition _conditionType;

		public List<int> _conditionValueList;
	}

	public const int _conditionMaxCount = 10;

	public int _name;

	public int _orderNumber;

	public type _type;

	public bool _isInvisible;

	public List<decimal> _valueList;

	public List<conditionData> _conditionList;

	public bool CheckCondition(EventBuffUserValue userValue)
	{
		return false;
	}

	public decimal GetValue()
	{
		return default(decimal);
	}

	public bool Equals(EventBuff obj)
	{
		return false;
	}
}
