using UnityEngine;

public class TweenJump : MonoBehaviour
{
	public delegate void TweenJumpBounceDelegate(GameObject obj, int bounce, int userData1, int userData2);

	public delegate void TweenJumpEndDelegate(GameObject obj, int userData1, int userData2);

	private TweenJumpBounceDelegate _bounceDelegate;

	private TweenJumpEndDelegate _endDelegate;

	private GameObject _target;

	private bool _isWidth;

	private float _delay;

	private float _duration;

	private float _height;

	private int _jumps;

	private int _bounce;

	private Vector3 _previousPos;

	private Vector3 _startPosition;

	private Vector3 _endPos;

	private bool _isWorldPos;

	private float _elapsed;

	private bool _isAcceleration;

	private float _acceleration;

	private float _accelerationValue;

	private bool _isJump;

	public int _userData1;

	public int _userData2;

	public static TweenJump Get(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetBounce()
	{
	}

	public void SetJump(GameObject target, float duration, Vector3 startPos, Vector3 endPos, float height, int jumps, float delay, int bounce = 0, bool isWorldPos = false)
	{
	}

	public void SetEndPos(Vector3 endPos)
	{
	}

	public Vector3 GetEndPos()
	{
		return default(Vector3);
	}

	public void SetWidth()
	{
	}

	public void StopJump()
	{
	}

	public bool IsDone()
	{
		return false;
	}

	public void SetAcceleration(float accelerationValue)
	{
	}

	public void SetBounceDelegate(TweenJumpBounceDelegate calldelegate)
	{
	}

	public void SetEndDelegate(TweenJumpEndDelegate calldelegate)
	{
	}

	public static TweenJump Begin(GameObject target, float duration, Vector3 startPos, Vector3 endPos, float height, int jumps, float delay, int bounce = 0, bool isWorldPos = false)
	{
		return null;
	}

	public static void Remove(GameObject target)
	{
	}
}
