using UnityEngine;

[AddComponentMenu("Popup/PopupEquipmentExpandLevel")]
public class PopupEquipmentExpandLevel : PopupBase
{
	private PopupEquipment _popupEquipment;

	private CollectionViewArtifact _artifactView;

	private Equipment _equipment;

	private DesignEquipment.Data _designEquipment;

	private DesignEquipmentExpandLevel.Data _designEquipmentExpandLevel;

	public void SetParent(PopupEquipment popupEquipment)
	{
	}

	public void SetParent(CollectionViewArtifact artifactView)
	{
	}

	public void InitPopup(int itemId)
	{
	}

	public void AckExpandLevel()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
