using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	public delegate void PageStartedDelegate(UniWebView webView, string url);

	public delegate void PageFinishedDelegate(UniWebView webView, int statusCode, string url);

	public delegate void PageErrorReceivedDelegate(UniWebView webView, int errorCode, string errorMessage);

	public delegate void PageProgressChangedDelegate(UniWebView webView, float progress);

	public delegate void MessageReceivedDelegate(UniWebView webView, UniWebViewMessage message);

	public delegate bool ShouldCloseDelegate(UniWebView webView);

	public delegate void OrientationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	public delegate void OnWebContentProcessTerminatedDelegate(UniWebView webView);

	public delegate void FileDownloadStarted(UniWebView webView, string remoteUrl, string fileName);

	public delegate void FileDownloadFinished(UniWebView webView, int errorCode, string remoteUrl, string diskPath);

	public delegate void CaptureSnapshotFinished(UniWebView webView, int errorCode, string diskPath);

	public delegate void MultipleWindowOpenedDelegate(UniWebView webView, string multipleWindowId);

	public delegate void MultipleWindowClosedDelegate(UniWebView webView, string multipleWindowId);

	[Obsolete("KeyCodeReceivedDelegate is deprecated. Now UniWebView never intercepts device key code events. Check `Input.GetKeyUp` instead.", false)]
	public delegate void KeyCodeReceivedDelegate(UniWebView webView, int keyCode);

	private string id;

	private UniWebViewNativeListener listener;

	private bool isPortrait;

	[SerializeField]
	private string urlOnStart;

	[SerializeField]
	private bool showOnStart;

	[SerializeField]
	private bool fullScreen;

	[SerializeField]
	private bool useToolbar;

	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition;

	private Dictionary<string, Action> actions;

	private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions;

	[SerializeField]
	private Rect frame;

	[SerializeField]
	private RectTransform referenceRectTransform;

	private bool started;

	private bool backButtonEnabled;

	private Color backgroundColor;

	public Rect Frame
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public RectTransform ReferenceRectTransform
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Url => null;

	public static bool IsWebViewSupported => false;

	public bool CanGoBack => false;

	public bool CanGoForward => false;

	public Color BackgroundColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float Alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public event PageStartedDelegate OnPageStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event PageFinishedDelegate OnPageFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event PageErrorReceivedDelegate OnPageErrorReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event PageProgressChangedDelegate OnPageProgressChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MessageReceivedDelegate OnMessageReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ShouldCloseDelegate OnShouldClose
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OrientationChangedDelegate OnOrientationChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event FileDownloadStarted OnFileDownloadStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event FileDownloadFinished OnFileDownloadFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event CaptureSnapshotFinished OnCaptureSnapshotFinished
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MultipleWindowOpenedDelegate OnMultipleWindowOpened
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MultipleWindowClosedDelegate OnMultipleWindowClosed
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[Obsolete("OnKeyCodeReceived is deprecated and never called. Now UniWebView never intercepts device key code events. Check `Input.GetKeyUp` instead.", false)]
	public event KeyCodeReceivedDelegate OnKeyCodeReceived
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void UpdateFrame()
	{
	}

	private Rect NextFrameRect()
	{
		return default(Rect);
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Load(string url, bool skipEncoding = false, string readAccessURL = null)
	{
	}

	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false)
	{
	}

	public void Reload()
	{
	}

	public void Stop()
	{
	}

	public void GoBack()
	{
	}

	public void GoForward()
	{
	}

	public void SetOpenLinksInExternalBrowser(bool flag)
	{
	}

	public bool Show(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool _Show(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, bool useAsync = false, Action completionHandler = null)
	{
		return false;
	}

	public bool Hide(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, Action completionHandler = null)
	{
		return false;
	}

	public bool _Hide(bool fade = false, UniWebViewTransitionEdge edge = UniWebViewTransitionEdge.None, float duration = 0.4f, bool useAsync = false, Action completionHandler = null)
	{
		return false;
	}

	public bool AnimateTo(Rect frame, float duration, float delay = 0f, Action completionHandler = null)
	{
		return false;
	}

	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = null)
	{
	}

	public void AddUrlScheme(string scheme)
	{
	}

	public void RemoveUrlScheme(string scheme)
	{
	}

	public void AddSslExceptionDomain(string domain)
	{
	}

	public void RemoveSslExceptionDomain(string domain)
	{
	}

	public void SetHeaderField(string key, string value)
	{
	}

	public void SetUserAgent(string agent)
	{
	}

	public string GetUserAgent()
	{
		return null;
	}

	public void SetContentInsetAdjustmentBehavior(UniWebViewContentInsetAdjustmentBehavior behavior)
	{
	}

	public static void SetAllowAutoPlay(bool flag)
	{
	}

	public static void SetAllowInlinePlay(bool flag)
	{
	}

	public void SetAllowFileAccess(bool flag)
	{
	}

	public void SetAllowFileAccessFromFileURLs(bool flag)
	{
	}

	public void SetAcceptThirdPartyCookies(bool flag)
	{
	}

	public static void SetAllowUniversalAccessFromFileURLs(bool flag)
	{
	}

	public static void SetEnableKeyboardAvoidance(bool flag)
	{
	}

	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	public void CleanCache()
	{
	}

	public static void ClearCookies()
	{
	}

	public static void SetCookie(string url, string cookie, bool skipEncoding = false)
	{
	}

	public static string GetCookie(string url, string key, bool skipEncoding = false)
	{
		return null;
	}

	public static void RemoveCookies(string url, bool skipEncoding = false)
	{
	}

	public static void RemoveCooke(string url, string key, bool skipEncoding = false)
	{
	}

	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	public void SetShowSpinnerWhileLoading(bool flag)
	{
	}

	public void SetSpinnerText(string text)
	{
	}

	public void SetHorizontalScrollBarEnabled(bool enabled)
	{
	}

	public void SetVerticalScrollBarEnabled(bool enabled)
	{
	}

	public void SetBouncesEnabled(bool enabled)
	{
	}

	public void SetZoomEnabled(bool enabled)
	{
	}

	public void AddPermissionTrustDomain(string domain)
	{
	}

	public void RemovePermissionTrustDomain(string domain)
	{
	}

	public void SetBackButtonEnabled(bool enabled)
	{
	}

	public void SetUseWideViewPort(bool flag)
	{
	}

	public void SetLoadWithOverviewMode(bool flag)
	{
	}

	public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false)
	{
	}

	public void SetToolbarDoneButtonText(string text)
	{
	}

	public void SetToolbarGoBackButtonText(string text)
	{
	}

	public void SetToolbarGoForwardButtonText(string text)
	{
	}

	public void SetToolbarTintColor(Color color)
	{
	}

	public void SetToolbarTextColor(Color color)
	{
	}

	public void SetShowToolbarNavigationButtons(bool show)
	{
	}

	public void SetUserInteractionEnabled(bool enabled)
	{
	}

	public void SetTransparencyClickingThroughEnabled(bool enabled)
	{
	}

	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	public void SetWindowUserResizeEnabled(bool enabled)
	{
	}

	public void GetHTMLContent(Action<string> handler)
	{
	}

	public void SetAllowBackForwardNavigationGestures(bool flag)
	{
	}

	public void SetAllowHTTPAuthPopUpWindow(bool flag)
	{
	}

	public void SetCalloutEnabled(bool enabled)
	{
	}

	[Obsolete("Deprecated. Use `SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpen)` to set `allowJavaScriptOpen` explicitly.")]
	public void SetSupportMultipleWindows(bool enabled)
	{
	}

	public void SetSupportMultipleWindows(bool enabled, bool allowJavaScriptOpening)
	{
	}

	public void SetDefaultFontSize(int size)
	{
	}

	public void SetTextZoom(int textZoom)
	{
	}

	public void SetDragInteractionEnabled(bool enabled)
	{
	}

	public void Print()
	{
	}

	public void CaptureSnapshot(string fileName)
	{
	}

	public void ScrollTo(int x, int y, bool animated)
	{
	}

	public void AddDownloadURL(string urlString, UniWebViewDownloadMatchingType type = UniWebViewDownloadMatchingType.ExactValue)
	{
	}

	public void RemoveDownloadURL(string urlString, UniWebViewDownloadMatchingType type = UniWebViewDownloadMatchingType.ExactValue)
	{
	}

	public void AddDownloadMIMEType(string MIMEType, UniWebViewDownloadMatchingType type = UniWebViewDownloadMatchingType.ExactValue)
	{
	}

	public void RemoveDownloadMIMETypes(string MIMEType, UniWebViewDownloadMatchingType type = UniWebViewDownloadMatchingType.ExactValue)
	{
	}

	public void SetAllowUserChooseActionAfterDownloading(bool allowed)
	{
	}

	public void SetDownloadEventForContextMenuEnabled(bool enabled)
	{
	}

	private void OnDestroy()
	{
	}

	internal void InternalOnShowTransitionFinished(string identifier)
	{
	}

	internal void InternalOnHideTransitionFinished(string identifier)
	{
	}

	internal void InternalOnAnimateToFinished(string identifier)
	{
	}

	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageStarted(string url)
	{
	}

	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnPageProgressChanged(float progress)
	{
	}

	internal void InternalOnMessageReceived(string result)
	{
	}

	internal void InternalOnShouldClose()
	{
	}

	internal void InternalOnWebContentProcessDidTerminate()
	{
	}

	internal void InternalOnMultipleWindowOpened(string multiWindowId)
	{
	}

	internal void InternalOnMultipleWindowClosed(string multiWindowId)
	{
	}

	internal void InternalOnFileDownloadStarted(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnFileDownloadFinished(UniWebViewNativeResultPayload payload)
	{
	}

	internal void InternalOnCaptureSnapshotFinished(UniWebViewNativeResultPayload payload)
	{
	}

	[Obsolete("SetImmersiveModeEnabled is deprecated. Now UniWebView always respect navigation bar/status bar settings from Unity.", false)]
	public void SetImmersiveModeEnabled(bool enabled)
	{
	}
}
