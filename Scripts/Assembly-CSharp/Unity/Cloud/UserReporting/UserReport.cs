using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting
{
	public class UserReport : UserReportPreview
	{
		private class UserReportMetricSorter : IComparer<UserReportMetric>
		{
			public int Compare(UserReportMetric x, UserReportMetric y)
			{
				return 0;
			}
		}

		public List<UserReportAttachment> Attachments
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

		public List<UserReportMetric> ClientMetrics
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

		public List<UserReportNamedValue> DeviceMetadata
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

		public List<UserReportEvent> Events
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

		public List<UserReportNamedValue> Fields
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

		public List<UserReportMeasure> Measures
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

		public List<UserReportScreenshot> Screenshots
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

		public UserReport Clone()
		{
			return null;
		}

		public void Complete()
		{
		}

		public void Fix()
		{
		}

		public string GetDimensionsString()
		{
			return null;
		}

		public void RemoveScreenshots(int maximumWidth, int maximumHeight, int totalBytes, int ignoreCount)
		{
		}

		public UserReportPreview ToPreview()
		{
			return null;
		}
	}
}
