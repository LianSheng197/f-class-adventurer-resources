using UnityEngine;

[AddComponentMenu("Popup/PopupPolicy")]
public class PopupPolicy : PopupBase
{
	private short _policyVersion;

	private int _agreeCount;

	private int _agree;

	public void InitPopup(short policyVersion)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
