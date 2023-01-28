using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleRewardManager : MonoBehaviour
{
	public class RewardData
	{
		public bool _isReady;

		public bool _isReq;

		public bool _isAck;

		public int _rewardIndex;

		public int _characterId;

		public int _randomSeed;

		public List<ItemReward> _rewards;
	}

	public class AbusingData
	{
		public const float CHECK_TIME = 600f;

		public DateTime _updateTime;

		public int _monsterKillCount;

		public int _ackBattleRewardCount;

		public void Clear()
		{
		}
	}

	private const float REWARD_UPDATE_TIME = 6f;

	private const float REWARD_UPDATE_SLEEPMODE_TIME = 60f;

	private const int REWARD_INDEX_COUNT = 10000000;

	private static BattleRewardManager _Instance;

	private BattleData _battleData;

	private float _updateRequestTime;

	private int _rewardIndex;

	private List<RewardData> _poolData;

	private Dictionary<int, RewardData> _dataList;

	private Dictionary<int, List<GameObject>> _dropObjList;

	private List<GameObject> _dropObjPool;

	private List<int> _deleteList;

	private List<ItemReward> _randomRewards;

	private AbusingData _abusingData;

	private string _moveScene;

	private SceneDirector.LoadingType _moveLoadingType;

	public static long _accumRewardCount;

	public static BattleRewardManager Instance => null;

	private void Update()
	{
	}

	public void Init(BattleData battleData)
	{
	}

	private RewardData FindRewardData()
	{
		return null;
	}

	public void ClearReward()
	{
	}

	public void AddReward(BattleObjectBase user, BattleObjectBase kill)
	{
	}

	public void BattleRewardAck(List<BattleRewardAckData> ackDataList)
	{
	}

	public void BattleRewardReqReset(List<BattleRewardReqData> reqDataList)
	{
	}

	public bool StageMoveRequest(string scene, SceneDirector.LoadingType loadingType)
	{
		return false;
	}

	public void RewardRequest()
	{
	}

	private void SetRequestTime()
	{
	}

	private bool UpdateRequest()
	{
		return false;
	}

	private void UpdateReward()
	{
	}

	public GameObject FindPool()
	{
		return null;
	}

	public void AddDropItem(int rewardIndex, List<ItemReward> rewards, Vector3 pos)
	{
	}

	private void AckDropItem(int rewardIndex)
	{
	}

	private void EndTarget(GameObject obj, int userData1, int userData2)
	{
	}

	private void UpdateAbusing()
	{
	}
}
