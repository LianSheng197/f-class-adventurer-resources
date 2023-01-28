using UnityEngine;

public class PinchZoomScrollItem : MonoBehaviour
{
	public Transform _target;

	private float _scale_factor;

	public float _maxScale;

	public float _minScale;

	private Vector2 _prevDist;

	private Vector2 _curDist;

	private bool _isScaling;

	private void Update()
	{
	}

	private void CheckMultiTouch()
	{
	}

	private void UpdateScale(Vector3 scale)
	{
	}

	public bool IsScaling()
	{
		return false;
	}
}
