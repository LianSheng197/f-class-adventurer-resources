using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Notifications.Android
{
	public class AndroidNotificationIntentData
	{
		public int Id
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public string Channel
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public AndroidNotification Notification
		{
			[CompilerGenerated]
			get
			{
				return default(AndroidNotification);
			}
		}

		public AndroidJavaObject NativeNotification
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public AndroidNotificationIntentData(int id, string channelId, AndroidNotification notification)
		{
		}
	}
}
