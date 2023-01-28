using System;
using System.Collections.Generic;

public class GuildData
{
	public string _name;

	public string _masterName;

	public string _markSpriteName;

	public string _battlePoint;

	public GuildJoinWay _joinWay;

	public string _notice;

	public string _introduce;

	public int _rank;

	public int _myMemberId;

	public bool _hasApplicant;

	public const int MAX_MEMBER_COUNT = 30;

	public List<GuildMemberInfo> _guildMemberInfos;

	public DateTime _attendedDate;

	private GuildData Copy()
	{
		return null;
	}

	public void Init(JoinableGuildInfo joinableGuildInfo)
	{
	}

	public void Init(GetMyGuildInfoAck infoAck)
	{
	}

	public GuildMemberRole GetMyRole()
	{
		return default(GuildMemberRole);
	}

	public GuildMemberInfo GetMyInfo()
	{
		return null;
	}

	public GuildMemberInfo FIndMember(int memberId)
	{
		return null;
	}
}
