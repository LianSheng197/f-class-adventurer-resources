using UnityEngine;

public class LetterBox : MonoBehaviour
{
	private float _boxHeight;

	private bool _enableHorizontal;

	private bool _enableVertical;

	private bool _isLetterBox;

	private bool _isHorizontal;

	private bool _isVertical;

	private float _uiAspect;

	private Transform _top;

	private Transform _bottom;

	private Transform _left;

	private Transform _right;

	public static bool IsLandscape()
	{
		return false;
	}

	private void Awake()
	{
	}

	public void InitLetterBox()
	{
	}

	public void UpdateLetterBox()
	{
	}

	private bool CheckLetterBox()
	{
		return false;
	}

	public float GetUIAspect()
	{
		return 0f;
	}

	public int GetLetterBoxSize()
	{
		return 0;
	}

	public int GetLetterBoxSizeDevicePixel()
	{
		return 0;
	}

	public float GetLetterBoxAspect()
	{
		return 0f;
	}

	public bool IsLetterBox()
	{
		return false;
	}

	public bool IsHorizontal()
	{
		return false;
	}

	public bool IsVertical()
	{
		return false;
	}

	public int GetLetterBoxActiveSize()
	{
		return 0;
	}

	private uint GetGreatestCommonDivisor(uint value1, uint value2)
	{
		return 0u;
	}
}
