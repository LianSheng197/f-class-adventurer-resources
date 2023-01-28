using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class MobileAds
	{
		public static class Utils
		{
			public static float GetDeviceScale()
			{
				return 0f;
			}

			public static int GetDeviceSafeWidth()
			{
				return 0;
			}
		}

		private readonly IMobileAdsClient client;

		private static IClientFactory clientFactory;

		private static MobileAds instance;

		public static MobileAds Instance => null;

		public static void Initialize(Action<InitializationStatus> initCompleteAction)
		{
		}

		public static void DisableMediationInitialization()
		{
		}

		public static void SetApplicationMuted(bool muted)
		{
		}

		public static void SetRequestConfiguration(RequestConfiguration requestConfiguration)
		{
		}

		public static RequestConfiguration GetRequestConfiguration()
		{
			return null;
		}

		public static void SetApplicationVolume(float volume)
		{
		}

		public static void SetiOSAppPauseOnBackground(bool pause)
		{
		}

		public static void OpenAdInspector(Action<AdInspectorError> adInspectorClosedAction)
		{
		}

		internal static IClientFactory GetClientFactory()
		{
			return null;
		}

		internal static void SetClientFactory(IClientFactory clientFactory)
		{
		}

		private static IMobileAdsClient GetMobileAdsClient()
		{
			return null;
		}
	}
}
