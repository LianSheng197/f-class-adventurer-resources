using UnityEngine;

public class AnalyticsIntegration : MonoBehaviour
{
	public enum eCurrency
	{
		KRW = 0,
		USD = 1,
		JPY = 2
	}

	private FirebaseAnalyticsIntegration firebaseAnalytics;

	private static AnalyticsIntegration instance;

	private bool initialize;

	public static AnalyticsIntegration Instance => null;

	public void Initialize()
	{
	}

	public void AdjustInitialize()
	{
	}

	public void StartSession()
	{
	}

	public void StopSession()
	{
	}

	public void LogUserId(string userId)
	{
	}

	public void LogUserLevel(int userLevel)
	{
	}

	public void LogUserFriendCount(int friendCount)
	{
	}

	public void LogGender(char gender)
	{
	}

	public void LogBirthYear(int birthYear)
	{
	}

	public void LogLanguage(string language)
	{
	}

	public void LogLanguageOS(string language)
	{
	}

	public void LogScreen(string title)
	{
	}

	public void LogTransaction(string productId, decimal price, eCurrency currency, string receipt, string signature, string transactionId)
	{
	}

	public void LogItem(string name, string sku, string category, double price, long quantity, eCurrency currency, string signature)
	{
	}

	public void LogFirstTimeExperience(string name)
	{
	}

	public void LogRetention(string name)
	{
	}

	public void LogRetention(string name, string param)
	{
	}

	public void LogCustomCohort(int type, string filterName)
	{
	}

	public void LogTiming(string category, long interval)
	{
	}

	public void LogTiming(string category, long interval, string name)
	{
	}

	public void LogTiming(string category, long interval, string name, string label)
	{
	}

	public void LogEvent(string category, string action, string label, long value)
	{
	}

	public void LogBattleStagePlay(string option1, string option2, string option3, string option4)
	{
	}

	public void LogBattleStage(bool isWin, string option1, string option2, string option3, string option4)
	{
	}

	public void LogComplete(string name)
	{
	}

	public void LogAdsInterstitial(string placement)
	{
	}

	public void LogAdsReward(string placement)
	{
	}

	public void LogAdsInterstitialShow(string placement, string state)
	{
	}

	public void LogAdsRewardShow(string placement, string state)
	{
	}

	public void LogTimeOut(string reqType, int requestCount)
	{
	}

	public void Schedule()
	{
	}

	private void Schedule1()
	{
	}

	private void Schedule2()
	{
	}

	public void Schedule3()
	{
	}

	public void CreateAccount()
	{
	}

	public void Login()
	{
	}

	public void BuyShop(int shopId, int buyCount)
	{
	}

	public void Battle(BattleData.BattleType battleType, bool battleResult, int worldId, int stageId)
	{
	}

	public void Gacha(long gachaIdx, bool isFreeGacha)
	{
	}

	public void MissionReward(int missionId)
	{
	}

	public void AchievementReward(int achievementId)
	{
	}

	public void EventListReward(EventList.eventType eventType, long eventIdx, long subIdx)
	{
	}
}
