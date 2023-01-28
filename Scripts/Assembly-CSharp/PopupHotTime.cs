using UnityEngine;

[AddComponentMenu("Popup/PopupHotTime")]
public class PopupHotTime : PopupBase
{
	private UIScrollView _scrollView;

	private GameObject _prefabHotTimeGroup;

	private GameObject _prefabHotTimeCharCondition;

	private Transform _groupForm;

	private GameObject _prefabHotInfo;

	public void InitPopup()
	{
	}

	public void UpdateState()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
