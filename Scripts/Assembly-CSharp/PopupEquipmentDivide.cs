using UnityEngine;

[AddComponentMenu("Popup/PopupEquipmentDivide")]
public class PopupEquipmentDivide : PopupBase
{
	private DesignItem.Data _designItem;

	private DesignEquipment.Data _designEquipment;

	private EquipmentCard _beforeIcon;

	private UILabel _beforeCount;

	private EquipmentCard _afterIcon;

	private UILabel _afterCount;

	private UISlider _slider;

	private long _changeCount;

	private long _upgradeMaxCount;

	private ItemReward _cost;

	private UILabel _costLabel;

	public void InitPopup(int itemId)
	{
	}

	private void SliderChange()
	{
	}

	private void UpdateCount()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
