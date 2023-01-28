using UnityEngine;

[AddComponentMenu("Popup/PopupEquipmentEnchant_Charm")]
public class PopupEquipmentEnchant_Charm : PopupBase
{
	private PopupEquipment _popupEquipment;

	private DesignEquipment.Data _designEquipment;

	private Transform _normalForm;

	private Transform _beforeIcon;

	private UILabel _beforeCount;

	private Transform _afterIcon;

	private UILabel _afterCount;

	private Transform _lastEndForm;

	private Transform _lastEndIcon;

	private GameObject _left;

	private GameObject _right;

	private UIGrid _gridNeedItem;

	private UILabel _successRate;

	private int _currentLevel;

	public void InitPopup(PopupEquipment popupEquipment, DesignEquipment.Data designEquipment)
	{
	}

	public void SetEquipment(DesignEquipment.Data designEquipment)
	{
	}

	private void AckUpdate()
	{
	}

	public void CallbackEnchant(WWWData data)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
