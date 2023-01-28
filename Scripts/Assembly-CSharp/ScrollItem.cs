using UnityEngine;

[ExecuteInEditMode]
public class ScrollItem : MonoBehaviour
{
	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public Transform target;

	public UIPanel panelRegion;

	public Vector3 scrollMomentum;

	public bool restrictWithinPanel;

	public UIRect contentRect;

	public DragEffect dragEffect;

	public float momentumAmount;

	private PinchZoomScrollItem _pinchZoom;

	[SerializeField]
	protected Vector3 scale;

	[SerializeField]
	[HideInInspector]
	private float scrollWheelFactor;

	private Plane mPlane;

	private Vector3 mTargetPos;

	private Vector3 mLastPos;

	private Vector3 mMomentum;

	private Vector3 mScroll;

	private Bounds mBounds;

	private int mTouchID;

	public bool mStarted;

	public bool mPressed;

	public Vector3 dragMovement
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void FindPanel()
	{
	}

	private void UpdateBounds()
	{
	}

	public void OnPress(bool pressed)
	{
	}

	public void OnDrag(Vector2 delta)
	{
	}

	private void Move(Vector3 worldDelta)
	{
	}

	private void LateUpdate()
	{
	}

	public void CancelMovement()
	{
	}

	public void CancelSpring()
	{
	}

	public void OnScroll(float delta)
	{
	}

	public virtual void MoveRelative(Vector3 relative)
	{
	}

	public Bounds GetBounds()
	{
		return default(Bounds);
	}
}
