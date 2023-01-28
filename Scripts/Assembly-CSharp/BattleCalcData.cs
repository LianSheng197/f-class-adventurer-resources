using System.Collections.Generic;
using UnityEngine;

public class BattleCalcData : MonoBehaviour
{
	public enum Type
	{
		TowerSkillCount = 0,
		KillCount = 1
	}

	public Dictionary<Type, Dictionary<int, int>> _data;

	public double _criticalPercentage;

	public double _criticalDamage;

	public double _critical2Percentage;

	public double _critical2Damage;

	public double _critical3Percentage;

	public double _critical3Damage;

	public double _minDamage;

	public double _maxDamage;

	public double _hpRegain;

	public double _hpRegainMaxPercentage;

	public double _hpMonsterKillRegain;

	public double _hpMonsterKillRegainMaxPercentage;

	public double _mpRegain;

	public double _mpRegainMaxPercentage;

	public double _mpMonsterKillRegain;

	public double _mpMonsterKillRegainMaxPercentage;

	public double _hpRecoverPerHit;

	public double _hpRecoverPerHitMaxPercentage;

	public double _mpRecoverPerHit;

	public double _mpRecoverPerHitMaxPercentage;

	public void Init()
	{
	}

	public void AddValue(Type type, int key)
	{
	}

	public int GetValue(Type type, int key)
	{
		return 0;
	}

	public int GetValueCompare(Type type, int compare)
	{
		return 0;
	}

	public float GetCriticalPercentage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetCriticalDamage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetCritical2Percentage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetCritical2Damage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetCritical3Percentage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetCritical3Damage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetRandomDamage(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public float GetRandomDamageAvg(DesignStage.Data designStage, BattleObjectHero attacker, BattleObjectHero target)
	{
		return 0f;
	}

	public double GetContinualHitValue(double damage, int continualHitCount)
	{
		return 0.0;
	}

	public double GetHPPercentDamageValue(DesignContentsFunction.Data.FunctionType functionType, double damage, double maxHP)
	{
		return 0.0;
	}

	public double GetEmergencyDamageValue(double damage, double hp, double maxHP)
	{
		return 0.0;
	}

	public double GetMaximumDamage(double damage, double maxHP)
	{
		return 0.0;
	}

	public double GetNormalMonsterDamageUp(double damage, DesignStage.Data designStage, BattleObjectHero target)
	{
		return 0.0;
	}

	public double GetBossMonsterDamageUp(double damage, DesignStage.Data designStage, BattleObjectHero target)
	{
		return 0.0;
	}

	public bool IsBlock(double damage, double maxHP)
	{
		return false;
	}

	public bool IsAvoid(double damage, double maxHP)
	{
		return false;
	}
}
