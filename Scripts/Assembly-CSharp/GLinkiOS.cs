using UnityEngine;

public class GLinkiOS : MonoBehaviour, IGLink
{
	public void init(string loungeId, string clientId, string clientSecret)
	{
	}

	public string getSdkVersion()
	{
		return null;
	}

	public string getCountryCode()
	{
		return null;
	}

	public void setCanWriteFeedByScreenshot(bool enabled)
	{
	}

	public void setGameId(string gameId)
	{
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

	public void terminateSdk()
	{
	}
}
