using Firebase.Platform;

namespace Firebase.Unity
{
	internal class UnityLoggingService : ILoggingService
	{
		private static UnityLoggingService _instance;

		public static UnityLoggingService Instance => null;

		public void LogMessage(PlatformLogLevel level, string message)
		{
		}
	}
}
