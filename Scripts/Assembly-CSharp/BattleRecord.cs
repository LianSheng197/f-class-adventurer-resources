using System.Collections.Generic;
using UnityEngine;

public class BattleRecord : MonoBehaviour
{
	private GameObject _rewardList;

	private GameObject _rewardRoot;

	private GameObject _damageRoot;

	private GameObject _prefabReward;

	private UIScrollView _rewardScrollView;

	private UIGrid _rewardGrid;

	private UILabel _rewardTime;

	private UILabel _KillLabel;

	private Dictionary<int, GameObject> _rewardsPool;

	private GameObject _prefabDamage;

	private UIScrollView _damageScrollView;

	private UIGrid _damageGrid;

	private Dictionary<int, GameObject> _damagesPool;

	private Dictionary<int, UISlider> _damagesSliderPool;

	private void Update()
	{
	}

	public void Init()
	{
	}

	public void UpdateRewardList()
	{
	}

	public void UpdateKillRecord()
	{
	}

	public void UpdateDamageList()
	{
	}

	private void ShowRecord(bool isShow)
	{
	}

	private void ChangeState(BattleRecordManager.State state)
	{
	}

	private void Message(UIButton btn)
	{
	}
}
