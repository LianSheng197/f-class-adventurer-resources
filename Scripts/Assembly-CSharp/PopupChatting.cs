using System;
using UnityEngine;

[AddComponentMenu("Popup/PopupChatting")]
public class PopupChatting : PopupBase
{
	private UIInput _input;

	private UILabel _inputLabel;

	private UIScrollView _scrollView;

	private GameObject _prefabChatItem;

	private GameObject _chatChildList;

	private byte _tab;

	private bool _init;

	private LimitedSizeList<DateTime> _checkOverChat;

	private UserInformation _reqUserInfo;

	private bool _isAutoScroll;

	private UIGrid _channelGrid;

	private Transform _channelChangeRoot;

	private float _accumPosY;

	private float _prevChatItemSizeY;

	public void InitPopup(byte tab)
	{
	}

	public void UpdateCurTab()
	{
	}

	private void UpdateTab(byte tab)
	{
	}

	public void UpdateChatList()
	{
	}

	public void UpdateGuildTab()
	{
	}

	private void DragScrollView()
	{
	}

	private void DownScrollView()
	{
	}

	private void onStoppedMoving()
	{
	}

	private void UpdateList()
	{
	}

	public void AddChat(ChatData data)
	{
	}

	public void AddChatObj(ChatData data, out GameObject chatObj)
	{
		chatObj = null;
	}

	private void SetRankingIcon(Transform RankingIcon, int rankIndex)
	{
	}

	private void ChatClear()
	{
	}

	private void InputSubmit()
	{
	}

	private bool CheckOverChat()
	{
		return false;
	}

	public UserInformation GetRequestUserInfo()
	{
		return null;
	}

	private void EnableChannelList(bool enabled)
	{
	}

	private void MessageCopy(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void MoveChannel(UIButton btn)
	{
	}
}
