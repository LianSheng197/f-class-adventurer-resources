using System.Collections.Generic;
using UnityEngine;

public class UniWebViewNativeListener : MonoBehaviour
{
	private static Dictionary<string, UniWebViewNativeListener> listeners;

	[HideInInspector]
	public UniWebView webView;

	[HideInInspector]
	public UniWebViewSafeBrowsing safeBrowsing;

	public string Name => null;

	public static void AddListener(UniWebViewNativeListener target)
	{
	}

	public static void RemoveListener(string name)
	{
	}

	public static UniWebViewNativeListener GetListener(string name)
	{
		return null;
	}

	public void PageStarted(string url)
	{
	}

	public void PageFinished(string result)
	{
	}

	public void PageErrorReceived(string result)
	{
	}

	public void PageProgressChanged(string result)
	{
	}

	public void ShowTransitionFinished(string identifer)
	{
	}

	public void HideTransitionFinished(string identifer)
	{
	}

	public void AnimateToFinished(string identifer)
	{
	}

	public void AddJavaScriptFinished(string result)
	{
	}

	public void EvalJavaScriptFinished(string result)
	{
	}

	public void MessageReceived(string result)
	{
	}

	public void WebViewDone(string param)
	{
	}

	public void WebContentProcessDidTerminate(string param)
	{
	}

	public void SafeBrowsingFinished(string param)
	{
	}

	public void MultipleWindowOpened(string param)
	{
	}

	public void MultipleWindowClosed(string param)
	{
	}

	public void FileDownloadStarted(string result)
	{
	}

	public void FileDownloadFinished(string result)
	{
	}

	public void CaptureSnapshotFinished(string result)
	{
	}
}
