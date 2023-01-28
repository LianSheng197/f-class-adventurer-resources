using UnityEngine;

public class CharacterResBase : MonoBehaviour
{
	protected GameObject _parent;

	protected bool _firstUpdateRes;

	protected bool _isCustomMaterial;

	protected bool _isUser;

	protected DesignCharacter.Data _designCharacter;

	protected DesignActor.Data _designActor;

	protected float _scale;

	protected int _sortingOrder;

	protected int _renderQValue;

	protected UIWidget _renderTarget;

	protected BoxCollider _collider;

	protected float _attackSpeed;

	protected float _attackDuration;

	public static CharacterResBase Add(GameObject parent, bool customMaterial, bool isUser, DesignCharacter.Data designCharacter, DesignActor.Data designActor, float scale, UIWidget renderTarget, int renderQValue)
	{
		return null;
	}

	public virtual void Init(GameObject parent, bool customMaterial, bool isUser, DesignCharacter.Data designCharacter, DesignActor.Data designActor, float scale, UIWidget renderTarget, int renderQValue)
	{
	}

	public virtual void UpdateRes()
	{
	}

	public virtual void Pool()
	{
	}

	public virtual void SetSortingOrder(int order)
	{
	}

	public virtual void InitCollider()
	{
	}

	public virtual void ShowShadow(bool isShow)
	{
	}

	public virtual void UpdateRenderCallBack(Material mat)
	{
	}

	public virtual bool GetFlipX()
	{
		return false;
	}

	public virtual void SetFlipX(bool flip)
	{
	}

	public virtual void StopAnimation()
	{
	}

	public virtual float GetAnimationSpeed()
	{
		return 0f;
	}

	public virtual void SetAttackSpeed(float attackSpeed)
	{
	}

	public virtual string GetCurrentAnimation()
	{
		return null;
	}

	public virtual void ChangeAnimation(string animation)
	{
	}

	public virtual void ChangeColor(Color color, float time)
	{
	}

	public virtual void ResetColor()
	{
	}

	public virtual void SetWin()
	{
	}

	public virtual void Death()
	{
	}

	public virtual void ObjectDestroy()
	{
	}

	public virtual void SetColliderSize(float width, float height)
	{
	}

	public virtual void SetSkillSummon()
	{
	}

	public BoxCollider GetCollider()
	{
		return null;
	}

	public bool IsLoopAnimation(string animation)
	{
		return false;
	}

	public void SetRenderQValue(int value)
	{
	}

	public int GetRenderQValue()
	{
		return 0;
	}

	private void OnRenderCallBack(Material mat)
	{
	}

	public void SetPressEvent(UIEventListener.VoidDelegate del)
	{
	}

	public float GetAttackDuration()
	{
		return 0f;
	}

	public void ChangeWeapon(int itemId)
	{
	}
}
