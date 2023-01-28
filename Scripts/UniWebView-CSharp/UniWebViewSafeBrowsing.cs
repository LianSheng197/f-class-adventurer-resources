using System.Runtime.CompilerServices;
using UnityEngine;

public class UniWebViewSafeBrowsing : Object
{
	public delegate void OnSafeBrowsingFinishedDelegate(UniWebViewSafeBrowsing browsing);

	private string id;

	private UniWebViewNativeListener listener;

	private string url;

	public static bool IsSafeBrowsingSupported => false;

	public event OnSafeBrowsingFinishedDelegate OnSafeBrowsingFinished
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

	public static UniWebViewSafeBrowsing Create(string url)
	{
		return null;
	}

	public void Show()
	{
	}

	public void Dismiss()
	{
	}

	public void SetToolbarColor(Color color)
	{
	}

	public void SetToolbarItemColor(Color color)
	{
	}

	private UniWebViewSafeBrowsing()
	{
	}

	private void Init(string url)
	{
	}

	internal void InternalSafeBrowsingFinished()
	{
	}
}
