using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	public class MobileAdsClient : AndroidJavaProxy, IMobileAdsClient
	{
		private static MobileAdsClient instance;

		private Action<IInitializationStatusClient> initCompleteAction;

		public static MobileAdsClient Instance => null;

		private MobileAdsClient()
			: base((string)null)
		{
		}

		public void Initialize(Action<IInitializationStatusClient> initCompleteAction)
		{
		}

		public void SetApplicationVolume(float volume)
		{
		}

		public void DisableMediationInitialization()
		{
		}

		public void SetApplicationMuted(bool muted)
		{
		}

		public void SetRequestConfiguration(RequestConfiguration requestConfiguration)
		{
		}

		public RequestConfiguration GetRequestConfiguration()
		{
			return null;
		}

		public void SetiOSAppPauseOnBackground(bool pause)
		{
		}

		public void OpenAdInspector(Action<AdInspectorErrorClientEventArgs> onAdInspectorClosed)
		{
		}

		public float GetDeviceScale()
		{
			return 0f;
		}

		public int GetDeviceSafeWidth()
		{
			return 0;
		}

		public void onInitializationComplete(AndroidJavaObject initStatus)
		{
		}
	}
}
