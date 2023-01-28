using UnityEngine;

public class PotentialLocationItem : MonoBehaviour
{
	public enum ItemState
	{
		Off = 0,
		On = 1,
		Lock = 2
	}

	public delegate void callbackEffect(PotentialLocationItem d);

	public delegate void LongTouchDelegate(PotentialLocationItem card);

	private callbackEffect _del;

	public int _idx;

	private Character _character;

	public bool _isLongTouch;

	private float _toolTipTime;

	protected float _pressTime;

	protected UIButton _btnOn;

	protected UIButton _btnLock;

	public LongTouchDelegate _longTouchCardCallback;

	private GameObject _effect1;

	private GameObject _effectSkip;

	private bool _isSkip;

	public void Init(Character character, int idx)
	{
	}

	private void Update()
	{
	}

	private bool LongTouch()
	{
		return false;
	}

	public void SetLongTouchCallback(LongTouchDelegate del = null)
	{
	}

	public void UpdatePoint()
	{
	}

	public void ChangeState(ItemState state)
	{
	}

	public void SetEffect(bool isSkip, float delay, callbackEffect del)
	{
	}

	public void ShowEffect()
	{
	}
}
