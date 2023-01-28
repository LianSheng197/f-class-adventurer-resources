using UnityEngine;

[AddComponentMenu("Popup/PopupItemInfoNormal")]
public class PopupItemInfoNormal : PopupBase
{
	public enum FormType
	{
		Normal = 0,
		Enchant = 1,
		Max = 2
	}

	private FormType _formType;

	private Item _item;

	private bool _sellPossible;

	private Transform _targetForm;

	public void InitPopupNormal(Item item)
	{
	}

	public void InitPopupSelect(Item item)
	{
	}

	public void InitPopupSummon(Item item)
	{
	}

	private void InitPopup(FormType formType, Item item)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
