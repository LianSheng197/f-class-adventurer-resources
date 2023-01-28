using System.Collections.Generic;
using UnityEngine;

public class EffectPool
{
	private GameObject _effectPoolRoot;

	private int _skillEffectType;

	private Dictionary<int, List<GameObject>> _effectPool;

	public void Init(GameObject parent, int skillEffectType)
	{
	}

	public GameObject FindPool(DesignSkillEffect.Data designSkillEffect, GameObject parent)
	{
		return null;
	}

	public void DestroyEffect(GameObject effect)
	{
	}
}
