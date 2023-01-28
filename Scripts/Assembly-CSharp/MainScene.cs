using System;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : SceneBase
{
	public enum Notice
	{
		CallMissionProgress = 0,
		ShowInterstitial = 1,
		PopupSpecialEventList = 2,
		ShopNowOnly = 3,
		ReturnGuildBoss = 4,
		ReturnStage = 5,
		ChangeName = 6,
		RankingChange = 7,
		MissionQuickNotice = 8
	}

	public int _worldId;

	public int _stage;

	private Battle _battle;

	public List<Notice> _noticeList;

	public DateTime _enterTime;

	private float _lastUpdateInventoryTime;

	private float _lastChatInitTime;

	private int prevGCCount1;

	private int prevGCCount2;

	private int prevGCCount3;

	private bool _isFirstGC;

	private DateTime _firstGCTime;

	private float _prevGCCount;

	private long prevMaxMonoSize;

	private long maxMaxMonoSize;

	private long minMaxMonoSize;

	private long prevCurMonoSize;

	private long maxCurMonoSize;

	private long minCurMonoSize;

	private bool IsFirstScene => false;

	public override void InitScene()
	{
	}

	private void CheckMissionList()
	{
	}

	public override void EnterScene()
	{
	}

	private void InitBattle()
	{
	}

	private void PlayBGM()
	{
	}

	public Battle GetBattle()
	{
		return null;
	}

	private void CheckNotice()
	{
	}

	public static void MainNextNotice()
	{
	}

	public static void AddNotice(Notice notice)
	{
	}

	private void NextNotice()
	{
	}

	private void CallbackGetMyGuildInfo(WWWData data)
	{
	}

	private void CallBackRequestStoreReview1(GameObject obj, UIButton btn)
	{
	}

	private void CallBackRequestStoreReview2(GameObject obj, UIButton btn)
	{
	}

	public override void InitSceneStart()
	{
	}

	public override void InitSceneEnd()
	{
	}

	public override void EnterSceneStart()
	{
	}

	public override void EnterSceneEnd()
	{
	}

	public static void CheckStoreReview()
	{
	}

	public void CheckStoreReviewTeamLevel()
	{
	}

	public static void BattlePlay(BattleData.BattlePlay play)
	{
	}

	public static void InvokeUpdateInventory()
	{
	}

	private void UpdateInventory()
	{
	}

	public static void InvokeUpdateRefreshUser()
	{
	}

	private void RefreshUser()
	{
	}

	public static void InvokeUpdateNew()
	{
	}

	public void ShowFxGetCash()
	{
	}

	public bool ShowInterstitial()
	{
		return false;
	}

	private void AdsResultInterstitial(AdsIntegration.eState state)
	{
	}

	private void Update()
	{
	}

	public override void PauseScene()
	{
	}

	public override void ResumeScene()
	{
	}

	private void ReqOfflineReward()
	{
	}

	private void ReqRetentionPush()
	{
	}

	public static void ShowWorldRanking(int worldId)
	{
	}
}
