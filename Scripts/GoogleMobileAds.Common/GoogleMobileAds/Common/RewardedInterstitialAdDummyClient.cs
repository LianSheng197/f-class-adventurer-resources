using System;
using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common
{
	public class RewardedInterstitialAdDummyClient : IRewardedInterstitialAdClient
	{
		public event EventHandler<EventArgs> OnAdLoaded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<Reward> OnUserEarnedReward
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AdValueEventArgs> OnPaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent
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

		public void CreateRewardedInterstitialAd()
		{
		}

		public void LoadAd(string adUnitID, AdRequest request)
		{
		}

		public Reward GetRewardItem()
		{
			return null;
		}

		public void Show()
		{
		}

		public void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions)
		{
		}

		public void DestroyRewardedInterstitialAd()
		{
		}

		public IResponseInfoClient GetResponseInfoClient()
		{
			return null;
		}
	}
}
