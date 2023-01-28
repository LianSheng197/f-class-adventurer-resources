using System;
using System.Collections.Generic;

public class GetMyGuildBossRankingAck : AckParam
{
	public double MyHighScore_DECIMAL;

	public int MyHighStage;

	public int MyLastStage;

	public DateTime MyReceivedDailyRewardDate;

	public List<GuildMemberBossRankingInfo> MemberBossRankingInfos;

	public int MyRankInMemberBossRankingInfos;
}
