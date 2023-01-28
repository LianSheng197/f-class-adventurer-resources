using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting
{
	public struct UserReportMetric
	{
		public double Average => 0.0;

		public int Count
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

		public double Maximum
		{
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public double Minimum
		{
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string Name
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

		public double Sum
		{
			[CompilerGenerated]
			readonly get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Sample(double value)
		{
		}
	}
}
