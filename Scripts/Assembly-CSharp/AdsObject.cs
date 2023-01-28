using UnityEngine;

public abstract class AdsObject : MonoBehaviour
{
	public enum AdsType
	{
		BANNER = 0,
		INTERSTITIAL = 1,
		REWARD = 2
	}

	public enum eState
	{
		Start = 0,
		Skip = 1,
		Completed = 2
	}

	protected string _adsName;

	public abstract bool Initialize();

	public abstract bool IsReady(AdsType adsType);

	public abstract int Show(AdsType adsType, AdsIntegration.AdsMessage del, string arg = "");

	public abstract void ShowBanner();

	public abstract void HideBanner();
}
