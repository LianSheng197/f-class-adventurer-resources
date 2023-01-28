using UnityEngine;

namespace Unity.Notifications.Android
{
	internal struct JniApi
	{
		public NotificationManagerJni NotificationManager;

		public NotificationJni Notification;

		public NotificationBuilderJni NotificationBuilder;

		public BundleJni Bundle;

		public JniApi(AndroidJavaClass notificationManagerClass, AndroidJavaObject notificationManager)
		{
		}

		public static string FindField(AndroidJavaClass clazz, string name, string signature, bool isStatic)
		{
			return null;
		}

		public static string FindMethod(AndroidJavaClass clazz, string name, string signature, bool isStatic)
		{
			return null;
		}
	}
}
