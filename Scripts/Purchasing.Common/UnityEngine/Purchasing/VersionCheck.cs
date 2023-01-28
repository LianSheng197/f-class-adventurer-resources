namespace UnityEngine.Purchasing
{
	internal static class VersionCheck
	{
		internal struct Version
		{
			public int major;

			public int minor;

			public int patch;
		}

		public static bool GreaterThanOrEqual(string versionA, string versionB)
		{
			return false;
		}

		public static bool GreaterThan(string versionA, string versionB)
		{
			return false;
		}

		public static bool LessThan(string versionA, string versionB)
		{
			return false;
		}

		public static bool LessThanOrEqual(string versionA, string versionB)
		{
			return false;
		}

		public static bool Equal(string versionA, string versionB)
		{
			return false;
		}

		public static int MajorVersion(string version)
		{
			return 0;
		}

		public static int MinorVersion(string version)
		{
			return 0;
		}

		public static int PatchVersion(string version)
		{
			return 0;
		}

		public static Version Parse(string version)
		{
			return default(Version);
		}

		private static int PartialVersion(string version, int index)
		{
			return 0;
		}
	}
}
