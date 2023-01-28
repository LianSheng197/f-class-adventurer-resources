using UnityEngine;

public class BaseCard : MonoBehaviour
{
	public delegate void LongTouchDelegate(BaseCard card);

	public LongTouchDelegate _longTouchCardCallback;

	public BaseObject _data;

	protected GameObject _off;

	protected GameObject _on;

	public bool _isLongTouch;

	private float _toolTipTime;

	protected float _pressTime;

	protected UIButton _btn;

	protected UIDragScrollView _dragScrollView;

	private void Update()
	{
	}

	public bool GetState()
	{
		return false;
	}

	public void BaseTouch(UIButton btn)
	{
	}

	public void InitBaseTouch()
	{
	}

	public virtual void SetCard(BaseObject data)
	{
	}

	protected virtual void InitData()
	{
	}

	public virtual void UpdateInfo()
	{
	}

	protected virtual void Touch()
	{
	}

	protected virtual bool LongTouch()
	{
		return false;
	}

	public virtual void Choice(bool isShow)
	{
	}

	public UISprite GetSpineTarget()
	{
		return null;
	}

	public void SetLongTouch(LongTouchDelegate del = null)
	{
	}

	private void OnDestroy()
	{
	}
}
