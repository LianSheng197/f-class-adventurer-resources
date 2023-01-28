using UnityEngine;

public class TextLink : MonoBehaviour
{
	public delegate void callBack(string url);

	private UILabel _label;

	public callBack _callback;

	private void Awake()
	{
	}

	private void OnClick()
	{
	}
}
