using UnityEngine;

[AddComponentMenu("Popup/PopupCharacterInfo")]
public class PopupCharacterInfo : PopupBase
{
	private GameObject _prefab;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private Character _character;

	public void InitPopup()
	{
	}

	private void UpdateInfo()
	{
	}

	private string GetValue(DesignContentsFunctionList.Data designContentsFunctionList)
	{
		return null;
	}

	private void AddContentsFunction(int name, string value)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
