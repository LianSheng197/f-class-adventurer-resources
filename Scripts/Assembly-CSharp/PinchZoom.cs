using UnityEngine;

public class PinchZoom : MonoBehaviour
{
	public Transform _target;

	private UIScrollView _scrollView;

	public float _mouseFactor;

	public float _touchFactor;

	public float _curScale;

	public float _maxScale;

	public float _minScale;

	private Vector2 _prevDist;

	private Vector2 _curDist;

	private bool _isScaling;

	private void Update()
	{
	}

	public void InitPinchZoom(float curScale, float minScale, float maxScale, UIScrollView scrollView = null)
	{
	}

	public void ChangeScale(float minScale, float maxScale)
	{
	}

	public void Changefactor(float factor)
	{
	}

	private void CheckMultiTouch()
	{
	}

	private void UpdateScale(float delta)
	{
	}

	public bool IsScaling()
	{
		return false;
	}
}
