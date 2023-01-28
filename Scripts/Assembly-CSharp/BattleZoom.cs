using UnityEngine;

public class BattleZoom : MonoBehaviour
{
	private float _minScale;

	private float _maxScale;

	private bool _isLock;

	private GameObject _background;

	private float _backgroundSize;

	private float _pivot;

	private float _pivotHalf;

	private float _lastUpdateScale;

	private UIScrollView _scrollView;

	private PinchZoom _pinchZoom;

	private void Update()
	{
	}

	public void Init(float backgroundSize, GameObject background, GameObject foreground, float pivot, UIScrollView scrollView)
	{
	}

	private void UpdateZoom()
	{
	}

	public void SetZoomEnable(bool enable)
	{
	}
}
