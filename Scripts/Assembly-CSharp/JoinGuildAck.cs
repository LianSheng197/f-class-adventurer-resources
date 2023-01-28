using System;
using System.Collections.Generic;

public class JoinGuildAck : AckParam
{
	public TimeSpan RemainedJoiningTimeLimit;

	public double TotalMemberBattlePoint_DECIMAL;

	public string Notice;

	public List<GuildMemberInfo> GuildMemberInfos;

	public int MyMemberID;
}
