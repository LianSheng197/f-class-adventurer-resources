using System.Collections.Generic;

public class ReflectBuffData
{
	public DesignSkill.Data _designSkill;

	public float _value;

	public float _time;

	public float _distance;

	public float _tick;

	public float _tickTime;

	public bool _isBuffEffect;

	public int _damageEffect;

	public bool _isOverlap;

	private List<BattleObjectBase> _targetList;

	private List<BattleObjectBase> _calc;

	public List<BattleObjectBase> _overlapList;

	public void Clear()
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public bool Update(float deltaTime)
	{
		return false;
	}

	public void Reflect(float deltaTime, BattleObjectHero attacker)
	{
	}
}
