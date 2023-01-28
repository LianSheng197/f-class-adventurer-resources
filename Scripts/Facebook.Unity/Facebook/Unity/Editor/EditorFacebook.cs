using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity.Canvas;
using Facebook.Unity.Mobile;

namespace Facebook.Unity.Editor
{
	internal class EditorFacebook : FacebookBase, IMobileFacebookImplementation, IMobileFacebook, IFacebook, IMobileFacebookResultHandler, IFacebookResultHandler, ICanvasFacebookImplementation, ICanvasFacebook, IPayFacebook, ICanvasFacebookResultHandler
	{
		private const string WarningMessage = "You are using the facebook SDK in the Unity Editor. Behavior may not be the same as when used on iOS, Android, or Web.";

		private const string AccessTokenKey = "com.facebook.unity.editor.accesstoken";

		private IEditorWrapper editorWrapper;

		public override bool LimitEventUsage
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ShareDialogMode ShareDialogMode
		{
			[CompilerGenerated]
			get
			{
				return default(ShareDialogMode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public override string SDKName => null;

		public override string SDKVersion => null;

		public string UserID
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private static IFacebookCallbackHandler EditorGameObject => null;

		public EditorFacebook(IEditorWrapper wrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public EditorFacebook()
			: base(null)
		{
		}

		public void UpdateUserProperties(Dictionary<string, string> parameters)
		{
		}

		public override void Init(InitDelegate onInitComplete)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public void EnableProfileUpdatesOnAccessTokenChange(bool enable)
		{
		}

		public void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void ActivateApp(string appId)
		{
		}

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		public bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled)
		{
		}

		public void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled)
		{
		}

		public bool SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled)
		{
			return false;
		}

		public void SetPushNotificationsDeviceTokenString(string token)
		{
		}

		public void SetDataProcessingOptions(IEnumerable<string> options, int country, int state)
		{
		}

		public AuthenticationToken CurrentAuthenticationToken()
		{
			return null;
		}

		public Profile CurrentProfile()
		{
			return null;
		}

		public void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public void Pay(string product, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public void PayWithProductId(string productId, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public void PayWithProductId(string productId, string action, string developerPayload, string testCurrency, FacebookDelegate<IPayResult> callback)
		{
		}

		public void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public override void OnLoginComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnFetchDeferredAppLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		public void OnRefreshCurrentAccessTokenComplete(ResultContainer resultContainer)
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

		public void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public void UploadVideoToMediaLibrary(string caption, Uri imageUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		public void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		public void ConsumePurchase(string productID, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		public void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		public void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
		{
		}

		public void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public void GetTournament(FacebookDelegate<ITournamentResult> callback)
		{
		}

		public void ShareTournament(Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		public void OnUrlResponse(string message)
		{
		}

		public void OnHideUnity(bool hidden)
		{
		}
	}
}
