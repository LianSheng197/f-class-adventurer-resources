using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Cloud.UserReporting.Client
{
	public class UserReportingClient
	{
		private Dictionary<string, UserReportMetric> clientMetrics;

		private Dictionary<string, string> currentMeasureMetadata;

		private Dictionary<string, UserReportMetric> currentMetrics;

		private List<Action> currentSynchronizedActions;

		private List<UserReportNamedValue> deviceMetadata;

		private CyclicalList<UserReportEvent> events;

		private int frameNumber;

		private bool isMeasureBoundary;

		private int measureFrames;

		private CyclicalList<UserReportMeasure> measures;

		private CyclicalList<UserReportScreenshot> screenshots;

		private int screenshotsSaved;

		private int screenshotsTaken;

		private List<Action> synchronizedActions;

		private Stopwatch updateStopwatch;

		public UserReportingClientConfiguration Configuration
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Endpoint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsConnectedToLogger
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

		public bool IsSelfReporting
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

		public IUserReportingPlatform Platform
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string ProjectIdentifier
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool SendEventsToAnalytics
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

		public UserReportingClient(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		public void AddDeviceMetadata(string name, string value)
		{
		}

		public void AddMeasureMetadata(string name, string value)
		{
		}

		private void AddSynchronizedAction(Action action)
		{
		}

		public void ClearScreenshots()
		{
		}

		public void CreateUserReport(Action<UserReport> callback)
		{
		}

		public string GetEndpoint()
		{
			return null;
		}

		public void LogEvent(UserReportEventLevel level, string message)
		{
		}

		public void LogEvent(UserReportEventLevel level, string message, string stackTrace)
		{
		}

		private void LogEvent(UserReportEventLevel level, string message, string stackTrace, Exception exception)
		{
		}

		public void LogException(Exception exception)
		{
		}

		public void SampleClientMetric(string name, double value)
		{
		}

		public void SampleMetric(string name, double value)
		{
		}

		public void SaveUserReportToDisk(UserReport userReport)
		{
		}

		public void SendUserReport(UserReport userReport, Action<bool, UserReport> callback)
		{
		}

		public void SendUserReport(UserReport userReport, Action<float, float> progressCallback, Action<bool, UserReport> callback)
		{
		}

		public void TakeScreenshot(int maximumWidth, int maximumHeight, Action<UserReportScreenshot> callback)
		{
		}

		public void TakeScreenshotFromSource(int maximumWidth, int maximumHeight, object source, Action<UserReportScreenshot> callback)
		{
		}

		public void Update()
		{
		}

		public void UpdateOnEndOfFrame()
		{
		}

		private void WaitForPerforation(int currentScreenshotsTaken, Action callback)
		{
		}
	}
}
