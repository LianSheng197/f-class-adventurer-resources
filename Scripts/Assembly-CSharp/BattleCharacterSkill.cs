using System.Collections.Generic;
using UnityEngine;

public class BattleCharacterSkill : MonoBehaviour
{
	private BattleData _battleData;

	private bool _firstBackUpCoolTime;

	private bool _firstGlobalCoolTime;

	private int _curSkillSlot;

	private RadioGroup _skillFilter;

	private Animation _skillFilterAnimation;

	private bool _isSlotChange;

	private List<SkillCondition.SkillConditionData> _skillConditionData;

	private SkillCondition.SkillConditionData _conditionData;

	private List<SkillTarget.SkillTargetData> _targetDataList;

	private List<Transform> _skillCardParent;

	private List<Vector3> _skillCardParentPos;

	private List<SkillCard> _skillCard;

	private Transform _auto;

	private void Update()
	{
	}

	public void Init(BattleData battleData)
	{
	}

	public void SetChangeCharacterSkillCoolTime(int skillId)
	{
	}

	private void InitSkill()
	{
	}

	private void FilterSlotChange(bool isChange, bool isInit)
	{
	}

	private void ChangeSlot(UIButton btn)
	{
	}

	private void SelectSkillSlot(string select)
	{
	}

	public void UpdateSkillInfo(bool backUpCoolTime)
	{
	}

	private void UseSkill(UIButton btn)
	{
	}

	private void ActionSkill(SkillCard skillCard)
	{
	}

	public void UseAuto(UIButton btn)
	{
	}

	private void UpdateAutoSkill()
	{
	}

	private void UpdateSkillAutoSetting()
	{
	}

	private void onDragSkillCard(GameObject target, Vector2 delta)
	{
	}
}
