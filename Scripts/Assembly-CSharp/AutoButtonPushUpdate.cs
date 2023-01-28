using UnityEngine;

public class AutoButtonPushUpdate : MonoBehaviour
{
	public delegate void AutoButtonPushDelegate(UIButton btn);

	private const float DELAY = 0.5f;

	private const float REPEAT = 0.2f;

	private AutoButtonPushDelegate _delegate;

	private UIButton _btn;

	private float _delayTime;

	private float _repeatTime;

	private float _time;

	private bool _isPressed;

	private void Update()
	{
	}

	public void Init(UIButton btn, AutoButtonPushDelegate autoButtonPushDelegate)
	{
	}

	public void ChangeRepeatTime(float time)
	{
	}

	private void Repeat()
	{
	}
}
