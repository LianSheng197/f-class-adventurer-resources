using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupNameInput")]
public class PopupNameInput : PopupBase
{
	private UIInput _input;

	private MailSet _mailSet;

	private bool _isClose;

	private GameObject _closeBtn;

	public void InitPopup(MailSet mailSet)
	{
	}

	public void InitPopup(bool isClose = true)
	{
	}

	public void OnChange()
	{
	}

	public void OnSubmit()
	{
	}

	public void ChangeName(string name, UIButton reqButton)
	{
	}

	public void ChangeSuccess(string prevUserName, List<ItemReward> rewards)
	{
	}

	public void ChangeSuccessMail()
	{
	}

	public void ChangeFailed(WWWData.STATE state)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
