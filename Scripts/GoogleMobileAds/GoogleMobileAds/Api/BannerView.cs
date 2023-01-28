using System;
using GoogleMobileAds.Common;

namespace GoogleMobileAds.Api
{
	public class BannerView
	{
		private IBannerClient client;

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

		public event EventHandler<AdValueEventArgs> OnPaidEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public BannerView(string adUnitId, AdSize adSize, AdPosition position)
		{
		}

		public BannerView(string adUnitId, AdSize adSize, int x, int y)
		{
		}

		public void LoadAd(AdRequest request)
		{
		}

		public void Hide()
		{
		}

		public void Show()
		{
		}

		public void Destroy()
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

		private void ConfigureBannerEvents()
		{
		}

		public ResponseInfo GetResponseInfo()
		{
			return null;
		}
	}
}
