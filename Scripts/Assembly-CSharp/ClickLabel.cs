using UnityEngine;

public class ClickLabel : MonoBehaviour
{
	public delegate void ClickLabelDelegate(string url);

	private ClickLabelDelegate m_delegate;

	public void SetDelegate(ClickLabelDelegate _delegate)
	{
	}

	private void OnClick()
	{
	}
}
