using UnityEngine;

namespace Unity.Notifications.Android
{
	internal struct BundleJni
	{
		private string containsKey;

		private string getBoolean;

		private string getInt;

		private string getLong;

		private string getString;

		private string putBoolean;

		private string putInt;

		private string putLong;

		private string putString;

		public void CollectJni()
		{
		}

		public bool ContainsKey(AndroidJavaObject bundle, AndroidJavaObject key)
		{
			return false;
		}

		public bool GetBoolean(AndroidJavaObject bundle, AndroidJavaObject key, bool defaultValue)
		{
			return false;
		}

		public int GetInt(AndroidJavaObject bundle, AndroidJavaObject key, int defaultValue)
		{
			return 0;
		}

		public long GetLong(AndroidJavaObject bundle, AndroidJavaObject key, long defaultValue)
		{
			return 0L;
		}

		public string GetString(AndroidJavaObject bundle, AndroidJavaObject key)
		{
			return null;
		}

		public void PutBoolean(AndroidJavaObject bundle, AndroidJavaObject key, bool value)
		{
		}

		public void PutInt(AndroidJavaObject bundle, AndroidJavaObject key, int value)
		{
		}

		public void PutLong(AndroidJavaObject bundle, AndroidJavaObject key, long value)
		{
		}

		public void PutString(AndroidJavaObject bundle, AndroidJavaObject key, string value)
		{
		}
	}
}
