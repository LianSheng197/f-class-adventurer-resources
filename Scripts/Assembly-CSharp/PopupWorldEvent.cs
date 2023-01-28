using UnityEngine;

[AddComponentMenu("Popup/PopupWorldEvent")]
public class PopupWorldEvent : PopupBase
{
	private WorldViewEvent _view;

	public void InitPopup(int returnStageId = 0)
	{
	}

	public void RefreshWorldList()
	{
	}

	public WorldViewEvent GetView()
	{
		return null;
	}

	public override void Message(UIButton btn)
	{
	}
}
