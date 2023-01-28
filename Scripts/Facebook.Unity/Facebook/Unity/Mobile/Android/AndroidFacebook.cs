using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Mobile.Android
{
	internal sealed class AndroidFacebook : MobileFacebook
	{
		private class JavaMethodCall<T> : MethodCall<T> where T : IResult
		{
			private AndroidFacebook androidImpl;

			public JavaMethodCall(AndroidFacebook androidImpl, string methodName)
			{
				((MethodCall<>)(object)this)._002Ector((FacebookBase)null, (string)null);
			}

			public override void Call(MethodArguments args = null)
			{
			}
		}

		public const string LoginPermissionsKey = "scope";

		private bool limitEventUsage;

		private IAndroidWrapper androidWrapper;

		private string userID;

		public string KeyHash
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public override bool LimitEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override string UserID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string SDKName => null;

		public override string SDKVersion => null;

		public AndroidFacebook()
			: base(null)
		{
		}

		public AndroidFacebook(IAndroidWrapper androidWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public override void UpdateUserProperties(Dictionary<string, string> parameters)
		{
		}

		public override void SetDataProcessingOptions(IEnumerable<string> options, int country, int state)
		{
		}

		public override void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled)
		{
		}

		public override void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled)
		{
		}

		public override bool SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled)
		{
			return false;
		}

		public override void SetPushNotificationsDeviceTokenString(string token)
		{
		}

		public void Init(string appId, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void EnableProfileUpdatesOnAccessTokenChange(bool enable)
		{
		}

		public override void LoginWithTrackingPreference(string tracking, IEnumerable<string> permissions, string nonce, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogOut()
		{
		}

		public override AuthenticationToken CurrentAuthenticationToken()
		{
			return null;
		}

		public override Profile CurrentProfile()
		{
			return null;
		}

		public void RetrieveLoginStatus(FacebookDelegate<ILoginStatusResult> callback)
		{
		}

		public void OnLoginStatusRetrieved(ResultContainer resultContainer)
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

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public void ClearAppLink()
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		public override bool IsImplicitPurchaseLoggingEnabled()
		{
			return false;
		}

		public override void ActivateApp(string appId)
		{
		}

		public override void FetchDeferredAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void OnIAPReady(FacebookDelegate<IIAPReadyResult> callback)
		{
		}

		public override void GetCatalog(FacebookDelegate<ICatalogResult> callback)
		{
		}

		public override void GetPurchases(FacebookDelegate<IPurchasesResult> callback)
		{
		}

		public override void Purchase(string productID, FacebookDelegate<IPurchaseResult> callback, string developerPayload = "")
		{
		}

		public override void ConsumePurchase(string purchaseToken, FacebookDelegate<IConsumePurchaseResult> callback)
		{
		}

		public override void InitCloudGame(FacebookDelegate<IInitCloudGameResult> callback)
		{
		}

		public override void ScheduleAppToUserNotification(string title, string body, Uri media, int timeInterval, string payload, FacebookDelegate<IScheduleAppToUserNotificationResult> callback)
		{
		}

		public override void LoadInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public override void ShowInterstitialAd(string placementID, FacebookDelegate<IInterstitialAdResult> callback)
		{
		}

		public override void LoadRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public override void ShowRewardedVideo(string placementID, FacebookDelegate<IRewardedVideoResult> callback)
		{
		}

		public override void GetPayload(FacebookDelegate<IPayloadResult> callback)
		{
		}

		public override void PostSessionScore(int score, FacebookDelegate<ISessionScoreResult> callback)
		{
		}

		public override void PostTournamentScore(int score, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void GetTournament(FacebookDelegate<ITournamentResult> callback)
		{
		}

		public override void CreateTournament(int initialScore, string title, string imageBase64DataUrl, string sortOrder, string scoreFormat, Dictionary<string, string> data, FacebookDelegate<ITournamentResult> callback)
		{
		}

		public override void ShareTournament(Dictionary<string, string> data, FacebookDelegate<ITournamentScoreResult> callback)
		{
		}

		public override void OpenAppStore(FacebookDelegate<IOpenAppStoreResult> callback)
		{
		}

		protected override void SetShareDialogMode(ShareDialogMode mode)
		{
		}

		private static IAndroidWrapper GetAndroidWrapper()
		{
			return null;
		}

		private void CallFB(string method, string args)
		{
		}
	}
}
