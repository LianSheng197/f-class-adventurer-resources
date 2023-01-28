using System;
using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common
{
	public interface IInterstitialClient
	{
		event EventHandler<EventArgs> OnAdLoaded;

		event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event EventHandler<AdValueEventArgs> OnPaidEvent;

		event EventHandler<AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidDismissFullScreenContent;

		event EventHandler<EventArgs> OnAdDidRecordImpression;

		void CreateInterstitialAd();

		void LoadAd(string adUnitID, AdRequest request);

		void Show();

		IResponseInfoClient GetResponseInfoClient();

		void DestroyInterstitial();
	}
}
