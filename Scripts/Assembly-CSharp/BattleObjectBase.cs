using System.Collections.Generic;
using UnityEngine;

public class BattleObjectBase : MonoBehaviour
{
	public enum HPState
	{
		Normal = 0,
		BarrierHP = 1,
		BarrierCount = 2,
		Max = 3
	}

	public enum CriticalType
	{
		None = 0,
		Critical = 1,
		Critical2 = 2,
		Critical3 = 3,
		Max = 4
	}

	public static GameObject _prefabDamageLabel;

	public static GameObject _prefabCriticalLabel;

	public static GameObject _prefabCritical2Label;

	public static GameObject _prefabCritical3Label;

	public static GameObject _prefabHPBarrierLabel;

	public static GameObject _prefabCountBarrierLabel;

	public static GameObject _prefabDamageUserLabel;

	public static GameObject _prefabCriticalUserLabel;

	public static GameObject _prefabCritical2UserLabel;

	public static GameObject _prefabCritical3UserLabel;

	public static GameObject _prefabHPHealLabel;

	public static GameObject _prefabMPHealLabel;

	public static List<GameObject> _prefabImmuneLabel;

	public static GameObject _prefabDefenseLabel;

	public static GameObject _prefabEvadeLabel;

	public const int _stunEffectId = 501;

	public const int _freezeEffectId = 502;

	public const int _shieldHPEffectId = 1054;

	public const int _shieldCountEffectId = 1055;

	public const int _reflectEffectId = 2001;

	public const int _reflectDamageEffectId = 2002;

	public const int _poisonEffectId = 1019;

	public const int _burnEffectId = 1018;

	public const int _countAttackEffectId = 2003;

	public const int _countAttack2EffectId = 2004;

	public BattleData _battleData;

	public long _createNum;

	public bool _isUser;

	public bool _isDeath;

	public double _hp;

	public double _hpMax;

	public double _mp;

	public double _mpMax;

	public double _shieldHP;

	public double _shieldHPMax;

	public int _shieldCount;

	public int _shieldCountMax;

	public int _hitCount;

	public int _continualHitCount;

	public bool _isKnockBack;

	public float _stunTime;

	public float _freezeTime;

	public bool _dontMove;

	public ReflectData _reflectData;

	public ReflectRateData _reflectRateData;

	public Dictionary<int, ReflectBuffData> _reflectBuffList;

	public CounterAttackData _counterAttackData;

	public CounterAttackData _counterAttack2Data;

	public DashData _dashData;

	public int _renderQValue;

	public UIWidget _renderTarget;

	public UISlider _hpSlider;

	public UISlider _uiHPSlider;

	public UILabel _uiHPLabel;

	public UISlider _uiMPSlider;

	public UILabel _uiMPLabel;

	public UILabel _barrierCount;

	public HPState _hpState;

	public List<UISprite> _hpSprite;

	public BoxCollider _collider;

	protected SkillTarget _skillTarget;

	protected BattleObjectBase _target;

	protected List<BuffCondition.BuffData> _checkBuffList;

	protected UISprite _box;

	private double _prevHp;

	private double _prevMp;

	private static DesignSkillEffect _designSE;

	public virtual void InitCollider()
	{
	}

	public void InitHP(UISlider slider, UILabel barrierCount)
	{
	}

	public void InitBattleUI(Transform battleInfo)
	{
	}

	public virtual void UpdateHP()
	{
	}

	public virtual void SetDeath()
	{
	}

	public void ChangeHPState()
	{
	}

	public virtual string GetLogName()
	{
		return null;
	}

	public virtual float GetAttackDistance()
	{
		return 0f;
	}

	public virtual int GetTargetOrder()
	{
		return 0;
	}

	public virtual double GetAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual double GetDefence(BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual double GetDamageCalc(double damage, BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual void GetDamageCalcValue(BattleObjectBase target, ref double sumDamageUp, ref double multiplyDamageUp, ref double multiplyMultiplyDamageUp, ref double sumDamageDown, ref double multiplyDamageDown, ref double multiplyMultiplyDamageDown)
	{
	}

	public virtual double GetAttackDefenceIgnore(BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual float GetCriticalDefence(BattleObjectBase target)
	{
		return 0f;
	}

	public virtual double GetSkillDamage(int skillId, BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual double GetSkillAttributeDamage(int skillId, BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual double GetBeltAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual double GetRingAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public virtual float GetScale()
	{
		return 0f;
	}

	public virtual bool IsTargeting()
	{
		return false;
	}

	public virtual void SetFlipX(bool isFlip)
	{
	}

	public virtual bool GetFlipX()
	{
		return false;
	}

	public virtual float GetEffectScale()
	{
		return 0f;
	}

	public virtual Vector3 GetCenterPos()
	{
		return default(Vector3);
	}

	public virtual Vector3 GetArrowAttackOffset(bool isLeft, DesignSkill.Data designSkill)
	{
		return default(Vector3);
	}

	public virtual Vector3 GetHitOffset(bool isAttackerLeft)
	{
		return default(Vector3);
	}

	public virtual Vector3 GetSelfHitOffset()
	{
		return default(Vector3);
	}

	public virtual void ChangeColor(Color color, float time)
	{
	}

	public virtual void ResetColor()
	{
	}

	public virtual void KnockBack(BattleObjectBase attacker, float move, float time)
	{
	}

	public virtual void KnockBackAxis(BattleObjectBase attacker, bool axisX, float move, float time)
	{
	}

	public virtual void Dash()
	{
	}

	public virtual void Stun(float time)
	{
	}

	public virtual void StunRemove(float time)
	{
	}

	public virtual void Freeze(float time)
	{
	}

	public virtual void FreezeRemove(float time)
	{
	}

	public virtual void ShieldHP(double hp)
	{
	}

	public virtual void ShieldHPRemove(double hp)
	{
	}

	public virtual void ShieldCount(int count)
	{
	}

	public virtual void ShieldCountRemove(int count)
	{
	}

	public virtual void CancelAttackSchedule(BattleObjectBase target)
	{
	}

	public virtual void AddSkillConditionValue(DesignSkill.Data.Condition conditionType, int count = 1)
	{
	}

	public virtual void HitShaking(float time)
	{
	}

	public virtual void AddBuff(BuffCondition.BuffData buffData)
	{
	}

	public virtual void RemoveBuff(DesignSkillFunction.Data designSkillFunction)
	{
	}

	public virtual List<BuffCondition.BuffData> GetBuffData(DesignSkillFunction.Data.FunctionType functionType)
	{
		return null;
	}

	public virtual double GetBuffValue(DesignSkillFunction.Data.FunctionType functionType, int attribute = -1)
	{
		return 0.0;
	}

	public virtual int GetBuffCount(DesignBuff.Data.BuffType buffType)
	{
		return 0;
	}

	public virtual int GetBuffCount(List<int> buffSkillIds)
	{
		return 0;
	}

	public virtual void AttackHeal()
	{
	}

	public bool CheckAttackDistance(List<int> attackGroundType, BattleObjectBase target, float optionalAttackDistance = 0f)
	{
		return false;
	}

	public double ActionSkill(BattleObjectBase target, DesignSkill.Data designSkill, DesignSkillFunction.Data designSkillFunction, int baseSkillLevel, int contentsSkillLevel)
	{
		return 0.0;
	}

	public void ManualAttack(BattleObjectBase target, float skillOffset, float optionOffset, int damageEffect, int damageCastingTimeAttackEffect, DesignSkill.Data designSkill)
	{
	}

	public void Damage(int skillId, BattleObjectBase attacker, double attack, int damageCastingTimeAttackEffect, int damageEffect, bool isLeft, CriticalType criticalType, bool isAngleEffect)
	{
	}

	public void HPHeal(double heal)
	{
	}

	public void MPHeal(double heal)
	{
	}

	private void AddDamageLabel(string value, GameObject prefab, Vector3 hitOffset)
	{
	}

	public void AddImmuneLabel(int attribute, Vector3 hitOffset)
	{
	}

	private void AddBlockLabel(Vector3 hitOffset)
	{
	}

	private void AddAvoidLabel(Vector3 hitOffset)
	{
	}

	public bool CheckDistance(BattleObjectBase attacker, float distance)
	{
		return false;
	}

	public void Reflect(BattleObjectBase attacker, double damage)
	{
	}

	public void ReflectRate(BattleObjectBase attacker, double damage)
	{
	}

	public void CountAttack(BattleObjectBase attacker)
	{
	}

	public void CountAttack2(BattleObjectBase attacker)
	{
	}

	public GameObject AddEffect(int skillEffect, Vector3 hitOffset)
	{
		return null;
	}

	public void AddBuffEffect(int skillEffectId, string name)
	{
	}

	public void RemoveBuffEffect(string name)
	{
	}

	public BattleObjectBase GetTarget()
	{
		return null;
	}

	public void SetTarget(BattleObjectBase target)
	{
	}

	public void Result(bool isWin)
	{
	}

	public virtual void ShowBoxLine(bool isShow)
	{
	}
}
