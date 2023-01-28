using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Mobile.IOS
{
	internal class IOSFacebook : MobileFacebook
	{
		public enum FBInsightsFlushBehavior
		{
			FBInsightsFlushBehaviorAuto = 0,
			FBInsightsFlushBehaviorExplicitOnly = 1
		}

		private class NativeDict
		{
			public int NumEntries
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public string[] Keys
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

			public string[] Values
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
		}

		private const string CancelledResponse = "{\"cancelled\":true}";

		private bool limitEventUsage;

		private IIOSWrapper iosWrapper;

		private string userID;

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

		public override string SDKName => null;

		public override string SDKVersion => null;

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

		public override bool LoggedIn => false;

		public IOSFacebook()
			: base(null)
		{
		}

		public IOSFacebook(IIOSWrapper iosWrapper, CallbackManager callbackManager)
			: base(null)
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

		public override void UpdateUserProperties(Dictionary<string, string> parameters)
		{
		}

		public override void SetDataProcessingOptions(IEnumerable<string> options, int country, int state)
		{
		}

		public void Init(string appId, bool frictionlessRequests, string iosURLSuffix, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
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

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
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

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void OpenFriendFinderDialog(FacebookDelegate<IGamingServicesFriendFinderResult> callback)
		{
		}

		public override void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback)
		{
		}

		protected override void SetShareDialogMode(ShareDialogMode mode)
		{
		}

		public override void UploadImageToMediaLibrary(string caption, Uri imageUri, bool shouldLaunchMediaDialog, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		public override void UploadVideoToMediaLibrary(string caption, Uri videoUri, FacebookDelegate<IMediaUploadResult> callback)
		{
		}

		private static IIOSWrapper GetIOSWrapper()
		{
			return null;
		}

		private static NativeDict MarshallDict(Dictionary<string, object> dict)
		{
			return null;
		}

		private static NativeDict MarshallDict(Dictionary<string, string> dict)
		{
			return null;
		}

		private int AddCallback<T>(FacebookDelegate<T> callback) where T : IResult
		{
			return 0;
		}
	}
}
