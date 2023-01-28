using System.Collections.Generic;
using UnityEngine;

public class PopupGuildRanking : PopupBase
{
	private UIScrollView _scrollView;

	private List<GuildBossRankingInfo> _guildBossRankingList;

	private Transform _rewardBtn;

	public void InitPopup(GetGuildBossRankingAck ack)
	{
	}

	private void UpdateGuildUserList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public void UpdateIsNew()
	{
	}

	public void CallbackReceiveRankingReward(WWWData data)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
