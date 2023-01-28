using System.Collections.Generic;
using UnityEngine;

public class BattleThrowManager : MonoBehaviour
{
	public class ArrowData
	{
		public bool _isUse;

		public DesignSkill.Data _designSkill;

		public int _baseSkillLevel;

		public int _contentsSkillLevel;

		public DesignSkillFunction.Data _designSkillFunction;

		public BattleObjectBase _target;

		public List<BattleObjectBase> _rangeList;
	}

	private GameObject _prefabArrow;

	private List<ArrowData> _arrowDataPool;

	private Dictionary<int, List<BattleObjectArrow>> _arrowPool;

	public void Init()
	{
	}

	public ArrowData ArrowDataPool()
	{
		return null;
	}

	private BattleObjectArrow FindArrowPool(int arrowEffectId)
	{
		return null;
	}

	public void FireArrow(BattleObjectHero attacker, ArrowData arrowData)
	{
	}
}
