using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupMailGetAll")]
public class PopupMailGetAll : PopupBase
{
	public delegate void CallBackClose();

	private CallBackClose _callBack;

	public void InitPopup(List<ItemReward> result, CallBackClose callBack = null)
	{
	}

	public void InitPopupBossSweep(List<ItemReward> reward, List<ItemReward> randomList, CallBackClose callBack = null)
	{
	}

	public void SetExp(string exp)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
