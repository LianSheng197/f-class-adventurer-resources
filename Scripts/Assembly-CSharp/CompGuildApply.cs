using System.Collections.Generic;
using UnityEngine;

public class CompGuildApply : MonoBehaviour
{
	public class GuildApplyMemberItem : MonoBehaviour
	{
		public GuildMemberApplicantInfo _applicantInfo;

		private bool _isConfirm;

		public static GuildApplyMemberItem Attach(GameObject obj)
		{
			return null;
		}

		public void Init(GuildMemberApplicantInfo applicantInfo)
		{
		}

		private void Confirm(UIButton btn)
		{
		}
	}

	private UIScrollView _scrollView;

	private List<GuildMemberApplicantInfo> _applicants;

	public void Init(List<GuildMemberApplicantInfo> applicants)
	{
	}

	public void Refresh()
	{
	}

	private void UpdateApplyUserList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public GuildMemberApplicantInfo AcceptUser(int applicantId)
	{
		return null;
	}

	public void RefuseUser(int applicantId)
	{
	}
}
