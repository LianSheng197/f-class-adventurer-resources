using System;

public class GuildNotification
{
	public DateTime MyReceivedDailyRewardDate;

	public int MyHighStage;

	public int MyRankInMemberBossRankingInfos;

	public DateTime AttendedDate;

	private bool isInitAttendDate;

	public CanReceivePrevGuildBossRankingRewardAck _CanGuildBossRankingRewardAck;

	public void Init(bool isUpdateServer = false)
	{
	}

	public void Clear()
	{
	}

	public void RequestServer()
	{
	}

	public void RequestGuildInfo()
	{
	}

	public void ReqRankingReward()
	{
	}

	public void UpdateDailyRewardDate(DateTime date)
	{
	}

	public void UpdateDailyRewardDate(DateTime date, GetMyGuildBossRankingAck ack)
	{
	}

	public void UpdateAttendedDate(DateTime now)
	{
	}

	public void UpdateAttendedDate(GetMyGuildInfoAck ack)
	{
	}

	public void UpdateGuildBossRankingReward(WWWData ack)
	{
	}

	public void ResultGuildBossRankingReward(ReceivePrevGuildBossRankingRewardAck ack)
	{
	}

	public bool IsRemainAp()
	{
		return false;
	}

	public bool IsDailyReward()
	{
		return false;
	}

	public bool IsAttendReward()
	{
		return false;
	}

	public bool IsRankingRewardNew()
	{
		return false;
	}

	public bool IsNewMark()
	{
		return false;
	}

	public string GetGuildName()
	{
		return null;
	}
}
