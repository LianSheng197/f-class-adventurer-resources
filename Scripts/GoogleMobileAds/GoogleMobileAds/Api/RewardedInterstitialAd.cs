using System;
using System.Collections.Generic;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class RewardedInterstitialAd
	{
		private IRewardedInterstitialAdClient rewardedInterstitialAdClient;

		private static HashSet<IRewardedInterstitialAdClient> loadingClients;

		public event EventHandler<AdValueEventArgs> OnPaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AdErrorEventArgs> OnAdFailedToPresentFullScreenContent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> OnAdDidPresentFullScreenContent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> OnAdDidDismissFullScreenContent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> OnAdDidRecordImpression
		{
			add
			{
			}
			remove
			{
			}
		}

		private RewardedInterstitialAd(IRewardedInterstitialAdClient client)
		{
		}

		public static void LoadAd(string adUnitID, AdRequest request, Action<RewardedInterstitialAd, AdFailedToLoadEventArgs> adLoadCallback)
		{
		}

		public void Show(Action<Reward> userEarnedRewardCallback)
		{
		}

		public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions)
		{
		}

		public Reward GetRewardItem()
		{
			return null;
		}

		public void Destroy()
		{
		}

		public ResponseInfo GetResponseInfo()
		{
			return null;
		}
	}
}
