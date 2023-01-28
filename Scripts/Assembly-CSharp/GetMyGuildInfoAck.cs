using System;
using System.Collections.Generic;

public class GetMyGuildInfoAck : AckParam
{
	public string Name;

	public double TotalMemberBattlePoint_DECIMAL;

	public GuildJoinWay JoinWay;

	public string Introduction;

	public string Notice;

	public string MarkSpriteName;

	public int BossRank;

	public List<GuildMemberInfo> GuildMemberInfos;

	public int MyMemberID;

	public DateTime AttendedDate;

	public bool HasApplicant;
}
