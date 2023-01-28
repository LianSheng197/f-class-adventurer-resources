using UnityEngine;

public class NetSimulator : MonoBehaviour
{
	public string _IntentionalDelayMS;

	public string _lastClassName;

	public long _lastElpaseMS;

	private GUIStyle _text;

	private Rect _textDelayRect;

	private Rect _textElapseRect;

	private GUIStyle _textElapseStyle;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	public void SetElapseValue(string className, long ms)
	{
	}

	public long GetDelayValue()
	{
		return 0L;
	}

	public double GetDelaySeconds()
	{
		return 0.0;
	}
}
