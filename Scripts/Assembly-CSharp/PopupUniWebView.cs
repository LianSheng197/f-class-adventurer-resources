using UnityEngine;

[AddComponentMenu("Popup/PopupUniWebView")]
public class PopupUniWebView : PopupBase
{
	public delegate void EndCall();

	private int _x;

	private int _y;

	private int _width;

	private int _height;

	private EndCall _delegate;

	private GameObject _indicator;

	public bool isClose;

	public void InitPopup(string url, EndCall del = null)
	{
	}

	public void LoadComplete()
	{
	}

	public void CloseFromWebView(bool isError, string errorMsg)
	{
	}

	public void Close()
	{
	}

	public override void PopupCloseCall()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
