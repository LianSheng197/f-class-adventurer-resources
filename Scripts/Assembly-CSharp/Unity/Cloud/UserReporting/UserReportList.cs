using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting
{
	public class UserReportList
	{
		public string ContinuationToken
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Error
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool HasMore
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public List<UserReportPreview> UserReportPreviews
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Complete(int originalLimit, string continuationToken)
		{
		}
	}
}
