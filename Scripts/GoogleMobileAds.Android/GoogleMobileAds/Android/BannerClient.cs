using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Android
{
	public class BannerClient : AndroidJavaProxy, IBannerClient
	{
		private AndroidJavaObject bannerView;

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

		public event EventHandler<EventArgs> OnAdOpening
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<EventArgs> OnAdClosed
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

		public BannerClient()
			: base((string)null)
		{
		}

		public void CreateBannerView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		public void CreateBannerView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		public void LoadAd(AdRequest request)
		{
		}

		public void ShowBannerView()
		{
		}

		public void HideBannerView()
		{
		}

		public void DestroyBannerView()
		{
		}

		public float GetHeightInPixels()
		{
			return 0f;
		}

		public float GetWidthInPixels()
		{
			return 0f;
		}

		public void SetPosition(AdPosition adPosition)
		{
		}

		public void SetPosition(int x, int y)
		{
		}

		public IResponseInfoClient GetResponseInfoClient()
		{
			return null;
		}

		public void onAdLoaded()
		{
		}

		public void onAdFailedToLoad(AndroidJavaObject error)
		{
		}

		public void onAdOpened()
		{
		}

		public void onAdClosed()
		{
		}

		public void onPaidEvent(int precision, long valueInMicros, string currencyCode)
		{
		}
	}
}
