using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting.Client
{
	public class UserReportingClientConfiguration
	{
		public int FramesPerMeasure
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int MaximumEventCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int MaximumMeasureCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public int MaximumScreenshotCount
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public MetricsGatheringMode MetricsGatheringMode
		{
			[CompilerGenerated]
			get
			{
				return default(MetricsGatheringMode);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public UserReportingClientConfiguration()
		{
		}

		public UserReportingClientConfiguration(int maximumEventCount, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
		{
		}

		public UserReportingClientConfiguration(int maximumEventCount, MetricsGatheringMode metricsGatheringMode, int maximumMeasureCount, int framesPerMeasure, int maximumScreenshotCount)
		{
		}
	}
}
