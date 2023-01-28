using UnityEngine;

[AddComponentMenu("Popup/PopupEquipmentUpgrade")]
public class PopupEquipmentUpgrade : PopupBase
{
	private PopupEquipment _popupEquipment;

	private CollectionViewArtifact _artifactView;

	private DesignEquipment.Data _designEquipment;

	private Transform _normalForm;

	private Transform _beforeIcon;

	private UILabel _beforeCount;

	private Transform _afterIcon;

	private UILabel _afterCount;

	private UISlider _slider;

	private Transform _lastEndForm;

	private Transform _lastEndIcon;

	private long _changeCount;

	private long _upgradeMaxCount;

	private GameObject _left;

	private GameObject _right;

	public void SetParent(PopupEquipment popupEquipment)
	{
	}

	public void SetParent(CollectionViewArtifact artifactView)
	{
	}

	public void InitPopup(DesignEquipment.Data designEquipment)
	{
	}

	public void SetEquipment(DesignEquipment.Data designEquipment)
	{
	}

	public void Ack()
	{
	}

	private void AckUpdate()
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
