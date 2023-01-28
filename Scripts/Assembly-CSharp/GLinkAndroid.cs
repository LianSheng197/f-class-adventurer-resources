using UnityEngine;

public class GLinkAndroid : IGLink
{
	private class OnSdkLoadListener : AndroidJavaProxy
	{
		public OnSdkLoadListener()
			: base((string)null)
		{
		}

		public void onSdkDidLoaded()
		{
		}

		public void onSdkDidUnloaded()
		{
		}

		public void onCallInGameMenuCode(string moveTo)
		{
		}

		public void onNaverLoggedIn()
		{
		}
	}

	private AndroidJavaClass glinkClass;

	private AndroidJavaObject currentActivity;

	public string getSdkVersion()
	{
		return null;
	}

	public string getCountryCode()
	{
		return null;
	}

	public void executeHomeBanner()
	{
	}

	public void executeSorryBanner()
	{
	}

	public void executeBoard(int boardId)
	{
	}

	public void executeFeed(long feedId, bool isTempFeedId)
	{
	}

	public void executeFeedWriting(int boardId, string title, string text, string imageFilePath)
	{
	}

	public void setCanWriteFeedByScreenshot(bool enabled)
	{
	}

	public void setGameId(string gameId)
	{
	}

	public void init(string loungeId, string clientId, string clientSecret)
	{
	}

	public void terminateSdk()
	{
	}
}
