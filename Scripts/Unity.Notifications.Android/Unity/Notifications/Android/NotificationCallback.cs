using UnityEngine;

namespace Unity.Notifications.Android
{
	internal class NotificationCallback : AndroidJavaProxy
	{
		public NotificationCallback()
			: base((string)null)
		{
		}

		public override AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] args)
		{
			return null;
		}

		public void onSentNotification(AndroidJavaObject notification)
		{
		}
	}
}
