using System.Collections.Generic;
using UnityEngine;

public class BuffCondition : MonoBehaviour
{
	public class BuffDotData
	{
		public float _skillOffset;

		public double _attackDefenceIgnore;

		public float _criticalDefence;

		public double _beltAttack;

		public double _ringAttack;

		public double _resist;

		public double _defence;

		public float _criticalPercentage;

		public float _criticalValue;

		public float _criticalPercentage2;

		public float _criticalValue2;

		public float _criticalPercentage3;

		public float _criticalValue3;

		public double _sumDamageUp;

		public double _multiplyDamageUp;

		public double _multiplyMultiplyDamageUp;

		public double _sumDamageDown;

		public double _multiplyDamageDown;

		public double _multiplyMultiplyDamageDown;

		public float _randomRange;

		public double _skillDamage;

		public double _skillAttributeDamage;
	}

	public class BuffData
	{
		public int _skillId;

		public DesignSkillFunction.Data _designSkillFunction;

		public DesignBuff.Data _designBuff;

		public int _baseSkillLevel;

		public int _contentsSkillLevel;

		public int _attribute;

		public float _curTime;

		public float _maxTime;

		public double _value;

		public float _count;

		public bool _isEffect;

		public BuffDotData _buffDotData;

		public bool IsAscending()
		{
			return false;
		}
	}

	private BattleObjectBase _battleObjectBase;

	private List<BuffData> _buffList;

	private List<BuffData> _removeList;

	private List<BuffData> _calcList;

	private List<BuffData> _calcDotList;

	private List<int> _actionEffectList;

	private List<int> _removeEffectList;

	public static BuffCondition Get(GameObject hero)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init()
	{
	}

	public void AddBuff(BuffData data)
	{
	}

	public void RemoveBuff(DesignSkillFunction.Data designSkillFunction)
	{
	}

	public void RemoveBuff(List<BuffData> removeList)
	{
	}

	public bool IsBuff(DesignSkillFunction.Data.FunctionType functionType)
	{
		return false;
	}

	public void GetBuffData(DesignSkillFunction.Data.FunctionType functionType, ref List<BuffData> list)
	{
	}

	public double GetBuffValue(DesignSkillFunction.Data.FunctionType functionType, int attribute)
	{
		return 0.0;
	}

	public int GetBuffCount(DesignBuff.Data.BuffType buffType)
	{
		return 0;
	}

	public int GetBuffCount(List<int> buffSkillIds)
	{
		return 0;
	}

	private void ActionEffect(List<int> actionEffectList)
	{
	}

	private void UpdateBuff()
	{
	}
}
