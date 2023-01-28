using System.Collections.Generic;
using UnityEngine;

public class CompGuildGradeSelect : MonoBehaviour
{
	public delegate void CallbackGradeSelect(GuildMemberRole role);

	private CallbackGradeSelect _del;

	private GuildMemberRole _myRole;

	private GuildMemberRole _selectRole;

	public void Init(CallbackGradeSelect del, GuildMemberRole myRole, float positionY)
	{
	}

	private Dictionary<GuildMemberRole, int> GetMemberGradeList()
	{
		return null;
	}

	private void Message(UIButton btn)
	{
	}

	private void WarningChangeMaster(GameObject obj, UIButton btn)
	{
	}
}
