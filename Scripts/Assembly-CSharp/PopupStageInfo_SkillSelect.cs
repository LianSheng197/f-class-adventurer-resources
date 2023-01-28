using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupStageInfo_SkillSelect")]
public class PopupStageInfo_SkillSelect : PopupBase
{
	private int _stageId;

	private string _sceneName;

	private SceneDirector.LoadingType _loadingType;

	private RadioGroup _radioGroup;

	private List<SkillCard> _skillCards;

	private int _selectSlot;

	private int _curSlot;

	private Dictionary<int, SkillEquip> _skillEquipList;

	public void InitPopup(int stageId, string sceneName, SceneDirector.LoadingType loadingType)
	{
	}

	private void SelectSkillSlot(string select)
	{
	}

	private void UpdateSkillCard()
	{
	}

	private void SelectSkill(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
