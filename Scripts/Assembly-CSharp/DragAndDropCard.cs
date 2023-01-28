using UnityEngine;

public class DragAndDropCard : MonoBehaviour
{
	public delegate void DragAndDropCardDelegate(BaseCard card, string dropObjName);

	private DragAndDropCardDelegate _dragAndDropCardCallback;

	public static GameObject _dragObj;

	private UIScrollView _scrollView;

	private UIButton _btn;

	private BaseCard _card;

	private bool _isPressed;

	private Vector3 _prevPrevPos;

	private string _dropObjName;

	public static DragAndDropCard Add(GameObject target)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void CheckDrag(Vector3 data)
	{
	}

	private void DragPosition(Vector3 data)
	{
	}

	public void TriggerEnter(Collider col)
	{
	}

	public void TriggerExit(Collider col)
	{
	}

	public void SetCallback(DragAndDropCardDelegate del)
	{
	}
}
