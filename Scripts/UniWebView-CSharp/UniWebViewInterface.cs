using UnityEngine;

public class UniWebViewInterface
{
	private static readonly AndroidJavaClass plugin;

	private static bool correctPlatform;

	static UniWebViewInterface()
	{
	}

	public static void SetLogLevel(int level)
	{
	}

	public static bool IsWebViewSupported()
	{
		return false;
	}

	public static void Init(string name, int x, int y, int width, int height)
	{
	}

	public static void Destroy(string name)
	{
	}

	public static void Load(string name, string url, bool skipEncoding, string readAccessURL)
	{
	}

	public static void LoadHTMLString(string name, string html, string baseUrl, bool skipEncoding)
	{
	}

	public static void Reload(string name)
	{
	}

	public static void Stop(string name)
	{
	}

	public static string GetUrl(string name)
	{
		return null;
	}

	public static void SetFrame(string name, int x, int y, int width, int height)
	{
	}

	public static void SetPosition(string name, int x, int y)
	{
	}

	public static void SetSize(string name, int width, int height)
	{
	}

	public static bool Show(string name, bool fade, int edge, float duration, bool useAsync, string identifier)
	{
		return false;
	}

	public static bool Hide(string name, bool fade, int edge, float duration, bool useAsync, string identifier)
	{
		return false;
	}

	public static bool AnimateTo(string name, int x, int y, int width, int height, float duration, float delay, string identifier)
	{
		return false;
	}

	public static void AddJavaScript(string name, string jsString, string identifier)
	{
	}

	public static void EvaluateJavaScript(string name, string jsString, string identifier)
	{
	}

	public static void AddUrlScheme(string name, string scheme)
	{
	}

	public static void RemoveUrlScheme(string name, string scheme)
	{
	}

	public static void AddSslExceptionDomain(string name, string domain)
	{
	}

	public static void RemoveSslExceptionDomain(string name, string domain)
	{
	}

	public static void AddPermissionTrustDomain(string name, string domain)
	{
	}

	public static void RemovePermissionTrustDomain(string name, string domain)
	{
	}

	public static void SetHeaderField(string name, string key, string value)
	{
	}

	public static void SetUserAgent(string name, string userAgent)
	{
	}

	public static string GetUserAgent(string name)
	{
		return null;
	}

	public static void SetAllowAutoPlay(bool flag)
	{
	}

	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	public static void SetAllowFileAccess(string name, bool flag)
	{
	}

	public static void SetAcceptThirdPartyCookies(string name, bool flag)
	{
	}

	public static void SetAllowFileAccessFromFileURLs(string name, bool flag)
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

	public static void CleanCache(string name)
	{
	}

	public static void ClearCookies()
	{
	}

	public static void SetCookie(string url, string cookie, bool skipEncoding)
	{
	}

	public static string GetCookie(string url, string key, bool skipEncoding)
	{
		return null;
	}

	public static void RemoveCookies(string url, bool skipEncoding)
	{
	}

	public static void RemoveCookie(string url, string key, bool skipEncoding)
	{
	}

	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	public static void SetBackgroundColor(string name, float r, float g, float b, float a)
	{
	}

	public static void SetWebViewAlpha(string name, float alpha)
	{
	}

	public static float GetWebViewAlpha(string name)
	{
		return 0f;
	}

	public static void SetShowSpinnerWhileLoading(string name, bool show)
	{
	}

	public static void SetSpinnerText(string name, string text)
	{
	}

	public static bool CanGoBack(string name)
	{
		return false;
	}

	public static bool CanGoForward(string name)
	{
		return false;
	}

	public static void GoBack(string name)
	{
	}

	public static void GoForward(string name)
	{
	}

	public static void SetOpenLinksInExternalBrowser(string name, bool flag)
	{
	}

	public static void SetHorizontalScrollBarEnabled(string name, bool enabled)
	{
	}

	public static void SetVerticalScrollBarEnabled(string name, bool enabled)
	{
	}

	public static void SetBouncesEnabled(string name, bool enabled)
	{
	}

	public static void SetZoomEnabled(string name, bool enabled)
	{
	}

	public static void SetUseWideViewPort(string name, bool use)
	{
	}

	public static void SetLoadWithOverviewMode(string name, bool overview)
	{
	}

	public static void SetImmersiveModeEnabled(string name, bool enabled)
	{
	}

	public static void SetUserInteractionEnabled(string name, bool enabled)
	{
	}

	public static void SetTransparencyClickingThroughEnabled(string name, bool enabled)
	{
	}

	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	public static void SetAllowHTTPAuthPopUpWindow(string name, bool flag)
	{
	}

	public static void Print(string name)
	{
	}

	public static void CaptureSnapshot(string name, string filename)
	{
	}

	public static void ScrollTo(string name, int x, int y, bool animated)
	{
	}

	public static void SetCalloutEnabled(string name, bool flag)
	{
	}

	public static void SetSupportMultipleWindows(string name, bool enabled, bool allowJavaScriptOpening)
	{
	}

	public static void SetDefaultFontSize(string name, int size)
	{
	}

	public static void SetTextZoom(string name, int textZoom)
	{
	}

	public static float NativeScreenWidth()
	{
		return 0f;
	}

	public static float NativeScreenHeight()
	{
		return 0f;
	}

	public static void SetDownloadEventForContextMenuEnabled(string name, bool enabled)
	{
	}

	public static bool IsSafeBrowsingSupported()
	{
		return false;
	}

	public static void SafeBrowsingInit(string name, string url)
	{
	}

	public static void SafeBrowsingSetToolbarColor(string name, float r, float g, float b)
	{
	}

	public static void SafeBrowsingShow(string name)
	{
	}

	public static void CheckPlatform()
	{
	}
}
