using System;
using System.Collections.Generic;
using GoogleMobileAds.Common;
using UnityEngine;

namespace GoogleMobileAds.Api
{
	public class AppOpenAd
	{
		private IAppOpenAdClient client;

		private static HashSet<IAppOpenAdClient> loadingClients;

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

		private AppOpenAd(IAppOpenAdClient client)
		{
		}

		public static void LoadAd(string adUnitID, ScreenOrientation orientation, AdRequest request, Action<AppOpenAd, AdFailedToLoadEventArgs> adLoadCallback)
		{
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
