using Spine;
using Spine.Unity;
using UnityEngine;

public class ObjectSpine : MonoBehaviour
{
	private bool _init;

	public string _dataPath;

	public string _dataName;

	public UIWidget _target;

	private Material _material;

	private MeshRenderer _meshRenderer;

	private SkeletonAnimation _skeletonAnimation;

	private Bounds _meshBounds;

	private UISprite _shadow;

	private int _targetDepth;

	private bool _flipX;

	private bool _flipY;

	public int _renderQValue;

	private float _orgScale;

	private void InitData()
	{
	}

	private void Update()
	{
	}

	public static ObjectSpine Add(GameObject parent, Character character, UIWidget target = null, string ani = "victory")
	{
		return null;
	}

	public static ObjectSpine Add(GameObject parent, string folder, string data, string skin, float scale, DesignCharacter.Data.GroundType type, UIWidget target = null, string ani = "victory")
	{
		return null;
	}

	public static ObjectSpine AddTower(GameObject parent, string folder, string data, UIWidget target = null)
	{
		return null;
	}

	private void Init(string path, string name, float scale, string skinName, string initAni, UIWidget target = null)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnRenderCallBack(Material mat)
	{
	}

	public void BuildAnimationComplete(Spine.AnimationState.TrackEntryDelegate completeDelegate)
	{
	}

	public void BuildAnimationEvent(Spine.AnimationState.TrackEntryEventDelegate eventDelegate)
	{
	}

	public void ChangeShadowRenderTarget()
	{
	}

	public void SetRenderQValue(int value)
	{
	}

	public void SetFlipX(bool flip)
	{
	}

	public void SetFlipY(bool flip)
	{
	}

	private void Reset()
	{
	}

	private void UpdateMeshBounds()
	{
	}

	public Bounds GetMeshBounds()
	{
		return default(Bounds);
	}

	public void ChangeAnimation(string ani)
	{
	}

	public void SetNpc(string path, string name, string skin, string animation, UIWidget target = null)
	{
	}

	public void SetDeath(bool isPlayer)
	{
	}

	public void HideShadow()
	{
	}

	public void AddScale(float scale)
	{
	}

	public void SetScaleSquare(float pixelSize = 96f)
	{
	}

	public void SetScale(float pixelSizeX = 96f, float pixelSizeY = 96f, float correctionValue = 1f)
	{
	}

	public void SetScaleX(float size = 96f, bool overCheck = true)
	{
	}

	public void SetScaleY(float size = 96f, bool overCheck = true)
	{
	}

	public void CompleteAnimation(TrackEntry trackEntry)
	{
	}

	public void CompleteAnimationAutoDestroy(TrackEntry trackEntry)
	{
	}

	public float GetAnimationTime(string ani)
	{
		return 0f;
	}
}
