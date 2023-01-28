namespace CodeStage.AntiCheat.Common
{
	public static class UnityApiResultsHolder
	{
		private static string deviceUniqueIdentifier;

		private static string persistentDataPath;

		public static void InitForAsyncUsage(bool warmUpDeviceIdentifier)
		{
		}

		internal static string GetDeviceUniqueIdentifier()
		{
			return null;
		}

		private static string GetDeviceID()
		{
			return null;
		}

		internal static string GetPersistentDataPath()
		{
			return null;
		}
	}
}
