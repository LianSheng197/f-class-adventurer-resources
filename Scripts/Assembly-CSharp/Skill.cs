using System;

[Serializable]
public class Skill
{
	public int _skillId;

	public int _level;

	public int fame;

	private DesignSkill.Data _designSkill;

	private DesignCharacterSkill.Data _designChaSkill;

	private int _prevLevel;

	private DesignSkillLevel.Data _designSkillLevel;

	private int _prevFameUp;

	private DesignSkillFameUp.Data _designSFU;

	private int _prevFame;

	private DesignSkillFame.Data _designSF;

	private DesignSkillGrade.Data _designSG;

	private int _prevEvoUp;

	private DesignSkillEvolutionUp.Data _designSE;

	public int _fame
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int _evolution
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public DesignSkill.Data GetDesignSkill()
	{
		return null;
	}

	public DesignCharacterSkill.Data GetDesignCharacterSkill()
	{
		return null;
	}

	public DesignSkillLevel.Data GetDesignSkillLevel()
	{
		return null;
	}

	public DesignSkillFameUp.Data GetDesignSkillFameUp()
	{
		return null;
	}

	public DesignSkillFame.Data GetDesignSkillFame()
	{
		return null;
	}

	public DesignSkillGrade.Data GetDesignSkillGrade()
	{
		return null;
	}

	public DesignSkillEvolutionUp.Data GetDesignSkillEvolutionUp()
	{
		return null;
	}

	public string GetSkillDescription()
	{
		return null;
	}
}
