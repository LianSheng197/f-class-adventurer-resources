using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Facebook.Unity.Gameroom;
using Facebook.Unity.Mobile;
using UnityEngine;

namespace Facebook.Unity
{
	public sealed class FB : ScriptableObject
	{
		private delegate void OnDLLLoaded();

		public sealed class Canvas
		{
			private static IPayFacebook FacebookPayImpl => null;

			public static void Pay(string product, string action = "purchaseitem", int quantity = 1, int? quantityMin = null, int? quantityMax = null, string requestId = null, string pricepointId = null, string testCurrency = null, FacebookDelegate<IPayResult> callback = null)
			{
			}

			public static void PayWithProductId(string productId, string action = "purchaseiap", int quantity = 1, int? quantityMin = null, int? quantityMax = null, string requestId = null, string pricepointId = null, string testCurrency = null, FacebookDelegate<IPayResult> callback = null)
			{
			}

			public static void PayWithProductId(string productId, string action = "purchaseiap", string developerPayload = null, string testCurrency = null, FacebookDelegate<IPayResult> callback = null)
			{
			}
		}

		public sealed class Mobile
		{
			public static ShareDialogMode ShareDialogMode
			{
				get
				{
					return default(ShareDialogMode);
				}
				set
				{
				}
			}

			public static string UserID
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			private static IMobileFacebook MobileFacebookImpl => null;

			[Obsolete("This method UpdateUserProperties is deprecated.", false)]
			public static void UpdateUserProperties(Dictionary<string, string> parameters)
			{
			}

			public static void SetDataProcessingOptions(IEnumerable<string> options)
			{
			}

			public static void SetDataProcessingOptions(IEnumerable<string> options, int country, int state)
			{
			}

			public static void EnableProfileUpdatesOnAccessTokenChange(bool enable)
			{
			}

			public static void LoginWithTrackingPreference(LoginTracking loginTracking, IEnumerable<string> permissions = null, string nonce = null, FacebookDelegate<ILoginResult> callback = null)
			{
			}

			public static AuthenticationToken CurrentAuthenticationToken()
			{
				return null;
			}

			public static Profile CurrentProfile()
			{
				return null;
			}

			public static void FetchDeferredAppLinkData(FacebookDelegate<IAppLinkResult> callback = null)
			{
			}

			public static void RefreshCurrentAccessToken(FacebookDelegate<IAccessTokenRefreshResult> callback = null)
			{
			}

			public static bool IsImplicitPurchaseLoggingEnabled()
			{
				return false;
			}

			public static void SetAutoLogAppEventsEnabled(bool autoLogAppEventsEnabled)
			{
			}

			public static void SetAdvertiserIDCollectionEnabled(bool advertiserIDCollectionEnabled)
			{
			}

			public static bool SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled)
			{
				return false;
			}

			public static void SetPushNotificationsDeviceTokenString(string token)
			{
			}
		}

		public sealed class Android
		{
			public static string KeyHash => null;

			public static void RetrieveLoginStatus(FacebookDelegate<ILoginStatusResult> callback)
			{
			}
		}

		public sealed class Gameroom
		{
			private static IGameroomFacebook GameroomFacebookImpl => null;

			public static void PayPremium(FacebookDelegate<IPayResult> callback = null)
			{
			}

			public static void HasLicense(FacebookDelegate<IHasLicenseResult> callback = null)
			{
			}
		}

		internal abstract class CompiledFacebookLoader : MonoBehaviour
		{
			protected abstract FacebookGameObject FBGameObject { get; }

			public void Start()
			{
			}
		}

		private const string DefaultJSSDKLocale = "en_US";

		private static IFacebook facebook;

		private static bool isInitCalled;

		private static string facebookDomain;

		private static string gamingDomain;

		private static string graphApiVersion;

		public static string AppId
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

		public static string ClientToken
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

		public static string GraphApiVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsLoggedIn => false;

		public static bool IsInitialized => false;

		public static bool LimitAppEventUsage
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal static IFacebook FacebookImpl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal static string FacebookDomain
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private static OnDLLLoaded OnDLLLoadedDelegate
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

		public static void Init(InitDelegate onInitComplete = null, HideUnityDelegate onHideUnity = null, string authResponse = null)
		{
		}

		public static void Init(string appId, string clientToken = null, bool cookie = true, bool logging = true, bool status = true, bool xfbml = false, bool frictionlessRequests = true, string authResponse = null, string javascriptSDKLocale = "en_US", HideUnityDelegate onHideUnity = null, InitDelegate onInitComplete = null)
		{
		}

		public static void LogInWithPublishPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogInWithReadPermissions(IEnumerable<string> permissions = null, FacebookDelegate<ILoginResult> callback = null)
		{
		}

		public static void LogOut()
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<string> to, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, OGActionType actionType, string objectId, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void AppRequest(string message, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public static void ShareLink(Uri contentURL = null, string contentTitle = "", string contentDescription = "", Uri photoURL = null, FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void FeedShare(string toId = "", Uri link = null, string linkName = "", string linkCaption = "", string linkDescription = "", Uri picture = null, string mediaSource = "", FacebookDelegate<IShareResult> callback = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback = null, IDictionary<string, string> formData = null)
		{
		}

		public static void API(string query, HttpMethod method, FacebookDelegate<IGraphResult> callback, WWWForm formData)
		{
		}

		public static void ActivateApp()
		{
		}

		public static void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public static void ClearAppLink()
		{
		}

		public static void LogAppEvent(string logEvent, float? valueToSum = null, Dictionary<string, object> parameters = null)
		{
		}

		public static void LogPurchase(decimal logPurchase, string currency = null, Dictionary<string, object> parameters = null)
		{
		}

		public static void LogPurchase(float logPurchase, string currency = null, Dictionary<string, object> parameters = null)
		{
		}

		private static void LogVersion()
		{
		}
	}
}
