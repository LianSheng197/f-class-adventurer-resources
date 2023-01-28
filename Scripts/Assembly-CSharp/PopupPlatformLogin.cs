using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupPlatformLogin")]
public class PopupPlatformLogin : PopupBase
{
	public static bool IsAnswer;

	private Dictionary<IntegrationReq.LoginType, Transform> _btnList;

	public IntegrationReq.LoginType _integrationType;

	public string _integrationKey;

	public string _integrationLoginId;

	public void InitPopup()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void CallBackGuestLogin(GameObject obj, UIButton btn)
	{
	}

	public void IntegrationAck(IntegrationReq req, IntegrationAck ack)
	{
	}
}
