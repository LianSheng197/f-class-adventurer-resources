using System;

[Serializable]
public class ClientSave
{
	public enum eType
	{
		None = 0,
		ChangeName = 1,
		Intro = 2,
		NoAutoAds = 3,
		NoAds = 4,
		ContentReset = 5,
		StageRandomRewardDouble = 6,
		LastPlayStage = 7,
		LastUpgradeSlot = 8,
		OpenUpgradeSlot = 9,
		SumSkillLevel = 10,
		SumSkillLevel2 = 11,
		SumLegendFame = 12,
		SumLegendLevel = 13,
		MaxAttackDistance = 14,
		MaxAttackSpeed = 15,
		MaxMoveSpeed = 16,
		MinSkillCoolTime = 17,
		MinSkillGlobalCoolTime = 18,
		MinAttackDuration = 19,
		MaxRealMoveSpeedOffset = 20,
		MaxRealMoveSpeed = 21,
		MaxRealMove = 22,
		MinSkillTargetCoolTime = 23,
		MaxRealMoveSpeedBase = 24,
		MaxRealMoveSpeedBase2 = 25,
		MaxRealMoveDeltaTime = 26,
		MinRealMoveDeltaTime = 27,
		MinRealAttackSpeed = 28,
		SumEquipmentLevel = 29,
		SumEquipmentLevel_Weapon = 30,
		SumEquipmentLevel_Armor = 31,
		SumEquipmentLevel_Accessory = 32,
		SumEquipmentLevel_Charm = 33,
		MeanRealMoveDeltaTime = 34,
		StdDevRealMoveDeltaTime = 35,
		AdsWorldCount = 500,
		AdsWorldUpdateTime = 501,
		AdsCoolTimeShopId = 502,
		AdsCoolTimeLastUpdateTime = 503,
		UserLastConnectTime = 504,
		LastBattleGuildBossTime = 505,
		RetentionPushID = 506,
		GuildFireCount = 507,
		MTS = 508,
		LastPlayStage_Normal1 = 5000,
		LastPlayStage_Normal2 = 5001,
		LastPlayStage_Normal3 = 5002,
		Tutorial = 10000,
		Tutorial_Max = 11000,
		AdsRewardTime_Start = 20000,
		AdsRewardTime_End = 20100,
		OfflineRewardTime = 100000,
		WorldScenario = 110000,
		WorldScenario_Max = 120000,
		StageScenario = 130000,
		StageScenario_Max = 140000,
		ClearWorldScenario = 200000,
		ClearWorldScenario_Max = 210000,
		Max = 210001
	}

	public int _userId;

	public int _type;

	public string _value;

	public DateTime _updateTime;

	public string _prevValue;

	public DateTime _prevUpdateTime;

	public ClientSave()
	{
	}

	public ClientSave(int type, string value, DateTime updateTime, string prevValue, DateTime prevUpdateTime)
	{
	}
}
