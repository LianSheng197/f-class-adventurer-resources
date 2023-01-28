using Firebase.Analytics;
using UnityEngine;

public class FirebaseAnalyticsIntegration : MonoBehaviour
{
	private bool initialize => false;

	private void OnApplicationQuit()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void initDataList()
	{
	}

	public void Initialize()
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

	public void LogTransaction(string productId, decimal price, AnalyticsIntegration.eCurrency currency, string receipt, string signature, string transactionId)
	{
	}

	public void LogItem(string name, string sku, string category, double price, long quantity, AnalyticsIntegration.eCurrency currency, string signature)
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

	public void LogEvent(string category, string action)
	{
	}

	public void LogEvent(string category, string action, string label)
	{
	}

	public void LogEvent(string category, string action, string label, long value)
	{
	}

	public void LogEvent(string category, Parameter[] Parameters)
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

	public void LogBattleStagePlay(string installDate, string logDate, string option1, string option2, string option3, string option4)
	{
	}

	public void LogBattleStage(string installDate, string logDate, bool isWin, string option1, string option2, string option3, string option4)
	{
	}

	public void LogComplete(string installDate, string logDate, string name)
	{
	}

	public void LogAdsInterstitial(string installDate, string logDate, string option1, string option3)
	{
	}

	public void LogAdsReward(string installDate, string logDate, string option1, string option3)
	{
	}

	public void LogAdsInterstitialShow(string installDate, string logDate, string option1, string option2, string option3)
	{
	}

	public void LogAdsRewardShow(string installDate, string logDate, string option1, string option2, string option3)
	{
	}

	public void LogTimeOutRetry(string reqType, int requestCount)
	{
	}
}
