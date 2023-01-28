using System;
using GoogleMobileAds.Api;
using UnityEngine;

namespace GoogleMobileAds.Common
{
	public interface IAppOpenAdClient
	{
		event EventHandler<EventArgs> OnAdLoaded;

		event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event EventHandler<AdValueEventArgs> OnPaidEvent;

		event EventHandler<AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidDismissFullScreenContent;

		event EventHandler<EventArgs> OnAdDidRecordImpression;

		void CreateAppOpenAd();

		void LoadAd(string adUnitID, AdRequest request, ScreenOrientation orientation);

		void Show();

		IResponseInfoClient GetResponseInfoClient();

		void DestroyAppOpenAd();
	}
}
