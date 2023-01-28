using System;

public class AcceptOrRefuseGuildMemberApplicantAck : AckParam
{
	public int MemberID;

	public int Level;

	public DateTime RecentlyLoggedInAt;

	public int DesignCharacterID;

	public double BattlePoint_DECIMAL;

	public int LegendID;

	public int DesignStageId;
}
