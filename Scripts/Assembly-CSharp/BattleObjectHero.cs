using System.Collections.Generic;
using UnityEngine;

public class BattleObjectHero : BattleObjectBase
{
	public class AttackScheduleData
	{
		public bool _isUse;

		public bool _isBaseSkill;

		public float _time;

		public SkillTarget.SkillTargetData _skillTargetData;
	}

	private const int ATTACK_SCHEDULE_POOLCOUNT = 30;

	private DesignCharacter.Data _designCharacter;

	private DesignActor.Data _designActor;

	private Character _character;

	private CharacterResBase _characterResBase;

	private Vector3 _bornPosition;

	private Vector3 _moveAroundPosition;

	public int _respawnIndex;

	private List<SkillTarget.SkillTargetData> _targetDataList;

	private List<AttackScheduleData> _attackSchedule;

	private SkillCondition _skillCondition;

	private FindNearTarget _findNearTarget;

	private BuffCondition _buffCondition;

	private List<BattleObjectBase> _removeRangeList;

	private List<SkillTarget.Target> _removeTargetList;

	private Transform _uiForm;

	private GameObject _hpObj;

	private BattleDPad _battleDPad;

	private bool _isExclamationMark;

	private GameObject _exclamationMark;

	private float _moveSpeedOffset;

	private float _healCoolTime;

	private List<int> _removeReflectBuffData;

	private SkillSummonData _skillSummonData;

	private void Update()
	{
	}

	private void UpdateProcess()
	{
	}

	private void UpdateProcessSkillSummon()
	{
	}

	public override void InitCollider()
	{
	}

	public override void UpdateHP()
	{
	}

	public override void SetDeath()
	{
	}

	public override string GetLogName()
	{
		return null;
	}

	public override float GetAttackDistance()
	{
		return 0f;
	}

	public override int GetTargetOrder()
	{
		return 0;
	}

	public override double GetAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public override double GetDefence(BattleObjectBase target)
	{
		return 0.0;
	}

	public override double GetDamageCalc(double damage, BattleObjectBase target)
	{
		return 0.0;
	}

	public override void GetDamageCalcValue(BattleObjectBase target, ref double sumDamageUp, ref double multiplyDamageUp, ref double multiplyMultiplyDamageUp, ref double sumDamageDown, ref double multiplyDamageDown, ref double multiplyMultiplyDamageDown)
	{
	}

	public override double GetAttackDefenceIgnore(BattleObjectBase target)
	{
		return 0.0;
	}

	public override float GetCriticalDefence(BattleObjectBase target)
	{
		return 0f;
	}

	public override double GetSkillDamage(int skillId, BattleObjectBase target)
	{
		return 0.0;
	}

	public override double GetSkillAttributeDamage(int skillId, BattleObjectBase target)
	{
		return 0.0;
	}

	public override double GetBeltAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public override double GetRingAttack(BattleObjectBase target)
	{
		return 0.0;
	}

	public override float GetScale()
	{
		return 0f;
	}

	public override bool IsTargeting()
	{
		return false;
	}

	public override void SetFlipX(bool isFlipX)
	{
	}

	public override bool GetFlipX()
	{
		return false;
	}

	public override float GetEffectScale()
	{
		return 0f;
	}

	public override Vector3 GetArrowAttackOffset(bool isLeft, DesignSkill.Data designSkill)
	{
		return default(Vector3);
	}

	public override Vector3 GetHitOffset(bool isAttackerLeft)
	{
		return default(Vector3);
	}

	public override void ChangeColor(Color color, float time)
	{
	}

	public override void ResetColor()
	{
	}

	public override void KnockBack(BattleObjectBase attacker, float move, float time)
	{
	}

	public override void KnockBackAxis(BattleObjectBase attacker, bool axisX, float move, float time)
	{
	}

	public void EndKnockBack(GameObject obj, int userData1, int userData2)
	{
	}

	public override void Dash()
	{
	}

	public void EndDash(GameObject obj, int userData1, int userData2)
	{
	}

	public override void Stun(float time)
	{
	}

	public override void StunRemove(float time)
	{
	}

	public override void Freeze(float time)
	{
	}

	public override void FreezeRemove(float time)
	{
	}

	public override void ShieldHP(double hp)
	{
	}

	public override void ShieldHPRemove(double hp)
	{
	}

	public override void ShieldCount(int count)
	{
	}

	public override void ShieldCountRemove(int count)
	{
	}

	public override void CancelAttackSchedule(BattleObjectBase target)
	{
	}

	public override void AddSkillConditionValue(DesignSkill.Data.Condition conditionType, int count = 1)
	{
	}

	public override void AddBuff(BuffCondition.BuffData buffData)
	{
	}

	public override void RemoveBuff(DesignSkillFunction.Data designSkillFunction)
	{
	}

	public override List<BuffCondition.BuffData> GetBuffData(DesignSkillFunction.Data.FunctionType functionType)
	{
		return null;
	}

	public override double GetBuffValue(DesignSkillFunction.Data.FunctionType functionType, int attribute = -1)
	{
		return 0.0;
	}

	public override int GetBuffCount(DesignBuff.Data.BuffType buffType)
	{
		return 0;
	}

	public override int GetBuffCount(List<int> buffSkillIds)
	{
		return 0;
	}

	private void InitValue()
	{
	}

	public void Init(Character character, Vector3 pos, UIWidget renderTarget, int renderQValue)
	{
	}

	public void SetCharacter(Character character)
	{
	}

	public void SetCharacterRes()
	{
	}

	public void SetWeapon(int itemId)
	{
	}

	public void AdjustSummonPos(float offsetX)
	{
	}

	public void SetSkillSummon(float summonTime)
	{
	}

	public Character GetCharacter()
	{
		return null;
	}

	public DesignCharacter.Data GetDesignCharacter()
	{
		return null;
	}

	public DesignActor.Data GetDesignActor()
	{
		return null;
	}

	private string GetCurrentAnimation()
	{
		return null;
	}

	public void ChangeAnimation(string animation)
	{
	}

	public void StopAnimation()
	{
	}

	public void Death()
	{
	}

	public void SetWin()
	{
	}

	public void SetLose()
	{
	}

	private void Heal()
	{
	}

	private void KillHeal()
	{
	}

	public override void AttackHeal()
	{
	}

	private bool Attack()
	{
		return false;
	}

	public void FindTarget(ref List<SkillTarget.SkillTargetData> targetList, DesignSkill.Data designSkill, int baseSkillLevel, int contentsSkillLevel)
	{
	}

	public void UseSkill(List<SkillCondition.SkillConditionData> useSkillData, int baseSkillLevel, int contentsSkillLevel)
	{
	}

	private void UseSkill(SkillTarget.SkillTargetData skillTargetData)
	{
	}

	private void Move()
	{
	}

	private bool MoveDPad()
	{
		return false;
	}

	private void MoveDir(Vector3 dir, bool isDPad = false)
	{
	}

	private void MoveAround()
	{
	}

	private void InitAttackSchedule()
	{
	}

	private void ClearAttackSchedule(bool onlyBaseSkill = false)
	{
	}

	private AttackScheduleData PoolAttackSchedule()
	{
		return null;
	}

	private void ProcessAttackSchedule()
	{
	}

	private void RemoveAttackSchedule(BattleObjectBase removeTarget)
	{
	}

	public void ShowExclamationMark()
	{
	}

	private void EndExclamationMark(GameObject obj)
	{
	}

	public void ShowMoveSay()
	{
	}
}
