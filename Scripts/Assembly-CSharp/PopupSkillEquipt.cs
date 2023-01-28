using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupSkillEquipt")]
public class PopupSkillEquipt : PopupBase
{
	private int _changeSkillId;

	private RadioGroup _radioGroup;

	private List<SkillCard> _skillCards;

	private int _curSlot;

	private Dictionary<int, SkillEquip> _skillEquipList;

	public void InitPopup(int skillId)
	{
	}

	private void SelectSkillSlot(string select)
	{
	}

	private void UpdateSkillCard()
	{
	}

	private void SelectEquip(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
