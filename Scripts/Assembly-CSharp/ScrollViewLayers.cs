using UnityEngine;

public class ScrollViewLayers : MonoBehaviour
{
	private Vector3 _size;

	private UIScrollView _scrollView;

	private UIWidget _target;

	private float _offset;

	public static ScrollViewLayers Get(GameObject obj)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Init(UIScrollView scrollView, UIWidget target, float offset)
	{
	}
}
