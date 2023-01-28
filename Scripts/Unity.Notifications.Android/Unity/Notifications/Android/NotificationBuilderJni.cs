using UnityEngine;

namespace Unity.Notifications.Android
{
	internal struct NotificationBuilderJni
	{
		private string getExtras;

		private string setContentTitle;

		private string setContentText;

		private string setAutoCancel;

		private string setNumber;

		private string setStyle;

		private string setWhen;

		private string setGroup;

		private string setGroupSummary;

		private string setSortKey;

		private string setShowWhen;

		public void CollectJni()
		{
		}

		public AndroidJavaObject GetExtras(AndroidJavaObject builder)
		{
			return null;
		}

		public void SetContentTitle(AndroidJavaObject builder, string title)
		{
		}

		public void SetContentText(AndroidJavaObject builder, string text)
		{
		}

		public void SetAutoCancel(AndroidJavaObject builder, bool shouldAutoCancel)
		{
		}

		public void SetNumber(AndroidJavaObject builder, int number)
		{
		}

		public void SetStyle(AndroidJavaObject builder, AndroidJavaObject style)
		{
		}

		public void SetWhen(AndroidJavaObject builder, long timestamp)
		{
		}

		public void SetGroup(AndroidJavaObject builder, string group)
		{
		}

		public void SetGroupSummary(AndroidJavaObject builder, bool groupSummary)
		{
		}

		public void SetSortKey(AndroidJavaObject builder, string sortKey)
		{
		}

		public void SetShowWhen(AndroidJavaObject builder, bool showTimestamp)
		{
		}
	}
}
