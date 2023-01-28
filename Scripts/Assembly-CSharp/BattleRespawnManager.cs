using System.Collections.Generic;
using UnityEngine;

public class BattleRespawnManager : MonoBehaviour
{
	private BattleData _battleData;

	private Dictionary<int, BattleRespawn> _battleRespawnList;

	private Dictionary<int, Character> _characterPool;

	private List<BattleObjectBase> _enemyList;

	public void Init(BattleData battleData)
	{
	}

	public void RespawnReset()
	{
	}

	public Character GetCharacter(DesignCharacterGroup.Data designCharacterGroup, DesignStage.Data designStage)
	{
		return null;
	}

	public BattleRespawn FindRespawn(int respawnIndex)
	{
		return null;
	}

	public List<BattleObjectBase> GetEnemyList()
	{
		return null;
	}

	public void EnemyCounterattack(BattleObjectBase target, int respawnIndex)
	{
	}
}
