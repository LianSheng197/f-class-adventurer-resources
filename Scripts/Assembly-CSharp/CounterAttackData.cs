public class CounterAttackData
{
	public DesignSkill.Data _designSkill;

	public float _value;

	public float _time;

	public float _distance;

	public int _damageEffect;

	public int _damageCastingTimeAttackEffect;

	public DesignSkill.Data _targetSkill;

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
}
