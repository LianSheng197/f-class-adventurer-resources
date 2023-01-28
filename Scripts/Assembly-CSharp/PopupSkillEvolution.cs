using UnityEngine;

[AddComponentMenu("Popup/PopupSkillEvolution")]
public class PopupSkillEvolution : PopupBase
{
	private PopupSkill _popupSkill;

	private Skill _next;

	private GameObject _effectPosition;

	public void InitPopup(PopupSkill popupSkill, int skillId)
	{
	}

	public void EvolutionUp()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
