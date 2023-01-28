using System.Collections.Generic;
using UnityEngine;

public class SkillCondition : MonoBehaviour
{
	public class SkillConditionData
	{
		public DesignSkill.Data _designSkill;

		public int _conditionValue;

		public int _activeCount;

		public float _coolTime;
	}

	public float _attackSpeedTime;

	private BattleObjectHero _hero;

	private Character _character;

	private List<SkillConditionData> _skillConditionData;

	private List<SkillConditionData> _useList;

	public static SkillCondition Get(GameObject hero)
	{
		return null;
	}

	public void Init()
	{
	}

	private void Update()
	{
	}

	public float GetAttackSpeed()
	{
		return 0f;
	}

	public List<SkillConditionData> FindUseSkill(DesignSkill.Data.ActiveTiming activeTiming)
	{
		return null;
	}

	public int UseSort(SkillConditionData a, SkillConditionData b)
	{
		return 0;
	}

	public void AddConditionValue(DesignSkill.Data.Condition conditionType, int count = 1)
	{
	}
}
