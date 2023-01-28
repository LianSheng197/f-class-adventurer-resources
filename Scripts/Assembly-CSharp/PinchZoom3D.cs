using UnityEngine;

public class PinchZoom3D : MonoBehaviour
{
	private Camera _camera;

	public float _fieldOfView;

	private UIScrollView _scrollView;

	public float _mouseFactor;

	public float _touchFactor;

	public float _minValue;

	public float _maxValue;

	private Vector2 _prevDist;

	private Vector2 _curDist;

	private bool _isScaling;

	private void Update()
	{
	}

	public void Init(Camera camera, UIScrollView scrollView = null)
	{
	}

	public void ChangeValue(float minValue, float maxValue)
	{
	}

	public void Changefactor(float factor)
	{
	}

	private void CheckMultiTouch()
	{
	}

	public void UpdateView(float delta)
	{
	}

	public bool IsScaling()
	{
		return false;
	}
}
