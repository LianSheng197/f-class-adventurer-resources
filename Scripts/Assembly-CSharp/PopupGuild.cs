using System.Collections.Generic;
using UnityEngine;

public class PopupGuild : PopupBase
{
	private Transform _guildInfoRoot;

	private Transform _guildMemberRoot;

	private Transform _guildSettingRoot;

	private Transform _guildApplyRoot;

	private UIScrollView _scrollView;

	private GameObject _prefabGuildListItem;

	public GuildData _guildData;

	private List<GuildMemberInfo> _guildMemberInfosSort;

	public void InitPopup(bool isReturnGuildBoss = false)
	{
	}

	public void InitPopup(GuildData guildData, bool isReturnGuildBoss = false)
	{
	}

	public void ReqGuildBoss()
	{
	}

	private void ShowGuildBoss(WWWData data)
	{
	}

	private void InitGuildInfo()
	{
	}

	public void UpdateNotification()
	{
	}

	private void InitGuildMemberList()
	{
	}

	public void CheckNewApplicant()
	{
	}

	private void UpdateCheckIn()
	{
	}

	private void EnableCheckIn(bool enabled)
	{
	}

	private void UpdateGuildUserList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void WarningExit(GameObject obj, UIButton btn)
	{
	}

	private void WarningDelete(GameObject obj, UIButton btn)
	{
	}

	public void CallbackApplyList(GetMyGuildMemberApplicantsAck ack)
	{
	}

	public static string GetBattleStatString(double battleState)
	{
		return null;
	}

	public void ApplyError(int ApplicantID, WWWData.STATE result)
	{
	}

	public void CallbackApplyConfirm(AcceptOrRefuseGuildMemberApplicantReq req, AcceptOrRefuseGuildMemberApplicantAck ack)
	{
	}

	private GuildMemberInfo ConvertApplyToMemberInfo(GuildMemberApplicantInfo applicantInfo)
	{
		return null;
	}

	private void CallbackLeave(WWWData data)
	{
	}

	private void CallbackCheckIn(WWWData data)
	{
	}

	private void CallbackDelete(WWWData data)
	{
	}

	private bool FireMember(int memberId)
	{
		return false;
	}

	public void CallbackFireMember(WWWData data)
	{
	}

	public void ChangeRole(int memberId, GuildMemberRole role)
	{
	}

	public void ChangeMaster(int memberId, GuildMemberRole newMyRole)
	{
	}

	public void UpdateGuildSetting(WWWData data)
	{
	}

	public Vector3 GetScrollViewPosition()
	{
		return default(Vector3);
	}
}
