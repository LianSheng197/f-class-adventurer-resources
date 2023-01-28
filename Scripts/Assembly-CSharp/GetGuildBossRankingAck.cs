using System.Collections.Generic;

public class GetGuildBossRankingAck : AckParam
{
	public int TotalGuildBossRankingCount;

	public List<GuildBossRankingInfo> RankingInfos;

	public GuildBossRankingInfo MyRankingInfo;
}
