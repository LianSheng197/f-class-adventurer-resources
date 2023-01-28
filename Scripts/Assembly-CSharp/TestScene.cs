using Spine;
using UnityEngine;

public class TestScene : SceneBase
{
	private bool _isDataLoad;

	private UISprite _target;

	private GameObject _effectTestRoot;

	private GameObject _character;

	private int _characterId;

	private bool _characterFlip;

	private BoxCollider _collider;

	private int _targetCharacterId;

	private GameObject _damageTargetCharacter;

	private BoxCollider _colliderTarget;

	private Material _material;

	private Material _targetMaterial;

	private GameObject _arrow;

	private UIInput _hitDamageX;

	private UIInput _hitDamageY;

	private UIInput _arrowX;

	private UIInput _arrowY;

	private bool _showDrawLine;

	private UISprite _attackDistance;

	private UISprite _box;

	private bool _isSlow;

	private UILabel _slowTime;

	private float _deltaTime;

	private void Update()
	{
	}

	public override void InitScene()
	{
	}

	public override void EnterScene()
	{
	}

	private Character MakeCharacter()
	{
		return null;
	}

	private void Message(UIButton btn)
	{
	}

	private void InitEffectTest()
	{
	}

	private void ChangeCharacter(int designId)
	{
	}

	private void ChangeDamageTarget(int designId)
	{
	}

	private void ChangeAnimation(string name)
	{
	}

	public void CompleteAnimation(TrackEntry trackEntry)
	{
	}

	private void OnRenderCallBack(Material mat)
	{
	}

	private void AddEffect(int id)
	{
	}

	private void AddTargetEffect(int id)
	{
	}

	private void AddArrow(int id)
	{
	}

	public void Hit(GameObject obj, int userData1, int userData2)
	{
	}

	private void ArrowDelete()
	{
	}

	private void Damage()
	{
	}

	private void ShowDrawLine()
	{
	}

	private void UpdateAttackDistance()
	{
	}

	private void ShowAttackSpeed()
	{
	}

	public override bool AndroidBackButton()
	{
		return false;
	}

	public override void InitSceneStart()
	{
	}

	public override void InitSceneEnd()
	{
	}

	public override void EnterSceneStart()
	{
	}

	public override void EnterSceneEnd()
	{
	}
}
