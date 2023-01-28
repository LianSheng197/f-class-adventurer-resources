using System;
using System.Collections.Generic;

namespace Facebook.Unity.Mobile
{
	internal interface IMobileFacebook : IFacebook
	{
		ShareDialogMode ShareDialogMode { get; set; }

		string UserID { get; set; }

		void UpdateUserProperties(Dictionary<string, string> parameters);

		void EnableProfileUpdatesOnAccessTokenChange(bool enable);

		void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

		void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		bool IsImplicitPurchaseLoggingEnabled();

		void SetPushNotificationsDeviceTokenString(string token);

		void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);

		void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);

		bool SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled);

		void SetDataProcessingOptions(IEnumerable<string> options, int country, int state);

		void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback);

		void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback);

		void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback);

		void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback);

		void GetCatalog(FacebookDelegate<ICatalogResult> callback);

		void GetPurchases(FacebookDelegate<IPurchasesResult> callback);

		void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developPayload);

		void ConsumePurchase(string productToken, FacebookDelegate<IConsumePurchaseResult> callback);

		void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback);

		void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback);

		void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback);

		void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback);

		void GetPayload(FacebookDelegate<IPayloadResult> callback);

		void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback);

		void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback);

		void GetTournament(FacebookDelegate<ITournamentResult> callback);

		void ShareTournament(Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback);

		void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback);

		void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback);

		AuthenticationToken CurrentAuthenticationToken();

		Profile CurrentProfile();
	}
}
