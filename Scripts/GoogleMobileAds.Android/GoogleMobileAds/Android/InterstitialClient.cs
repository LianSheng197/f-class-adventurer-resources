using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	public class InterstitialClient : AndroidJavaProxy, IInterstitialClient
	{
		private AndroidJavaObject androidInterstitialAd;

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

		public event EventHandler<AdValueEventArgs> OnPaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public InterstitialClient()
			: base((string)null)
		{
		}

		public void CreateInterstitialAd()
		{
		}

		public void LoadAd(string adUnitId, AdRequest request)
		{
		}

		public void Show()
		{
		}

		public void DestroyInterstitial()
		{
		}

		public IResponseInfoClient GetResponseInfoClient()
		{
			return null;
		}

		public void onInterstitialAdLoaded()
		{
		}

		public void onInterstitialAdFailedToLoad(AndroidJavaObject error)
		{
		}

		private void onAdFailedToShowFullScreenContent(AndroidJavaObject error)
		{
		}

		private void onAdShowedFullScreenContent()
		{
		}

		private void onAdDismissedFullScreenContent()
		{
		}

		private void onAdImpression()
		{
		}

		public void onPaidEvent(int precision, long valueInMicros, string currencyCode)
		{
		}
	}
}
