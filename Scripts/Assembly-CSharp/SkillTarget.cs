using System.Collections.Generic;
using UnityEngine;

public class SkillTarget : MonoBehaviour
{
	public class Target
	{
		public float _time;

		public BattleObjectBase _target;

		public List<BattleObjectBase> _rangeList;
	}

	public class SkillTargetData
	{
		public float _time;

		public DesignSkill.Data _designSkill;

		public int _baseSkillLevel;

		public int _contentsSkillLevel;

		public DesignSkillFunction.Data _designSkillFunction;

		public List<Target> _targetList;
	}

	private const float _poolTime = 3f;

	private List<SkillTargetData> _skillTargetPool;

	private List<Target> _targetPool;

	private BattleObjectHero _hero;

	private Character _character;

	private List<SkillTargetData> _targetGroupData;

	public List<int> _calcBaseSkillLevel;

	public List<int> _calcContentsSkillLevel;

	private List<BattleObjectBase> _searchList;

	public List<BattleObjectBase> _calc1;

	public List<BattleObjectBase> _calc2;

	private List<int> _attackGroundTypeCheck;

	public static SkillTarget Get(GameObject hero)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	private void UpdatePool()
	{
	}

	private SkillTargetData SkillTargetDataPool()
	{
		return null;
	}

	private Target TargetPool()
	{
		return null;
	}

	public void GetTarget(ref List<SkillTargetData> targetList, DesignSkill.Data designSkill, int baseSkillLevel, int contentsSkillLevel)
	{
	}

	private SkillTargetData FindTargetGroup(DesignSkillFunction.Data designSkillFunction)
	{
		return null;
	}

	private List<BattleObjectBase> SearchList(DesignSkillFunction.Data designSkillFunction)
	{
		return null;
	}

	private List<BattleObjectBase> DistanceList(List<BattleObjectBase> list, int skillId, DesignSkillFunction.Data designSkillFunction, int contentsSkillLevel)
	{
		return null;
	}

	private List<BattleObjectBase> TargetFilter(List<BattleObjectBase> list, DesignSkillFunction.Data designSkillFunction)
	{
		return null;
	}

	private List<BattleObjectBase> RemoverTargetFilter(List<BattleObjectBase> list, DesignSkillFunction.Data designSkillFunction)
	{
		return null;
	}

	public void PrioritySort(List<BattleObjectBase> list, DesignSkillFunction.Data designSkillFunction)
	{
	}

	private void TargetRange(SkillTargetData data)
	{
	}
}
