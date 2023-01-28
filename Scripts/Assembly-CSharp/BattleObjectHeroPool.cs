using System.Collections.Generic;
using UnityEngine;

public class BattleObjectHeroPool
{
	private GameObject _prefabHero;

	private GameObject _summonRoot;

	private Dictionary<int, List<BattleObjectHero>> _heroPool;

	public void Init(GameObject summonRoot)
	{
	}

	public BattleObjectHero FindPool(int designId)
	{
		return null;
	}
}
