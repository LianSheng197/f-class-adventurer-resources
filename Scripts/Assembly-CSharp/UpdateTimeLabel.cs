using System;
using UnityEngine;

public class UpdateTimeLabel : MonoBehaviour
{
	public enum eType
	{
		None = 0,
		Remain = 1,
		Reset = 2,
		Refresh = 3,
		currentTime = 4,
		InstantShopTime = 5,
		Size = 6
	}

	public eType _type;

	public DateTime _pivotTime;

	protected UILabel _label;

	private float _updateSeconds;

	private float _seconds;

	private int _optionLanguageId;

	private int _endLanguageId;

	public static UpdateTimeLabel Add(GameObject obj, DateTime pivotTime, eType type = eType.Remain)
	{
		return null;
	}

	public static void Remove(GameObject obj)
	{
	}

	public void UpdateSeconds(float ts)
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public virtual void UpdateTime()
	{
	}

	public void ChangeOptionLanguageId(int id)
	{
	}

	public void ChangeEndLanguageId(int id)
	{
	}

	private static int GetLanguageId(eType type)
	{
		return 0;
	}

	public static string GetString(eType type, TimeSpan ts)
	{
		return null;
	}
}
