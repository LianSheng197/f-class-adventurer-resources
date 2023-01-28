using UnityEngine;

namespace Unity.Notifications.Android
{
	internal struct NotificationJni
	{
		public AndroidJavaObject EXTRA_TITLE;

		public AndroidJavaObject EXTRA_TEXT;

		public AndroidJavaObject EXTRA_SHOW_CHRONOMETER;

		public AndroidJavaObject EXTRA_BIG_TEXT;

		public AndroidJavaObject EXTRA_SHOW_WHEN;

		public int FLAG_AUTO_CANCEL;

		public int FLAG_GROUP_SUMMARY;

		private string getGroup;

		private string getSortKey;

		private string extras;

		private string flags;

		private string number;

		private string when;

		public void CollectJni()
		{
		}

		private void CollectConstants(AndroidJavaClass clazz)
		{
		}

		private void CollectMethods(AndroidJavaClass clazz)
		{
		}

		private void CollectFields(AndroidJavaClass clazz)
		{
		}

		public AndroidJavaObject Extras(AndroidJavaObject notification)
		{
			return null;
		}

		public int Flags(AndroidJavaObject notification)
		{
			return 0;
		}

		public int Number(AndroidJavaObject notification)
		{
			return 0;
		}

		public string GetGroup(AndroidJavaObject notification)
		{
			return null;
		}

		public string GetSortKey(AndroidJavaObject notification)
		{
			return null;
		}

		internal long When(AndroidJavaObject notification)
		{
			return 0L;
		}
	}
}
