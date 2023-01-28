using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public class AndroidNotificationCenter
	{
		public delegate void NotificationReceivedCallback(AndroidNotificationIntentData data);

		private static int API_POST_NOTIFICATIONS_PERMISSION_REQUIRED;

		internal static string PERMISSION_POST_NOTIFICATIONS;

		public static string SETTING_POST_NOTIFICATIONS_PERMISSION;

		private static AndroidJavaObject s_CurrentActivity;

		private static JniApi s_Jni;

		private static int s_DeviceApiLevel;

		private static int s_TargetApiLevel;

		private static bool s_Initialized;

		public static PermissionStatus UserPermissionToPost => default(PermissionStatus);

		public static event NotificationReceivedCallback OnNotificationReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static bool Initialize()
		{
			return false;
		}

		internal static void SetPostPermissionSetting(PermissionStatus status)
		{
		}

		public static void RegisterNotificationChannel(AndroidNotificationChannel channel)
		{
		}

		public static AndroidNotificationChannel GetNotificationChannel(string channelId)
		{
			return default(AndroidNotificationChannel);
		}

		public static AndroidNotificationChannel[] GetNotificationChannels()
		{
			return null;
		}

		public static void DeleteNotificationChannel(string channelId)
		{
		}

		public static int SendNotification(AndroidNotification notification, string channelId)
		{
			return 0;
		}

		public static void SendNotificationWithExplicitID(AndroidNotification notification, string channelId, int id)
		{
		}

		public static void SendNotification(AndroidJavaObject notificationBuilder)
		{
		}

		public static void SendNotification(AndroidJavaObject notificationBuilder, out int id)
		{
			id = default(int);
		}

		private static int ScheduleNotification(AndroidJavaObject notificationBuilder, bool customized)
		{
			return 0;
		}

		public static void UpdateScheduledNotification(int id, AndroidNotification notification, string channelId)
		{
		}

		public static void CancelNotification(int id)
		{
		}

		public static void CancelScheduledNotification(int id)
		{
		}

		public static void CancelDisplayedNotification(int id)
		{
		}

		public static void CancelAllNotifications()
		{
		}

		public static void CancelAllScheduledNotifications()
		{
		}

		public static void CancelAllDisplayedNotifications()
		{
		}

		public static NotificationStatus CheckScheduledNotificationStatus(int id)
		{
			return default(NotificationStatus);
		}

		public static AndroidNotificationIntentData GetLastNotificationIntent()
		{
			return null;
		}

		public static void OpenNotificationSettings(string channelId = null)
		{
		}

		public static AndroidJavaObject CreateNotificationBuilder(AndroidNotification notification, string channelId)
		{
			return null;
		}

		public static AndroidJavaObject CreateNotificationBuilder(int id, AndroidNotification notification, string channelId)
		{
			return null;
		}

		private static void CreateNotificationBuilder(AndroidNotification notification, string channelId, out AndroidJavaObject notificationBuilder, out AndroidJavaObject extras)
		{
			notificationBuilder = null;
			extras = null;
		}

		internal static AndroidNotificationIntentData GetNotificationData(AndroidJavaObject notificationObj)
		{
			return null;
		}

		internal static void ReceivedNotificationCallback(AndroidJavaObject notification)
		{
		}
	}
}
