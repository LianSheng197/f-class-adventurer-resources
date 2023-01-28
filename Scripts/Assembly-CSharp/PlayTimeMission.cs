using System;
using UnityEngine;

public class PlayTimeMission : MonoBehaviour
{
	public float _playStartTime;

	public DateTime _pauseTime;

	public DateTime _lastUpdateBattleStatTime;

	public DateTime _lastUpdateDailyMissionTime;

	public float _lastUpdateTime;

	private static PlayTimeMission _instance;

	public DateTime _updateConnectTime;

	private float _updateRankingRewardTime;

	public DateTime _lastUpdateRankingRewardTime;

	private float _updateBossRankingRewardTime;

	public DateTime _lastUpdateBossRankingRewardTime;

	private int _updateSchedule3Counter;

	private const int UPDATE_SCHEDULE3_MINUTE = 30;

	private int _retryCountByMission;

	private const int _maxRetryCountByMission = 10;

	private float _lastRetryFixedTime;

	public CanReceivePrevBossRankingRewardAck canReceivePrevBossRankingReward;

	public static PlayTimeMission Instance => null;

	public void Init()
	{
	}

	public static void Stop()
	{
	}

	private void Start()
	{
	}

	public void UpdateMission()
	{
	}

	private void UpdatePlayTime(DateTime now)
	{
	}

	public void UpdateBattleStat(DateTime now, bool isForce = false)
	{
	}

	public void UpdateConnectTime(bool isUpdateSchedule3 = false)
	{
	}

	public void UpdateDailyMission(DateTime now, bool isForce = false)
	{
	}

	public void UpdateGuildRankingReward(DateTime now, bool isForce = false)
	{
	}

	private void CallbackCanReceivePrevBossRankingReward(WWWData data)
	{
	}

	public void UpdateBossRankingReward(DateTime now, bool isForce = false)
	{
	}
}
