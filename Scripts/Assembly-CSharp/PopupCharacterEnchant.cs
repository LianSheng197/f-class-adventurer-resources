using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupCharacterEnchant")]
public class PopupCharacterEnchant : PopupBase
{
	private Character _character;

	private Character _prevCharacter;

	private List<AutoCurrency> _currency;

	private Item selectItem;

	private int selectEquipSlot;

	public void InitPopup(Character character)
	{
	}

	public void UpdateInformation()
	{
	}

	private void SelectItem(UIButton btn)
	{
	}

	public void OnSelectItem()
	{
	}

	public void OnEquip()
	{
	}

	public void OnEnchant()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
