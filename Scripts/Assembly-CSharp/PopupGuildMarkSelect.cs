using UnityEngine;

public class PopupGuildMarkSelect : PopupBase
{
	public delegate void CallbackSelectMark(string markName);

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private GameObject _prefabGuildMarkItem;

	private Transform _selectMark;

	private CallbackSelectMark _onSelectMark;

	public void Init(string selectName, CallbackSelectMark del)
	{
	}

	private Transform Find(string markName)
	{
		return null;
	}

	private void SelectMark(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
