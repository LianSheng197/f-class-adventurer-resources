using System.Collections.Generic;
using UnityEngine;

public class AndroidPermissionUtil : MonoBehaviour
{
	public enum Permission
	{
		READ_EXTERNAL_STORAGE = 0,
		Max = 1
	}

	public delegate void PerMissionDelegate();

	private PerMissionDelegate _perMissionDelegate;

	private List<Permission> _necessaryPermission;

	private Permission _curPermission;

	private int _permissionCount;

	private bool _isPermissionSetting;

	private void Awake()
	{
	}

	public void InitPermission(PerMissionDelegate perMissionDelegate)
	{
	}

	private void CheckPermission()
	{
	}

	private void SuccessPermission()
	{
	}

	private bool CheckNecessaryPerMission()
	{
		return false;
	}

	private bool CheckNecessaryPerMissionDenied()
	{
		return false;
	}

	private void RequestPermission()
	{
	}

	private void callbackRequestPermission(GameObject obj, UIButton btn)
	{
	}

	private void callbackRequestPermissionAgain(GameObject obj, UIButton btn)
	{
	}

	private void callbackRequestPermissionDenied(GameObject obj, UIButton btn)
	{
	}

	private string ConvertPerMissionString(Permission p)
	{
		return null;
	}

	private string ConvertPerMissionDeniedString(Permission p)
	{
		return null;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}
}
