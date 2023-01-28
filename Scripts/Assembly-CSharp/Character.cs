using System;
using System.Collections.Generic;

[Serializable]
public class Character : BaseObject
{
	public int _level;

	public List<bool> _equip;

	public List<int> _magicList;

	[NonSerialized]
	private DesignCharacter.Data _designData;

	[NonSerialized]
	public bool _isUser;

	[NonSerialized]
	public List<int> _addSkills;

	[NonSerialized]
	public bool _isInitBaseContentsFunction;

	[NonSerialized]
	private List<ContentsFunctionData> _baseContentsFunction;

	[NonSerialized]
	private Dictionary<int, List<ContentsFunctionData>> _dicBaseContentsFunction;

	[NonSerialized]
	public bool _isBook;

	[NonSerialized]
	public int _legendId;

	private int _prevLevel;

	private DesignCharacterLevel.Data _designCL;

	private int _prevGrade;

	private DesignCharacterUpgrade.Data _designCU;

	private static DesignCharacterEnchant _designCE;

	private static DesignCharacterMagic _designCM;

	private static DesignContentsFunction _designCF;

	private static DesignSkill _designSkill;

	public void Copy(ref Character data)
	{
	}

	public new Character Copy()
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

	public DesignCharacterGrade.Data GetDesignCharacterGrade()
	{
		return null;
	}

	public DesignCharacterFame.Data GetDesignCharacterFame()
	{
		return null;
	}

	public DesignCharacterAttribute.Data GetDesignCharacterAttribute()
	{
		return null;
	}

	public List<DesignCharacterFeature.Data> GetDesignCharacterFeature()
	{
		return null;
	}

	public DesignCharacterType.Data GetDesignCharacterType()
	{
		return null;
	}

	public DesignCharacterNation.Data GetDesignCharacterNation()
	{
		return null;
	}

	public DesignCharacterAttackType.Data GetDesignCharacterAttackType()
	{
		return null;
	}

	public DesignCharacterGroundType.Data GetDesignCharacterGroundType()
	{
		return null;
	}

	public DesignCharacterLevel.Data GetDesignCharacterLevel()
	{
		return null;
	}

	public DesignCharacterUpgrade.Data GetDesignCharacterUpgrade()
	{
		return null;
	}

	public DesignCharacterEnchant.Data GetDesignCharacterEnchant()
	{
		return null;
	}

	public DesignCharacterEnchant.Data GetDesignCharacterEnchantNext()
	{
		return null;
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public List<ContentsFunctionData> GetContentsFunctionList(int functionType)
	{
		return null;
	}

	public List<ContentsFunctionData> GetEnchantContentsFunctionList()
	{
		return null;
	}

	public bool IsEquip(int index)
	{
		return false;
	}

	public bool IsEnchant()
	{
		return false;
	}

	public bool IsEnchantAlarm()
	{
		return false;
	}

	public override string GetName()
	{
		return null;
	}

	private double GetGrowStat(double growValue)
	{
		return 0.0;
	}

	public double GetHp(DesignStage.Data designStage = null)
	{
		return 0.0;
	}

	public double GetHpBase()
	{
		return 0.0;
	}

	public double GetMp(DesignStage.Data designStage = null)
	{
		return 0.0;
	}

	public double GetMpBase()
	{
		return 0.0;
	}

	public double GetAttack(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetAttackBase()
	{
		return 0.0;
	}

	public double GetDefence(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetDefenceBase()
	{
		return 0.0;
	}

	public void GetDamageCalcValue(DesignStage.Data designStage, BattleObjectHero target, ref double sumDamageUp, ref double multiplyDamageUp, ref double multiplyMultiplyDamageUp, ref double sumDamageDown, ref double multiplyDamageDown, ref double multiplyMultiplyDamageDown)
	{
	}

	public double GetDamageCalc(double damage, DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetAttackDefenceIgnore(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public float GetCriticalDefence(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0f;
	}

	public double GetSkillDamage(int skillId, DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetSkillAttributeDamage(int skillId, DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetBeltAttack(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public double GetRingAttack(DesignStage.Data designStage = null, BattleObjectHero target = null)
	{
		return 0.0;
	}

	public float GetAttackSpeed(DesignStage.Data designStage = null)
	{
		return 0f;
	}

	public float GetAttackSpeedBase()
	{
		return 0f;
	}

	public int GetAttackDistance(DesignStage.Data designStage = null)
	{
		return 0;
	}

	public float GetMoveSpeed(DesignStage.Data designStage = null)
	{
		return 0f;
	}

	public float GetMoveSpeedBase()
	{
		return 0f;
	}

	public int GetFame()
	{
		return 0;
	}

	public int GetAttribute()
	{
		return 0;
	}

	public int GetNation()
	{
		return 0;
	}

	public float GetScale()
	{
		return 0f;
	}

	public float GetEffectScale()
	{
		return 0f;
	}

	public DesignCharacter.Data.GroundType GetGroundType()
	{
		return default(DesignCharacter.Data.GroundType);
	}

	public float GetSize()
	{
		return 0f;
	}

	public int GetTargetOrder()
	{
		return 0;
	}

	public List<int> GetAttackGroundType()
	{
		return null;
	}

	public List<DesignSkill.Data> GetSkillList()
	{
		return null;
	}

	public DesignSkill.Data GetSkill(int index)
	{
		return null;
	}

	public void SetMagicList(List<int> magicList)
	{
	}

	public List<DesignCharacterMagic.Data> GetMagicList()
	{
		return null;
	}
}
