using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Facebook.Unity
{
	internal abstract class FacebookBase : IFacebookImplementation, IFacebook, IFacebookResultHandler
	{
		private InitDelegate onInitCompleteDelegate;

		public abstract bool LimitEventUsage { get; set; }

		public abstract string SDKName { get; }

		public abstract string SDKVersion { get; }

		public virtual string SDKUserAgent => null;

		public virtual bool LoggedIn => false;

		public bool Initialized
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected CallbackManager CallbackManager
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

		protected FacebookBase(CallbackManager callbackManager)
		{
		}

		public virtual void Init(InitDelegate onInitComplete)
		{
		}

		public abstract void LogInWithPublishPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		public abstract void LogInWithReadPermissions(IEnumerable<string> scope, FacebookDelegate<ILoginResult> callback);

		public virtual void LogOut()
		{
		}

		public void AppRequest(string message, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		public abstract void AppRequest(string message, OGActionType? actionType, string objectId, IEnumerable<string> to, IEnumerable<object> filters, IEnumerable<string> excludeIds, int? maxRecipients, string data, string title, FacebookDelegate<IAppRequestResult> callback);

		public abstract void ShareLink(Uri contentURL, string contentTitle, string contentDescription, Uri photoURL, FacebookDelegate<IShareResult> callback);

		public abstract void FeedShare(string toId, Uri link, string linkName, string linkCaption, string linkDescription, Uri picture, string mediaSource, FacebookDelegate<IShareResult> callback);

		public void API(string query, HttpMethod method, IDictionary<string, string> formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		public void API(string query, HttpMethod method, WWWForm formData, FacebookDelegate<IGraphResult> callback)
		{
		}

		public abstract void ActivateApp(string appId = null);

		public abstract void GetAppLink(FacebookDelegate<IAppLinkResult> callback);

		public abstract void AppEventsLogEvent(string logEvent, float? valueToSum, Dictionary<string, object> parameters);

		public abstract void AppEventsLogPurchase(float logPurchase, string currency, Dictionary<string, object> parameters);

		public virtual void OnInitComplete(ResultContainer resultContainer)
		{
		}

		public abstract void OnLoginComplete(ResultContainer resultContainer);

		public void OnLogoutComplete(ResultContainer resultContainer)
		{
		}

		public abstract void OnGetAppLinkComplete(ResultContainer resultContainer);

		public abstract void OnAppRequestsComplete(ResultContainer resultContainer);

		public abstract void OnShareLinkComplete(ResultContainer resultContainer);

		protected void ValidateAppRequestArgs(string message, OGActionType? actionType, string objectId, IEnumerable<string> to = null, IEnumerable<object> filters = null, IEnumerable<string> excludeIds = null, int? maxRecipients = null, string data = "", string title = "", FacebookDelegate<IAppRequestResult> callback = null)
		{
		}

		protected virtual void OnAuthResponse(LoginResult result)
		{
		}

		private IDictionary<string, string> CopyByValue(IDictionary<string, string> data)
		{
			return null;
		}

		private Uri GetGraphUrl(string query)
		{
			return null;
		}
	}
}
