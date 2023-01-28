using UnityEngine;

[AddComponentMenu("Popup/PopupBuyConfirm")]
public class PopupBuyConfirm : PopupBase
{
	public delegate void BuyConfirmDelegate(bool buyConfirm);

	private BuyConfirmDelegate _buyConfirmCallback;

	public void InitPopup(int languageId, int itemId, long count, BuyConfirmDelegate callBack)
	{
	}

	public void InitPopup(int itemId, long count, BuyConfirmDelegate callBack)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
