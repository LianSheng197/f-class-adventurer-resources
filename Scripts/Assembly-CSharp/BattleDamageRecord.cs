using System.Collections.Generic;
using System.Numerics;

public class BattleDamageRecord
{
	public const int _dataCount = 60;

	public float _time;

	private int _index;

	public Dictionary<int, BattleRecordData> _dataList;

	public Dictionary<int, BigInteger> _damages;

	public Dictionary<int, StatisticsData> _realDamages;

	public bool _isUpdate;

	public bool _isChangeSlot;

	public bool _isEquipChange;

	public BigInteger _maxValue;

	public void AddTime(float deltaTime)
	{
	}

	public void EquipChange()
	{
	}

	public void ChangeSlot()
	{
	}

	public void AddDamage(int skillId, double damage, double realDamage)
	{
	}

	public void AddDamage(int skillId, BigInteger damage, double realDamage)
	{
	}

	private void Calc()
	{
	}
}
