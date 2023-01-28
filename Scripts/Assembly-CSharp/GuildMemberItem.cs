using System;
using UnityEngine;

public class GuildMemberItem : MonoBehaviour
{
	private GuildMemberInfo _memberInfo;

	private GuildMemberRole _myRole;

	private bool _isMyInfo;

	private Transform _masterRoot;

	public void Init(GuildMemberInfo memberInfo, bool isMyInfo, GuildMemberRole myRole)
	{
	}

	private string GetRoleToString(GuildMemberRole role)
	{
		return null;
	}

	public static string GetRecentlyLoggedInAtToString(DateTime time)
	{
		return null;
	}

	public static DesignActor.Data GetDesignActor(int characterId)
	{
		return null;
	}

	private void MasterButton(UIButton btn)
	{
	}

	private void CallbackRoleSelect(GuildMemberRole role)
	{
	}

	private void ChangeRole(GuildMemberRole role)
	{
	}

	private void WarningKickMember(GameObject obj, UIButton btn)
	{
	}
}
