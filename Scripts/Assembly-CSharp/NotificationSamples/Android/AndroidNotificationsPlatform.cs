using System;
using System.Runtime.CompilerServices;
using Unity.Notifications.Android;

namespace NotificationSamples.Android
{
	public class AndroidNotificationsPlatform : IGameNotificationsPlatform<AndroidGameNotification>, IGameNotificationsPlatform, IDisposable
	{
		public string DefaultChannelId
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

		public event Action<IGameNotification> NotificationReceived
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

		public void ScheduleNotification(AndroidGameNotification gameNotification)
		{
		}

		public void ScheduleNotification(IGameNotification gameNotification)
		{
		}

		public AndroidGameNotification CreateNotification()
		{
			return null;
		}

		private IGameNotification NotificationSamples_002EIGameNotificationsPlatform_002ECreateNotification()
		{
			return null;
		}

		public void CancelNotification(int notificationId)
		{
		}

		public void DismissNotification(int notificationId)
		{
		}

		public void CancelAllScheduledNotifications()
		{
		}

		public void DismissAllDisplayedNotifications()
		{
		}

		private IGameNotification NotificationSamples_002EIGameNotificationsPlatform_002EGetLastNotification()
		{
			return null;
		}

		public AndroidGameNotification GetLastNotification()
		{
			return null;
		}

		public void OnForeground()
		{
		}

		public void OnBackground()
		{
		}

		public void Dispose()
		{
		}

		private void OnLocalNotificationReceived(AndroidNotificationIntentData data)
		{
		}
	}
}
