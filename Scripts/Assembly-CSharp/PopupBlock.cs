using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupBlock")]
public class PopupBlock : PopupBase
{
	private UIScrollView _scrollView;

	private GameObject _prefabBlockItem;

	private List<ChatBlockInfo> _sortList;

	private WWWRemoveChatBlock _www;

	public void InitPopup()
	{
	}

	public void UpdateInfo()
	{
	}

	private void UpdateViewList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public void OnBlock(UIButton btn)
	{
	}

	public void OnRemoveBlock(GameObject popupObj, UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
