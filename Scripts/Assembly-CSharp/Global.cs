using System;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Global
{
	private static Global _instance;

	public CUser _User;

	public GameData _gameData;

	public Inventory _inventory;

	public BattleInfo _battleInfo;

	public InstantShopInventory _instantShopInventory;

	public EventManager _eventManager;

	public EventCardOpenManager _eventCardOpenManager;

	private List<ContentsFunctionData> _characterEnchantContentsFunction;

	public SpecialMissionManager _specialMissionManager;

	public List<InstantShop> _shopNowOnlyList;

	public CharacterMagicManager _characterMagicManager;

	public int _randomSeed;

	public Dictionary<RandomSeed.eType, RandomSeed> _randomSeeds;

	public bool _isCalcContentsFunction;

	private List<ContentsFunctionData> _contentsFunctionSum;

	private Dictionary<int, List<ContentsFunctionData>> _dicContentsFunctionSum;

	private CalcContentsFunction _calcContentsFunction;

	public string _systemLocale;

	public bool _isJoinedGuild;

	private string MyGuildName;

	public bool _isReturnGuildBoss;

	public int _returnStageId;

	public bool _isAdsBattlePlay;

	public GuildNotification _guildNotification;

	private BigInteger _beforeBattleStat;

	public int _changeRankingWorldId;

	public int _oldBossRank;

	public int _newBossRank;

	public DealRankingData _dealRankingData;

	private float _updateOfflineTime;

	public AdsBuffManager _adsBuffManager;

	public AdsManager _adsManager;

	private int _interstitialCount;

	public static Global Instance => null;

	public static string LoginID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string GoogleID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string AppleID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void MakeGuestID()
	{
	}

	public void LoginToServer()
	{
	}

	public void callBackTitle(GameObject obj, UIButton btn)
	{
	}

	public int GetUserLevel()
	{
		return 0;
	}

	public void UpdateCharacterEnchantContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public List<ContentsFunctionData> GetContentsFunctionList(int functionType)
	{
		return null;
	}

	public void CalcContentsFunctionList()
	{
	}

	public void Init()
	{
	}

	public static string ConvertTimeString(TimeSpan span)
	{
		return null;
	}

	public static string ConvertTimeStringShort(TimeSpan span)
	{
		return null;
	}

	public void AddInterstitialCount()
	{
	}

	public int GetInterstitialCount()
	{
		return 0;
	}

	public void ResetInterstitialCount()
	{
	}

	public bool CheckInterstitial()
	{
		return false;
	}

	public void SetAchievementNew(bool isNew)
	{
	}

	public bool IsAchievementNew()
	{
		return false;
	}

	public void SetRequestStoreReview()
	{
	}

	public bool IsRequestStoreReview()
	{
		return false;
	}

	public int GetRequestStoreReviewCount()
	{
		return 0;
	}

	public void SetRequestStoreReviewCount()
	{
	}

	public bool IsRequestStoreReviewCount()
	{
		return false;
	}

	public bool IsSpecialMissionPremium(int specialMissionId)
	{
		return false;
	}

	public void AddSpecialMissionGroupDataList(List<SpecialMissionGroupData> specialMissionGroupDataList)
	{
	}

	public void AddSpecialMissionGroupData(SpecialMissionGroupData specialMissionGroupData)
	{
	}

	public SpecialMissionGroupData GetSpecialMissionGroup(int specialMissionId)
	{
		return null;
	}

	public void AddSpecialMissionRewardDataList(List<SpecialMissionRewardData> specialMissionDataList)
	{
	}

	public Dictionary<int, SpecialMissionRewardData> GetSpecialMissionRewardData(int specialMissionId, bool isPremium)
	{
		return null;
	}

	public SpecialMissionRewardData GetSpecialMissionRewardData(int specialMissionId, int criteriaValue, bool isPremium)
	{
		return null;
	}

	public bool IsNewSpecialMissionReward(int specialMissionId = 0)
	{
		return false;
	}

	public void DoneNewSpecialMission(int specialMissionId)
	{
	}

	public bool IsSpecialMissionComplete(int groupId)
	{
		return false;
	}

	public bool GetLastSpecialMissionGroup(int groupId, ref DesignSpecialMission.Data lastDesignSpecialMission)
	{
		return false;
	}

	public bool IsSpecialMissionComplete(int groupId, int stepGroup, int step)
	{
		return false;
	}

	public void SetCharacterMagicSetting(ref List<Character> characters)
	{
	}

	public int GetRandomSeed()
	{
		return 0;
	}

	public int GetRandomSeeds(RandomSeed.eType type)
	{
		return 0;
	}

	public void InitSystemLocale()
	{
	}

	public void DisconnectGuild()
	{
	}

	public void EnableGuildNotification(bool enabled, bool isUpdateServer = false)
	{
	}

	public void SaveBeforeBattleStat()
	{
	}

	public void ApplyBattleStat(bool isPopup = true)
	{
	}

	public void SetMyGuildName(string GuildName)
	{
	}

	public string GetMyGuildName()
	{
		return null;
	}

	public void PauseOfflineTime()
	{
	}

	public void UpdateOfflineTime()
	{
	}

	public void ChangeScene(int stageId, string sceneName, SceneDirector.LoadingType loadingType, bool skipSkillSelect = false)
	{
	}
}
