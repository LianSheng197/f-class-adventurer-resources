using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Assets.UserReporting.Scripts.Plugin;
using Unity.Cloud.UserReporting.Client;
using Unity.Screenshots;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Profiling;

namespace Unity.Cloud.UserReporting.Plugin.Version2018_3
{
	public class AsyncUnityUserReportingPlatform : IUserReportingPlatform, ILogListener
	{
		private struct LogMessage
		{
			public string LogString;

			public LogType LogType;

			public string StackTrace;
		}

		private class PostOperation
		{
			public Action<bool, byte[]> Callback
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

			public Action<float, float> ProgressCallback
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

			public UnityWebRequest WebRequest
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
		}

		private struct ProfilerSampler
		{
			public string Name;

			public Recorder Recorder;

			public double GetValue()
			{
				return 0.0;
			}
		}

		private List<LogMessage> logMessages;

		private List<PostOperation> postOperations;

		private List<ProfilerSampler> profilerSamplers;

		private ScreenshotManager screenshotManager;

		private List<PostOperation> taskOperations;

		public T DeserializeJson<T>(string json)
		{
			return default(T);
		}

		public void OnEndOfFrame(UserReportingClient client)
		{
		}

		public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
		{
		}

		public void ReceiveLogMessage(string logString, string stackTrace, LogType logType)
		{
		}

		public void RunTask(Func<object> task, Action<object> callback)
		{
		}

		public void SendAnalyticsEvent(string eventName, Dictionary<string, object> eventData)
		{
		}

		public string SerializeJson(object instance)
		{
			return null;
		}

		public void TakeScreenshot(int frameNumber, int maximumWidth, int maximumHeight, object source, Action<int, byte[]> callback)
		{
		}

		public void Update(UserReportingClient client)
		{
		}

		public virtual IDictionary<string, string> GetDeviceMetadata()
		{
			return null;
		}

		public virtual Dictionary<string, string> GetSamplerNames()
		{
			return null;
		}

		public virtual void ModifyUserReport(UserReport userReport)
		{
		}

		public virtual void SampleAutomaticMetrics(UserReportingClient client)
		{
		}
	}
}
