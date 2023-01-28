using System;
using Firebase.Analytics;

[Serializable]
public class AnalyticsFormat
{
	public class DefaultInformation
	{
		public string EventTime;

		public string Language;

		public string Store;

		public long Count;

		public string UDID;
	}

	public class GameInformation
	{
		public int UserId;

		public string CreateTime;

		public int level;
	}

	public enum eType
	{
		None = 0,
		login = 1,
		login_new = 2,
		shopIAP = 3,
		shop = 4,
		shop_item = 5,
		battle = 6,
		gacha = 7,
		missionReward = 8,
		AchievementReward = 9,
		eventListReward = 10,
		schedule = 11,
		schedule_1 = 12,
		schedule_2 = 13,
		schedule_3 = 14,
		schedule_4 = 15,
		Size = 16
	}

	public string Category;

	public eType logType;

	public DefaultInformation default_Info;

	public GameInformation game_Info;

	public string val1;

	public string val2;

	public string val3;

	public string val4;

	public string val5;

	public static AnalyticsFormat GetFormat(eType logType, long actionCount = 1L)
	{
		return null;
	}

	public Parameter[] GetParam()
	{
		return null;
	}
}
