using UnityEngine;

[AddComponentMenu("Popup/PopupEvent_CardOpenRewardList")]
public class PopupEvent_CardOpenRewardList : PopupBase
{
	private int _eventId;

	private int _curPage;

	private int _page;

	private int _maxPage;

	private UILabel _pageLabel;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private GameObject _complete;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private GameObject _prefab;

	public void InitPopup(DesignCardEvent.Data designCardEvent)
	{
	}

	private void UpdatePage()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
