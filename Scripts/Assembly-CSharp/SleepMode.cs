using System.Collections.Generic;
using UnityEngine;

public class SleepMode : MonoBehaviour
{
	private static SleepMode _instance;

	private int _uiLayer;

	private int _sleepModeLayer;

	private UICamera _uiCamera;

	private List<LanguageApply> _languageApply;

	private GameObject _sleepModeObj;

	private UISlider _slider;

	private UIButton _thumb;

	private bool _isPress;

	private float _sleepModeTime;

	public static SleepMode Instance => null;

	private void Update()
	{
	}

	public void Init()
	{
	}

	public void ChangeFont()
	{
	}

	public bool IsSleepMode()
	{
		return false;
	}

	public void SetSleepMode(bool isSleepMode)
	{
	}

	public void ChangeMask()
	{
	}

	private void CheckSleepMode()
	{
	}

	private void CheckSlide()
	{
	}
}
