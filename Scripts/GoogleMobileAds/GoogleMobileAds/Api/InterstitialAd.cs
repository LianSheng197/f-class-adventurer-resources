using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class InterstitialAd
	{
		private IInterstitialClient client;

		private string adUnitId;

		private bool isLoaded;

		public event EventHandler<EventArgs> OnAdLoaded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoad
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

		public event EventHandler<AdErrorEventArgs> OnAdFailedToShow
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

		public InterstitialAd(string adUnitId)
		{
		}

		public void LoadAd(AdRequest request)
		{
		}

		public bool IsLoaded()
		{
			return false;
		}

		public void Show()
		{
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
