using System.Collections.Generic;
using UnityEngine;

public class AdsIntegration : MonoBehaviour
{
	public enum eState
	{
		Failed = 0,
		Success = 1,
		Not_Initialized = 2,
		Playing = 3
	}

	public delegate void AdsMessage(eState state);

	private List<string> _orderList;

	private const string STR_UNITY_ADS = "unityads";

	private const string STR_APP_LOVIN = "applovin";

	private const string STR_ADMOB = "admob";

	private const string STR_IRON_SRC = "ironsrc";

	private Dictionary<string, AdsObject> _adsObjctList;

	public bool _isAds;

	public bool _isBanner;

	private bool initialize;

	private static AdsIntegration instance;

	public static AdsIntegration Instance => null;

	public void Init()
	{
	}

	public AdsObject GetReadyAds(AdsObject.AdsType adsType)
	{
		return null;
	}

	public bool Show(AdsMessage del, AdsObject target = null, string arg = "")
	{
		return false;
	}

	public bool ShowInterstitial(AdsMessage del, AdsObject target = null)
	{
		return false;
	}

	public bool InitOrderList()
	{
		return false;
	}

	public void LogAds(AdsObject.AdsType adsType, string adsName, string placementId, AdsObject.eState state)
	{
	}

	private void OnApplicationPause(bool isPaused)
	{
	}
}
