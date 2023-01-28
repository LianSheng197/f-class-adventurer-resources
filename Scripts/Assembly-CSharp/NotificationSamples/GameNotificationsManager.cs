using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NotificationSamples
{
	public class GameNotificationsManager : MonoBehaviour
	{
		[Flags]
		public enum OperatingMode
		{
			NoQueue = 0,
			Queue = 1,
			ClearOnForegrounding = 2,
			RescheduleAfterClearing = 4,
			QueueAndClear = 3,
			QueueClearAndReschedule = 7
		}

		private const string DefaultFilename = "notifications.bin";

		private static readonly TimeSpan MinimumNotificationTime;

		[SerializeField]
		[Tooltip("The operating mode for the notifications manager.")]
		private OperatingMode mode;

		[SerializeField]
		[Tooltip("Check to make the notifications manager automatically set badge numbers so that they increment.\nSchedule notifications with no numbers manually set to make use of this feature.")]
		private bool autoBadging;

		private bool inForeground;

		public IGameNotificationsPlatform Platform
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

		public List<PendingNotification> PendingNotifications
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

		public IPendingNotificationsSerializer Serializer
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

		public OperatingMode Mode => default(OperatingMode);

		public bool AutoBadging => false;

		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public event Action<PendingNotification> LocalNotificationDelivered
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

		public event Action<PendingNotification> LocalNotificationExpired
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

		protected virtual void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		protected void OnApplicationFocus(bool hasFocus)
		{
		}

		public void Initialize(params GameNotificationChannel[] channels)
		{
		}

		public IGameNotification CreateNotification()
		{
			return null;
		}

		public PendingNotification ScheduleNotification(IGameNotification notification)
		{
			return null;
		}

		public void CancelNotification(int notificationId)
		{
		}

		public void CancelAllNotifications()
		{
		}

		public void DismissNotification(int notificationId)
		{
		}

		public void DismissAllNotifications()
		{
		}

		public IGameNotification GetLastNotification()
		{
			return null;
		}

		private void OnNotificationReceived(IGameNotification deliveredNotification)
		{
		}

		private void OnForegrounding()
		{
		}
	}
}
