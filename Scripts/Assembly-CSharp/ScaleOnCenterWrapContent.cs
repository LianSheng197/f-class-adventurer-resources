using System.Collections.Generic;
using UnityEngine;

public class ScaleOnCenterWrapContent : MonoBehaviour
{
	public Vector3 _scaleIncreaseBy;

	public int _childsInvolved;

	public float _fixedSize;

	public string _focusObject;

	private bool _isUpdate;

	private float _maxOffset;

	private List<Transform> _items;

	private float _offsetSize;

	private float _offsetPos;

	private UIScrollView _scrollView;

	private bool _scrollViewIsHorizontal;

	private bool _isCenterChild;

	public static void UpdateScaleOnCenter(GameObject target)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void UpdateList()
	{
	}
}
