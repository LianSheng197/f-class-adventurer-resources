using UnityEngine;

public class SkillCard : MonoBehaviour
{
	public static SpriteData _evolutionBackground;

	private Skill _skill;

	private bool _isSubInfo;

	private DesignCharacterSkill.Data _designCharacterSkill;

	private DesignSkill.Data _designSkill;

	private DesignSkillFameUp.Data _designSkillFameUp;

	private DesignSkillEvolutionUp.Data _designSkillEvolutionUp;

	private DesignSkillGrade.Data _designSkillGrade;

	private DesignSkillFame.Data _designSkillFame;

	private GameObject _on;

	private BattleData _battleData;

	private float _coolTime;

	private GameObject _coolTimeObj;

	private UISprite _coolTimeSprite;

	private UILabel _coolTimeLabel;

	private float _globalCoolTimeMax;

	private float _globalCoolTime;

	private GameObject _globalCoolTimeObj;

	private UISprite _globalCoolTimeSprite;

	private bool _changeCoolTime;

	public static SkillCard Add(GameObject parent, int skillId, bool isSubInfo)
	{
		return null;
	}

	public static SkillCard Add(GameObject parent, Skill skill, bool isSubInfo)
	{
		return null;
	}

	private void Update()
	{
	}

	public Skill GetSkill()
	{
		return null;
	}

	public void SetCard(int skillId, bool isSubInfo)
	{
	}

	public void SetCard(Skill skill, bool isSubInfo)
	{
	}

	public void UpdateInfo()
	{
	}

	public void UpdateSubInfo()
	{
	}

	public void HideCount()
	{
	}

	public void HideLevel()
	{
	}

	public void NotHave(bool isNotHave)
	{
	}

	public void Equip(bool isEquip)
	{
	}

	public void SetNew(bool isNew)
	{
	}

	public void SetAuto(bool isAuto)
	{
	}

	public UIWidget GetRenderTarget()
	{
		return null;
	}

	public void SetBattleData(BattleData battleData)
	{
	}

	public float CalcCoolTime()
	{
		return 0f;
	}

	public void SetCoolTimeBackUp(float coolTime)
	{
	}

	public void SetCoolTime()
	{
	}

	public void SetGlobalCoolTime(BattleObjectHero user)
	{
	}

	public bool IsCoolTime()
	{
		return false;
	}

	public bool IsCoolTimeAndGlobalCoolTime()
	{
		return false;
	}

	public float GetCoolTime()
	{
		return 0f;
	}

	public void SetChangeCoolTime()
	{
	}

	private void UpdateCoolTime()
	{
	}
}
