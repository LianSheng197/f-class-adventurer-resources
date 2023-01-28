using System.Collections.Generic;
using Spine;
using Spine.Unity;
using UnityEngine;

public class CharacterResSprite : CharacterResBase
{
	private bool _isSpineDeath;

	private GameObject _root;

	private Transform _baseScale;

	private GameObject _prefabs;

	private Animator _animator;

	private AnimationClip[] _animationClips;

	private Dictionary<string, int> _nameToHashPair;

	private string _animationState;

	private Dictionary<string, AnimationClip> _dicAnimation;

	private List<SpriteRenderer> _partsSpriteRenderer;

	private Dictionary<SpriteRenderer, Color> _partsOrgColor;

	private Material _tombMaterial;

	private MeshRenderer _tombMeshRenderer;

	private SkeletonAnimation _tombSkeletonAnimation;

	private AnimationClip[] AnimationClips => null;

	private void Update()
	{
	}

	public override void Init(GameObject parent, bool customMaterial, bool isUser, DesignCharacter.Data designCharacter, DesignActor.Data designActor, float scale, UIWidget renderTarget, int renderQValue)
	{
	}

	public void SetSpriteMaskInteraction(SpriteMaskInteraction maskInteraction)
	{
	}

	public override void UpdateRes()
	{
	}

	public override void Pool()
	{
	}

	public override void InitCollider()
	{
	}

	public override void SetColliderSize(float width, float height)
	{
	}

	public override void UpdateRenderCallBack(Material mat)
	{
	}

	public override bool GetFlipX()
	{
		return false;
	}

	public override void SetFlipX(bool flip)
	{
	}

	private void InitAnimPair()
	{
	}

	public override float GetAnimationSpeed()
	{
		return 0f;
	}

	public override void StopAnimation()
	{
	}

	public override string GetCurrentAnimation()
	{
		return null;
	}

	public override void ChangeAnimation(string animation)
	{
	}

	private float GetAttackTimeScale(AnimationClip clip, float baseTimeScale)
	{
		return 0f;
	}

	public override void ChangeColor(Color color, float time)
	{
	}

	public override void ResetColor()
	{
	}

	public override void SetWin()
	{
	}

	public override void Death()
	{
	}

	public override void ObjectDestroy()
	{
	}

	public override void SetSkillSummon()
	{
	}

	private void InitPartsSpriteRenderer()
	{
	}

	public void CompleteAnimationAutoDestroy(TrackEntry trackEntry)
	{
	}

	private void ResetSpine()
	{
	}

	private void CheckAnimationEnd()
	{
	}

	private void OnDestroy()
	{
	}
}
