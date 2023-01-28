using UnityEngine;

namespace CodeStage.AntiCheat.Utils
{
	internal static class TimeUtils
	{
		public const long TicksPerSecond = 10000000L;

		private const string RoutinesClassPath = "net.codestage.actk.androidnative.ACTkAndroidRoutines";

		private static AndroidJavaClass routinesClass;

		private static bool androidTimeReadAttemptWasMade;

		public static void Uninit()
		{
		}

		public static long GetReliableTicks()
		{
			return 0L;
		}

		public static long GetEnvironmentTicks()
		{
			return 0L;
		}

		public static long GetRealtimeTicks()
		{
			return 0L;
		}

		private static long TryReadTicksFromAndroidRoutine()
		{
			return 0L;
		}
	}
}
