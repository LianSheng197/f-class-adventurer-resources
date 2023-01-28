using System;
using System.Collections.Generic;

namespace Facebook.Unity.Mobile
{
	internal abstract class MobileFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler
	{
		private const string CallbackIdKey = "callback_id";

		private ShareDialogMode shareDialogMode;

		public ShareDialogMode ShareDialogMode
		{
			get
			{
				return default(ShareDialogMode);
			}
			set
			{
			}
		}

		public abstract string UserID { get; set; }

		protected MobileFacebook(CallbackManager callbackManager)
			: base(null)
		{
		}

		public abstract AuthenticationToken CurrentAuthenticationToken();

		public abstract Profile CurrentProfile();

		public abstract void UpdateUserProperties(Dictionary<string, string> parameters);

		public abstract void SetDataProcessingOptions(IEnumerable<string> options, int country, int state);

		public abstract void EnableProfileUpdatesOnAccessTokenChange(bool enable);

		public abstract void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback);

		public abstract void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback);

		public abstract void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback);

		public abstract bool IsImplicitPurchaseLoggingEnabled();

		public abstract void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);

		public abstract void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled);

		public abstract bool SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled);

		public abstract void SetPushNotificationsDeviceTokenString(string token);

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
		{
		}

		public virtual void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public void OnFriendFinderComplete(ResultContainer resultContainer)
		{
		}

		public void OnUploadImageToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		public void OnUploadVideoToMediaLibraryComplete(ResultContainer resultContainer)
		{
		}

		public void OnOnIAPReadyComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetCatalogComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetPurchasesComplete(ResultContainer resultContainer)
		{
		}

		public void OnPurchaseComplete(ResultContainer resultContainer)
		{
		}

		public void OnConsumePurchaseComplete(ResultContainer resultContainer)
		{
		}

		public void OnInitCloudGameComplete(ResultContainer resultContainer)
		{
		}

		public void OnScheduleAppToUserNotificationComplete(ResultContainer resultContainer)
		{
		}

		public void OnLoadInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		public void OnShowInterstitialAdComplete(ResultContainer resultContainer)
		{
		}

		public void OnLoadRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		public void OnShowRewardedVideoComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetPayloadComplete(ResultContainer resultContainer)
		{
		}

		public void OnPostSessionScoreComplete(ResultContainer resultContainer)
		{
		}

		public void OnPostTournamentScoreComplete(ResultContainer resultContainer)
		{
		}

		public void OnGetTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnShareTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnCreateTournamentComplete(ResultContainer resultContainer)
		{
		}

		public void OnOpenAppStoreComplete(ResultContainer resultContainer)
		{
		}

		public virtual void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public virtual void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public virtual void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		public virtual void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public virtual void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public virtual void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload)
		{
		}

		public virtual void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public virtual void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public virtual void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		public virtual void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public virtual void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public virtual void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public virtual void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public virtual void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		public virtual void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
		{
		}

		public virtual void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public virtual void GetTournament(FacebookDelegate<ITournamentResult> callback)
		{
		}

		public virtual void ShareTournament(Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public virtual void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public virtual void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		protected abstract void SetShareDialogMode(ShareDialogMode mode);

		private static IDictionary<string, object> DeserializeMessage(string message)
		{
			return null;
		}

		private static string SerializeDictionary(IDictionary<string, object> dict)
		{
			return null;
		}

		private static bool TryGetCallbackId(IDictionary<string, object> result, out string callbackId)
		{
			callbackId = null;
			return false;
		}

		private static bool TryGetError(IDictionary<string, object> result, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}
	}
}
