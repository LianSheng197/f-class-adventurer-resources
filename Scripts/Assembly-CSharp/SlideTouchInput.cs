using UnityEngine;

public class SlideTouchInput : MonoBehaviour
{
	public enum Direction
	{
		Left = 0,
		Right = 1
	}

	public delegate void SlideTouchInputDelegate(GameObject target, Direction direction);

	private SlideTouchInputDelegate _callback;

	private bool _isTouch;

	private Vector3 _touchBegan;

	private Vector3 _touchMove;

	private float _rotateDeltaSensibilityWidth;

	public static SlideTouchInput Add(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void UpdateInput()
	{
	}

	private void Move(bool isLeft)
	{
	}

	public void SetDelegate(SlideTouchInputDelegate del)
	{
	}
}
