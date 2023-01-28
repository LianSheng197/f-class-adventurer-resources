using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	public class AppOpenAdClient : AndroidJavaProxy, IAppOpenAdClient
	{
		private AndroidJavaObject androidAppOpenAd;

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

		public AppOpenAdClient()
			: base((string)null)
		{
		}

		public void CreateAppOpenAd()
		{
		}

		public void LoadAd(string adUnitID, AdRequest request, ScreenOrientation orientation)
		{
		}

		public void Show()
		{
		}

		public IResponseInfoClient GetResponseInfoClient()
		{
			return null;
		}

		public void DestroyAppOpenAd()
		{
		}

		private void onAppOpenAdLoaded()
		{
		}

		private void onAppOpenAdFailedToLoad(AndroidJavaObject error)
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

		private void onPaidEvent(int precision, long valueInMicros, string currencyCode)
		{
		}
	}
}
