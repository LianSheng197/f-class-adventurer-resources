using System;
using System.Runtime.CompilerServices;
using Unity.Notifications.Android;

namespace NotificationSamples.Android
{
	public class AndroidGameNotification : IGameNotification
	{
		private AndroidNotification internalNotification;

		public AndroidNotification InternalNotification => default(AndroidNotification);

		public int? Id
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

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Body
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Subtitle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int? BadgeNumber
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ShouldAutoCancel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public DateTime? DeliveryTime
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string DeliveredChannel
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

		public bool Scheduled
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

		public string SmallIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LargeIcon
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AndroidGameNotification()
		{
		}

		internal AndroidGameNotification(AndroidNotification deliveredNotification, int deliveredId, string deliveredChannel)
		{
		}

		internal void OnScheduled()
		{
		}
	}
}
