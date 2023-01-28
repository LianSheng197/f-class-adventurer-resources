using UnityEngine;

public class WebViewForUniWebView : MonoBehaviour
{
	public delegate void LoadCompleteDelegate();

	public delegate void CloseDelegate(bool isError, string errorMsg);

	private static WebViewForUniWebView _instance;

	private static GameObject _container;

	public LoadCompleteDelegate _loadCompleteDelegate;

	public CloseDelegate _closeDelegate;

	private UniWebView _webView;

	private int _x;

	private int _y;

	private int _width;

	private int _height;

	public static WebViewForUniWebView Instance => null;

	public static void Open(string url, LoadCompleteDelegate loadCompleteDelegate, CloseDelegate closeDelegate)
	{
	}

	public static void Load(string url)
	{
	}

	public static void Close()
	{
	}

	public static void WebViewRect(int x, int y, int width, int height)
	{
	}

	public void OpenWebView(string url, LoadCompleteDelegate loadCompleteDelegate, CloseDelegate closeDelegate)
	{
	}

	public void LoadWebView(string url)
	{
	}

	public void CloseWebView()
	{
	}

	public void SetRect(int x, int y, int width, int height)
	{
	}

	private void OnPageFinished(UniWebView webView, int statusCode, string url)
	{
	}

	private void OnPageErrorReceivedDelegate(UniWebView webView, int errorCode, string errorMessage)
	{
	}

	private void OnReceivedMessage(UniWebView webView, UniWebViewMessage message)
	{
	}

	private void OnEvalJavaScriptFinished(UniWebView webView, string result)
	{
	}

	private bool OnShouldClose(UniWebView webView)
	{
		return false;
	}
}
