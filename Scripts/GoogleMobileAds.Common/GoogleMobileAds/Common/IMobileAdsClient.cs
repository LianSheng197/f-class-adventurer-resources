using System;
using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common
{
	public interface IMobileAdsClient
	{
		void Initialize(Action<IInitializationStatusClient> initCompleteAction);

		void DisableMediationInitialization();

		void SetApplicationVolume(float volume);

		void SetApplicationMuted(bool muted);

		void SetiOSAppPauseOnBackground(bool pause);

		float GetDeviceScale();

		int GetDeviceSafeWidth();

		void SetRequestConfiguration(RequestConfiguration requestConfiguration);

		RequestConfiguration GetRequestConfiguration();

		void OpenAdInspector(Action<AdInspectorErrorClientEventArgs> adInspectorClosedAction);
	}
}
