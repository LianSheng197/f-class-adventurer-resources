using System;
using GoogleMobileAds.Api;

namespace GoogleMobileAds.Common
{
	public interface IRewardedInterstitialAdClient
	{
		event EventHandler<EventArgs> OnAdLoaded;

		event EventHandler<LoadAdErrorClientEventArgs> OnAdFailedToLoad;

		event EventHandler<AdValueEventArgs> OnPaidEvent;

		event EventHandler<Reward> OnUserEarnedReward;

		event EventHandler<AdErrorClientEventArgs> OnAdFailedToPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidPresentFullScreenContent;

		event EventHandler<EventArgs> OnAdDidDismissFullScreenContent;

		event EventHandler<EventArgs> OnAdDidRecordImpression;

		void CreateRewardedInterstitialAd();

		void LoadAd(string adUnitID, AdRequest request);

		Reward GetRewardItem();

		void Show();

		void SetServerSideVerificationOptions(ServerSideVerificationOptions serverSideVerificationOptions);

		IResponseInfoClient GetResponseInfoClient();

		void DestroyRewardedInterstitialAd();
	}
}
