using System;
using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting
{
	public struct UserReportEvent
	{
		public SerializableException Exception
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int FrameNumber
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string FullMessage => null;

		public UserReportEventLevel Level
		{
			[CompilerGenerated]
			readonly get
			{
				return default(UserReportEventLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Message
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string StackTrace
		{
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DateTime Timestamp
		{
			[CompilerGenerated]
			readonly get
			{
				return default(DateTime);
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
