using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Canvas
{
	internal sealed class CanvasFacebook : FacebookBase, ICanvasFacebookImplementation, ICanvasFacebook, IPayFacebook, IFacebook, ICanvasFacebookResultHandler, IFacebookResultHandler
	{
		private class CanvasUIMethodCall<T> : MethodCall<T> where T : IResult
		{
			private CanvasFacebook canvasImpl;

			private string callbackMethod;

			public CanvasUIMethodCall(CanvasFacebook canvasImpl, string methodName, string callbackMethod)
			{
				((MethodCall<>)(object)this)._002Ector((FacebookBase)null, (string)null);
			}

			public override void Call(MethodArguments args)
			{
			}

			private void UI(string method, MethodArguments args, FacebookDelegate<T> callback = null)
			{
			}
		}

		internal const string MethodAppRequests = "apprequests";

		internal const string MethodFeed = "feed";

		internal const string MethodPay = "pay";

		internal const string CancelledResponse = "{\"cancelled\":true}";

		internal const string FacebookConnectURL = "https://connect.facebook.net";

		private const string AuthResponseKey = "authResponse";

		private string appId;

		private string appLinkUrl;

		private ICanvasJSWrapper canvasJSWrapper;

		private HideUnityDelegate onHideUnityDelegate;

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

		public override string SDKName => null;

		public override string SDKVersion => null;

		public override string SDKUserAgent => null;

		public CanvasFacebook()
			: base(null)
		{
		}

		public CanvasFacebook(ICanvasJSWrapper canvasJSWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		private static ICanvasJSWrapper GetCanvasJSWrapper()
		{
			return null;
		}

		public void Init(string appId, bool cookie, bool logging, bool status, bool xfbml, string channelUrl, string authResponse, bool frictionlessRequests, string javascriptSDKLocale, bool loadDebugJSSDK, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> permissions, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogOut()
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void ActivateApp(string appId)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
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

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float purchaseAmount, string currency, Dictionary<string, object> parameters)
		{
		}

		public override void OnLoginComplete(ResultContainer result)
		{
		}

		public override void OnGetAppLinkComplete(ResultContainer message)
		{
		}

		public void OnFacebookAuthResponseChange(string responseJsonData)
		{
		}

		public void OnFacebookAuthResponseChange(ResultContainer resultContainer)
		{
		}

		public void OnPayComplete(string responseJsonData)
		{
		}

		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		public override void OnAppRequestsComplete(ResultContainer resultContainer)
		{
		}

		public override void OnShareLinkComplete(ResultContainer resultContainer)
		{
		}

		public void OnUrlResponse(string url)
		{
		}

		public void OnHideUnity(bool isGameShown)
		{
		}

		private static void FormatAuthResponse(ResultContainer result, Utilities.Callback<ResultContainer> callback)
		{
		}

		private void PayImpl(string product, string productId, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, FacebookDelegate<IPayResult> callback)
		{
		}
	}
}
