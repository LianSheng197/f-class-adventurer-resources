namespace Facebook.Unity.Mobile.IOS
{
	internal interface IIOSWrapper
	{
		void Init(string appId, bool frictionlessRequests, string urlSuffix, string unityUserAgentSuffix);

		void EnableProfileUpdatesOnAccessTokenChange(bool enable);

		void LogInWithReadPermissions(int requestId, string scope);

		void LogInWithPublishPermissions(int requestId, string scope);

		void LoginWithTrackingPreference(int requestId, string scope, string tracking, string nonce);

		void LogOut();

		void SetPushNotificationsDeviceTokenString(string token);

		void SetShareDialogMode(int mode);

		void ShareLink(int requestId, string contentURL, string contentTitle, string contentDescription, string photoURL);

		void FeedShare(int requestId, string toId, string link, string linkName, string linkCaption, string linkDescription, string picture, string mediaSource);

		void AppRequest(int requestId, string message, string actionType, string objectId, string[] to = null, int toLength = 0, string filters = "", string[] excludeIds = null, int excludeIdsLength = 0, bool hasMaxRecipients = false, int maxRecipients = 0, string data = "", string title = "");

		void FBAppEventsActivateApp();

		void LogAppEvent(string logEvent, double valueToSum, int numParams, string[] paramKeys, string[] paramVals);

		void LogPurchaseAppEvent(double logPurchase, string currency, int numParams, string[] paramKeys, string[] paramVals);

		void FBAppEventsSetLimitEventUsage(bool limitEventUsage);

		void FBAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled);

		void FBAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabledID);

		bool FBAdvertiserTrackingEnabled(bool advertiserTrackingEnabled);

		void GetAppLink(int requestId);

		void RefreshCurrentAccessToken(int requestId);

		string FBSdkVersion();

		void FBSetUserID(string userID);

		string FBGetUserID();

		void SetDataProcessingOptions(string[] options, int country, int state);

		void OpenFriendFinderDialog(int requestId);

		void UpdateUserProperties(int numParams, string[] paramKeys, string[] paramVals);

		void UploadImageToMediaLibrary(int requestId, string caption, string mediaUri, bool shouldLaunchMediaDialog);

		void UploadVideoToMediaLibrary(int requestId, string caption, string videoUri);

		void FetchDeferredAppLink(int requestId);

		AuthenticationToken CurrentAuthenticationToken();

		Profile CurrentProfile();
	}
}
