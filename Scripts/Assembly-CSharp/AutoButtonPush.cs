using UnityEngine;

public class AutoButtonPush : MonoBehaviour
{
	public enum DelegateState
	{
		Repeat = 0,
		Finish = 1,
		Max = 2
	}

	public delegate void AutoButtonPushDelegate(UIButton btn, DelegateState state);

	private const float DELAY = 0.5f;

	private const float REPEAT = 0.005f;

	private AutoButtonPushDelegate _delegate;

	private UIButton _btn;

	private float _delayTime;

	private float _repeatTime;

	private float _time;

	private bool _isRelease;

	private bool _isPressed;

	public static AutoButtonPush Add(GameObject target)
	{
		return null;
	}

	private void Update()
	{
	}

	private void ButtonPress(GameObject obj, bool state)
	{
	}

	private void SendCallBack(DelegateState state)
	{
	}

	public void Init(UIButton btn, AutoButtonPushDelegate autoButtonPushDelegate)
	{
	}

	public void ChangeRepeatTime(float time)
	{
	}

	public void Release()
	{
	}

	private void Repeat()
	{
	}

	public void Cancel()
	{
	}
}
