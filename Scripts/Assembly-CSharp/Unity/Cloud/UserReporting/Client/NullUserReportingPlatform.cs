using System;
using System.Collections.Generic;

namespace Unity.Cloud.UserReporting.Client
{
	public class NullUserReportingPlatform : IUserReportingPlatform
	{
		public T DeserializeJson<T>(string json)
		{
			return default(T);
		}

		public IDictionary<string, string> GetDeviceMetadata()
		{
			return null;
		}

		public void ModifyUserReport(UserReport userReport)
		{
		}

		public void OnEndOfFrame(UserReportingClient client)
		{
		}

		public void Post(string endpoint, string contentType, byte[] content, Action<float, float> progressCallback, Action<bool, byte[]> callback)
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
	}
}
