using Spine;
using Spine.Unity;
using UnityEngine;

public class CharacterResSpine : CharacterResBase
{
	private Material _material;

	private MeshRenderer _meshRenderer;

	private SkeletonAnimation _skeletonAnimation;

	private Bounds _meshBounds;

	private UITexture _shadow;

	private Material _tombMaterial;

	private MeshRenderer _tombMeshRenderer;

	private SkeletonAnimation _tombSkeletonAnimation;

	public override void Init(GameObject parent, bool customMaterial, bool isUser, DesignCharacter.Data designCharacter, DesignActor.Data designActor, float scale, UIWidget renderTarget, int renderQValue)
	{
	}

	public override void UpdateRes()
	{
	}

	public override void Pool()
	{
	}

	public override void SetSortingOrder(int order)
	{
	}

	public override void InitCollider()
	{
	}

	public override void ShowShadow(bool isShow)
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

	private float GetAttackTimeScale(TrackEntry track, float baseTimeScale)
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

	public void CompleteAnimation(TrackEntry trackEntry)
	{
	}

	public void CompleteWinAnimation(TrackEntry trackEntry)
	{
	}

	public void CompleteAnimationAutoDestroy(TrackEntry trackEntry)
	{
	}

	private void ResetSpine()
	{
	}

	private void OnDestroy()
	{
	}
}
