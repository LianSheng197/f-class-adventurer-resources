using System.Collections.Generic;
using UnityEngine;

public class BattleObjectEffect : MonoBehaviour
{
	private BattleObjectBase _battleObject;

	private int _skillEffectType;

	private EffectPool _effectPool;

	private GameObject _effectRoot;

	private GameObject _buffEffectRoot;

	private List<GameObject> _destroyEffectList;

	public static BattleObjectEffect Get(BattleObjectBase target)
	{
		return null;
	}

	public static GameObject Add(BattleObjectBase target, DesignSkillEffect.Data designSkillEffect, Vector3 offset)
	{
		return null;
	}

	public static GameObject AddBuff(BattleObjectBase target, DesignSkillEffect.Data designSkillEffect, Vector3 offset, string name)
	{
		return null;
	}

	public static void RemoveBuffEffect(BattleObjectBase target, string name)
	{
	}

	public static void RemoveAllBuffEffect(BattleObjectBase target)
	{
	}

	public static void RemoveAllEffect(BattleObjectBase target)
	{
	}

	public static void RemoveAnimation(GameObject effect)
	{
	}

	public static void RemoveTimeBomb(GameObject effect)
	{
	}

	public static void SetFlip(BattleObjectBase target, bool isFlipX)
	{
	}

	public void SetBattleObject(BattleObjectBase obj)
	{
	}

	public GameObject AddEffect(DesignSkillEffect.Data designSkillEffect, Vector3 offset)
	{
		return null;
	}

	private void EndTimeBomb(GameObject effect)
	{
	}

	public void DestroyEffect(GameObject effect)
	{
	}

	public void RemoveAllEffect()
	{
	}

	public void RemoveAllBuffEffect()
	{
	}

	public GameObject FindBuff(string name)
	{
		return null;
	}

	public void Flip(bool isFlipX)
	{
	}
}
