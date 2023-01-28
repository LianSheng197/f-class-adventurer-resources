using Unity.Cloud.UserReporting.Client;

namespace Unity.Cloud.UserReporting.Plugin
{
	public static class UnityUserReporting
	{
		private static UserReportingClient currentClient;

		public static UserReportingClient CurrentClient
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public static void Configure(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(string endpoint, string projectIdentifier, UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(string projectIdentifier, UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(string projectIdentifier)
		{
		}

		public static void Configure()
		{
		}

		public static void Configure(UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
		{
		}

		public static void Configure(IUserReportingPlatform platform)
		{
		}

		private static IUserReportingPlatform GetPlatform()
		{
			return null;
		}

		public static void Use(UserReportingClient client)
		{
		}
	}
}
