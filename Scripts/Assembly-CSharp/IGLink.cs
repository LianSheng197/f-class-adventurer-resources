public interface IGLink
{
	void init(string loungeId, string clientId, string clientSecret);

	void terminateSdk();

	void executeHomeBanner();

	void executeSorryBanner();

	void executeBoard(int boardId);

	void executeFeed(long feedId, bool isTempFeedId);

	void executeFeedWriting(int boardId = 0, string title = "", string text = "", string imageFilePath = "");

	string getSdkVersion();

	string getCountryCode();

	void setCanWriteFeedByScreenshot(bool enabled);

	void setGameId(string gameId);
}
