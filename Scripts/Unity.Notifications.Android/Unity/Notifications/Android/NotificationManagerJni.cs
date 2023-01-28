using UnityEngine;

namespace Unity.Notifications.Android
{
	internal struct NotificationManagerJni
	{
		private AndroidJavaClass klass;

		private AndroidJavaObject self;

		public AndroidJavaObject KEY_FIRE_TIME;

		public AndroidJavaObject KEY_ID;

		public AndroidJavaObject KEY_INTENT_DATA;

		public AndroidJavaObject KEY_LARGE_ICON;

		public AndroidJavaObject KEY_REPEAT_INTERVAL;

		public AndroidJavaObject KEY_NOTIFICATION;

		public AndroidJavaObject KEY_SMALL_ICON;

		public AndroidJavaObject KEY_SHOW_IN_FOREGROUND;

		private string getNotificationFromIntent;

		private string setNotificationIcon;

		private string setNotificationColor;

		private string getNotificationColor;

		private string setNotificationUsesChronometer;

		private string setNotificationGroupAlertBehavior;

		private string getNotificationGroupAlertBehavior;

		private string getNotificationChannelId;

		private string scheduleNotification;

		private string createNotificationBuilder;

		public NotificationManagerJni(AndroidJavaClass clazz, AndroidJavaObject obj)
		{
		}

		private void CollectMethods(AndroidJavaClass clazz)
		{
		}

		public AndroidJavaObject GetNotificationFromIntent(AndroidJavaObject intent)
		{
			return null;
		}

		public void SetNotificationIcon(AndroidJavaObject builder, AndroidJavaObject keyName, string icon)
		{
		}

		public void SetNotificationColor(AndroidJavaObject builder, int color)
		{
		}

		public Color? GetNotificationColor(AndroidJavaObject notification)
		{
			return null;
		}

		public void SetNotificationUsesChronometer(AndroidJavaObject builder, bool usesStopwatch)
		{
		}

		public void SetNotificationGroupAlertBehavior(AndroidJavaObject builder, int groupAlertBehaviour)
		{
		}

		public int GetNotificationGroupAlertBehavior(AndroidJavaObject notification)
		{
			return 0;
		}

		public string GetNotificationChannelId(AndroidJavaObject notification)
		{
			return null;
		}

		public void RegisterNotificationChannel(AndroidNotificationChannel channel)
		{
		}

		public AndroidJavaObject[] GetNotificationChannels()
		{
			return null;
		}

		public void DeleteNotificationChannel(string channelId)
		{
		}

		public int ScheduleNotification(AndroidJavaObject notificationBuilder, bool customized)
		{
			return 0;
		}

		public bool CheckIfPendingNotificationIsRegistered(int id)
		{
			return false;
		}

		public void CancelPendingNotification(int id)
		{
		}

		public void CancelDisplayedNotification(int id)
		{
		}

		public void CancelAllPendingNotificationIntents()
		{
		}

		public void CancelAllNotifications()
		{
		}

		public int CheckNotificationStatus(int id)
		{
			return 0;
		}

		public void ShowNotificationSettings(string channelId)
		{
		}

		public AndroidJavaObject CreateNotificationBuilder(string channelId)
		{
			return null;
		}
	}
}
