using UnityEngine;

public class CompLongPressBtn : MonoBehaviour
{
	public delegate void LongTouchDelegate(UIButton btn);

	public LongTouchDelegate _longTouchCardCallback;

	private const float _eventTime = 0.6f;

	private float _pressTime;

	private UIButton _btn;

	private void Update()
	{
	}

	public void Init(LongTouchDelegate del = null)
	{
	}

	private bool LongTouch()
	{
		return false;
	}
}
