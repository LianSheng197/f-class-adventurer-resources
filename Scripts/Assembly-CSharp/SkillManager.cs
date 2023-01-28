using System.Collections.Generic;

public class SkillManager
{
	private static SkillManager _Instance;

	private Dictionary<int, Skill> _skillList;

	private Dictionary<int, SkillEquip> _skillEquipList;

	private List<ContentsFunctionData> _contentsFunctionData;

	private Dictionary<int, List<bool>> _skillAutoSetting;

	private Dictionary<int, List<bool>> _skillAutoSettingCustom;

	public static SkillManager Instance => null;

	public void SetSkillList(List<Skill> list)
	{
	}

	public void SetSkill(Skill skill, bool contentsFunctionDataUpdate = true)
	{
	}

	public bool IsHave(int skillId)
	{
		return false;
	}

	public List<Skill> GetSkill()
	{
		return null;
	}

	public Skill GetSkill(int skillId)
	{
		return null;
	}

	public int GetSkillLevel(int skillId)
	{
		return 0;
	}

	public void GetSumSkillLevel(out int sumSkillLevel1, out int sumSkillLevel2)
	{
		sumSkillLevel1 = default(int);
		sumSkillLevel2 = default(int);
	}

	public int GetSkillFame(int skillId)
	{
		return 0;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public void SetSkillEquipList(List<SkillEquip> list)
	{
	}

	public void SetSkillEquip(SkillEquip skillEquip)
	{
	}

	public bool IsEquip(int skillId)
	{
		return false;
	}

	public SkillEquip GetSkillEquip(int slot)
	{
		return null;
	}

	public void UpdateSkillMission()
	{
	}

	public bool IsNew()
	{
		return false;
	}

	public bool IsGet(int skillId)
	{
		return false;
	}

	public bool IsFameUp(int skillId)
	{
		return false;
	}

	public long GetBattlePoint()
	{
		return 0L;
	}

	public Dictionary<int, long> GetSellList(int skillId)
	{
		return null;
	}

	public Dictionary<int, long> GetSellList()
	{
		return null;
	}

	public Dictionary<int, Skill> GetSkillList()
	{
		return null;
	}

	public List<bool> GetAutoSetting(int slot)
	{
		return null;
	}

	public void SetAutoSetting(int slot, List<bool> settings)
	{
	}

	public void SetAutoSetting(int slot, int index, bool isAuto)
	{
	}

	public bool IsAutoSetting(int slot, int index)
	{
		return false;
	}

	public List<bool> GetAutoSettingCustom(int slot)
	{
		return null;
	}

	public void SetAutoSettingCustom(int slot, List<bool> settings)
	{
	}

	public void SetAutoSettingCustom(int slot, int index, bool isAuto)
	{
	}

	public bool IsCustom(int slot, List<bool> settings)
	{
		return false;
	}

	public void ClearSkillAutoSetting()
	{
	}

	private void InitSkillAutoSetting()
	{
	}
}
