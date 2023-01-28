using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupMailGet")]
public class PopupMailGet : PopupBase
{
	private bool _mainNextNotice;

	public void InitPopup(List<ItemReward> result, bool isShowDesc = false, bool mainNextNotice = false)
	{
	}

	public void InitPopup(ItemReward result, bool isShowDesc = false, bool mainNextNotice = false)
	{
	}

	public void InitPopupShop(ItemReward result)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
