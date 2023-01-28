using UnityEngine;

[AddComponentMenu("Popup/PopupUniWebViewStart")]
public class PopupUniWebViewStart : PopupBase
{
	public enum Tab
	{
		Event = 0,
		News = 1,
		Game8 = 2,
		Guide = 3,
		Max = 4
	}

	public delegate void EndCall();

	public Tab _tab;

	private Transform _buttonRoot;

	private int _x;

	private int _y;

	private int _width;

	private int _height;

	private EndCall _delegate;

	private GameObject _indicator;

	public void InitPopup(Tab tab, EndCall del = null)
	{
	}

	public void ChangeTab(Tab tab)
	{
	}

	private void LoadURL(string url)
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

	public override void Message(UIButton btn)
	{
	}
}
