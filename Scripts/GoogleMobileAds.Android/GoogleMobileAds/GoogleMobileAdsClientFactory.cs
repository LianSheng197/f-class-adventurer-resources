using GoogleMobileAds.Common;
using UnityEngine.Scripting;

namespace GoogleMobileAds
{
	[Preserve]
	public class GoogleMobileAdsClientFactory : IClientFactory
	{
		public IAppStateEventClient BuildAppStateEventClient()
		{
			return null;
		}

		public IAppOpenAdClient BuildAppOpenAdClient()
		{
			return null;
		}

		public IBannerClient BuildBannerClient()
		{
			return null;
		}

		public IInterstitialClient BuildInterstitialClient()
		{
			return null;
		}

		public IRewardedAdClient BuildRewardedAdClient()
		{
			return null;
		}

		public IRewardedInterstitialAdClient BuildRewardedInterstitialAdClient()
		{
			return null;
		}

		public IMobileAdsClient MobileAdsInstance()
		{
			return null;
		}
	}
}
