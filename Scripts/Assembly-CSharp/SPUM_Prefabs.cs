using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SPUM_Prefabs : MonoBehaviour
{
	public float _version;

	public SPUM_SpriteList _spriteOBj;

	public bool EditChk;

	public string _code;

	public Animator _anim;

	public bool _horse;

	public string _horseString;

	public UnityEvent UnitTypeChanged;

	private AnimationClip[] _animationClips;

	private Dictionary<string, int> _nameToHashPair;

	public bool isRideHorse
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AnimationClip[] AnimationClips => null;

	private void InitAnimPair()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PlayAnimation(string name)
	{
	}
}
