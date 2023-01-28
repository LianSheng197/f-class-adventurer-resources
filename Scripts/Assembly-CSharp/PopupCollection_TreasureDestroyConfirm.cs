using UnityEngine;

[AddComponentMenu("Popup/PopupCollection_TreasureDestroyConfirm")]
public class PopupCollection_TreasureDestroyConfirm : PopupBase
{
	private TreasureData _treasure;

	private DesignTreasurePrice.Data _designTreasurePrice;

	public void InitPopup(int treasureId)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
