using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
	public enum OptionType
	{
		BGMVolume = 0,
		SEVolume = 1,
		Original_Screen_Width = 2,
		Original_Screen_Height = 3,
		Android_Permission = 4,
		LoginID = 5,
		GoogleID = 6,
		AppleID = 7,
		ServicesPolicy = 8,
		Language = 9,
		Achievement_Filter_Gold = 10,
		Achievement_Filter_Silver = 11,
		Achievement_Filter_Bronze = 12,
		BeginnerMissionUserID = 13,
		BeginnerMission = 14,
		SelectedConfig = 15,
		NewTowerSkill = 16,
		SkillSlot = 17,
		SkillSlotChange = 18,
		SkillAutoSetting = 19,
		SkillAutoSettingCustom = 20,
		SleepModeTime = 21,
		EnableSystemSleep = 22,
		EnableMusic = 23,
		EnableSFX = 24,
		EnableScreenShaking = 25,
		EnableEffect = 26,
		EnableDamageFont = 27,
		EnablePush = 28,
		AchievementNew = 29,
		RequestStoreReview = 30,
		RequestStoreReviewCount = 31,
		FirstOpenDateTime = 32,
		LanguageOrg = 33,
		Skin = 34,
		UpgradeNew = 35,
		EnableGatchaSkipEffect = 36,
		CharacterUpgradeCount = 37,
		PotentialEffectSkip = 38,
		NewTrialWorld = 39,
		NewCharm = 40,
		SellTypeALL = 41,
		NewTreasure = 42,
		NewTreasureGlobalMenu = 43,
		NewCharacteristic = 44,
		NewCharacteristicGlobalMenu = 45,
		NormalWorld_OpenAlert = 46,
		NewCharacteristic_Tower = 47,
		Max = 48
	}

	public enum AdsData
	{
		countperday = 0,
		time = 1,
		zonenumber = 2
	}

	public static Dictionary<OptionType, string> _keyList;

	private static SupportLanguage.Language _curLang;

	public static void InitOptionKey()
	{
	}

	public static string GetOptionKey(OptionType type)
	{
		return null;
	}

	public static void DeleteAll()
	{
	}

	public static void ChangeAccount(string userKey)
	{
	}

	public static string GetOption(OptionType option, string defaultOption)
	{
		return null;
	}

	public static string GetOption(string option, string defaultOption)
	{
		return null;
	}

	public static int GetOption(OptionType option, int defaultOption)
	{
		return 0;
	}

	public static float GetOption(OptionType option, float defaultOption)
	{
		return 0f;
	}

	public static bool GetOption(OptionType option, bool defaultOption)
	{
		return false;
	}

	public static void SetOption(OptionType option, string value)
	{
	}

	public static void SetOption(string option, string value)
	{
	}

	public static void SetOption(OptionType option, int value)
	{
	}

	public static void SetOption(OptionType option, float value)
	{
	}

	public static void SetOption(OptionType option, bool value)
	{
	}

	public static SupportLanguage.Language GetLanguage()
	{
		return default(SupportLanguage.Language);
	}

	public static void SetLanguage(SupportLanguage.Language language)
	{
	}

	public static SupportLanguage.Language GetLanguageOrg()
	{
		return default(SupportLanguage.Language);
	}

	public static void SetLanguageOrg(SupportLanguage.Language language)
	{
	}

	public static void Save<T>(string name, T instance)
	{
	}

	public static T Load<T>(string name) where T : new()
	{
		return default(T);
	}

	public static void SetSpecialMissionNew(int specialMissionId, int lastCriteriaVal, bool isNew)
	{
	}

	public static int GetNewSpecialMission(int specialMissionId, ref bool isNew)
	{
		return 0;
	}

	public static List<int> GetUpgradeNew()
	{
		return null;
	}

	public static void UpdateUpgradeNew(List<int> newList)
	{
	}

	public static List<bool> GetSkillAutoSetting(int slot, int useSlot)
	{
		return null;
	}

	public static void SetSkillAutoSetting(int slot, List<bool> saves)
	{
	}

	public static List<bool> GetSkillAutoSettingCustom(int slot, int useSlot)
	{
		return null;
	}

	public static void SetSkillAutoSettingCustom(int slot, List<bool> saves)
	{
	}

	public static List<int> GetTrialNew()
	{
		return null;
	}

	public static void UpdateTrialNew(List<int> newList)
	{
	}

	public static bool IsNewCharm()
	{
		return false;
	}

	public static void UpdateNewCharm()
	{
	}

	public static List<int> GetNormalWorldOpenAlert()
	{
		return null;
	}

	public static void UpdateNormalWorldOpenAlert(List<int> list)
	{
	}
}
