using System.Collections.Generic;
using UnityEngine;

public class BattleRespawn : MonoBehaviour
{
	private BattleData _battleData;

	private BattleRespawnManager _battleRespawnManager;

	private DesignStage.Data _designStage;

	private bool _isBoss;

	private long _createNum;

	private List<BattleObjectBase> _summonList;

	private float _summonWaitTime;

	private List<DesignCharacterGroup.Data> _summonWaitList;

	private int _respawnIndex;

	private float _respawnTime;

	private List<BattleObjectBase> _calcSummonList;

	private void Update()
	{
	}

	public void Init(BattleData battleData, int respawnIndex)
	{
	}

	public void InitBoss(BattleData battleData, int respawnIndex)
	{
	}

	private void UpdateRespawn()
	{
	}

	private void Respawn(bool immediate)
	{
	}

	private void Summon(DesignCharacterGroup.Data designCharacterGroup)
	{
	}

	private void BossSummon()
	{
	}

	public void GetSummonList(ref List<BattleObjectBase> sumList)
	{
	}

	public void Remove(BattleObjectHero hero)
	{
	}

	public void ResetRespawnTime()
	{
	}

	public void Counterattack(BattleObjectBase target)
	{
	}
}
