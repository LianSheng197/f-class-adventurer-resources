using System.Collections.Generic;

public class DashData
{
	public DesignSkill.Data _designSkill;

	public DesignSkillFunction.Data _designSkillFunction;

	public int _baseSkillLevel;

	public int _contentsSkillLevel;

	public float _value;

	public float _moveSpeed;

	public float _optionValue;

	public int _damageEffect;

	public int _damageCastingTimeAttackEffect;

	public DesignSkill.Data _targetSkill;

	public BattleObjectBase _target;

	public List<BattleObjectBase> _rangeList;

	private List<SkillTarget.SkillTargetData> _targetList;

	public void Clear()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public List<SkillTarget.SkillTargetData> GetTarget(SkillTarget skillTarget)
	{
		return null;
	}
}
