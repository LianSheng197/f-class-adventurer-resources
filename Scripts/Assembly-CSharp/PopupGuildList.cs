using System;
using System.Collections.Generic;
using UnityEngine;

public class PopupGuildList : PopupBase
{
	private GameObject _prefabGuildListItem;

	private Transform _guildInfoRoot;

	private Transform _guildListRoot;

	private Transform _guildMakeRoot;

	private UIInput _input;

	private UIScrollView _scrollView;

	private string _selectGuildName;

	private bool _isRefresh;

	private DateTime _lastRefreshTime;

	private List<JoinableGuildInfo> _joinableGuildInfos;

	private GuildData _waitJoinData;

	public void InitPopup(GetJoinableGuildInfosAck ack)
	{
	}

	private void UpdateGuildInfo()
	{
	}

	public void InitGuildList()
	{
	}

	private void UpdateGuildList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	private GuildListItem FindGuildListItem(string guildName)
	{
		return null;
	}

	private void GuildListItemMsg(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void Refresh()
	{
	}

	public void CallbackRefresh(WWWData data)
	{
	}

	public void CallbackSearch(WWWData data)
	{
	}

	public void CallbackGuildMake(CreateGuildAck ack, string GuildName)
	{
	}

	public void CallbackJoinRequest(WWWData data)
	{
	}

	private void ClosePopup(GameObject obj, UIButton btn)
	{
	}

	private void OnJoin(UIButton btn)
	{
	}

	public void OnChange()
	{
	}

	public void OnSubmit()
	{
	}

	public void SearchGuildName(string name, UIButton reqButton)
	{
	}
}
