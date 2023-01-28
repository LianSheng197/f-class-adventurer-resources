using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Facebook.Unity.Gameroom
{
	internal sealed class GameroomFacebook : FacebookBase, IGameroomFacebookImplementation, IGameroomFacebook, IPayFacebook, IFacebook, IGameroomFacebookResultHandler, IFacebookResultHandler
	{
		public delegate void OnComplete(ResultContainer resultContainer);

		private string appId;

		private IGameroomWrapper gameroomWrapper;

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

		public GameroomFacebook()
			: base(null)
		{
		}

		public GameroomFacebook(IGameroomWrapper gameroomWrapper, CallbackManager callbackManager)
			: base(null)
		{
		}

		public void Init(string appId, HideUnityDelegate hideUnityDelegate, InitDelegate onInitComplete)
		{
		}

		public override void ActivateApp(string appId = null)
		{
		}

		public override void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters)
		{
		}

		public override void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters)
		{
		}

		public override void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback)
		{
		}

		public override void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback)
		{
		}

		public override void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback)
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

		public void PayPremium(FacebookDelegate<IPayResult> callback)
		{
		}

		public void HasLicense(FacebookDelegate<IHasLicenseResult> callback)
		{
		}

		public override void GetAppLink(FacebookDelegate<IAppLinkResult> callback)
		{
		}

		public override void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}

		public override void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
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

		public void OnPayComplete(ResultContainer resultContainer)
		{
		}

		public void OnHasLicenseComplete(ResultContainer resultContainer)
		{
		}

		public bool HaveReceivedPipeResponse()
		{
			return false;
		}

		public string GetPipeResponse(string callbackId)
		{
			return null;
		}

		private static IGameroomWrapper GetGameroomWrapper()
		{
			return null;
		}

		private void PayImpl(string product, string productId, string action, int quantity, int? quantityMin, int? quantityMax, string requestId, string pricepointId, string testCurrency, string developerPayload, FacebookDelegate<IPayResult> callback)
		{
		}

		private void LoginWithPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback)
		{
		}
	}
}
