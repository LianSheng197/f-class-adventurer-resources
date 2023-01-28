public class IronSrcManager : AdsObject
{
	private enum PlayState
	{
		Wait = 0,
		Playing = 1,
		End = 2
	}

	private AdsIntegration.AdsMessage _delegate;

	private bool _showResult;

	private bool _isTestMode;

	private string _arg;

	private AdsType _adsType;

	private int _tick;

	private PlayState _currentPlayState;

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	public override bool Initialize()
	{
		return false;
	}

	public void validateIntegration()
	{
	}

	public override bool IsReady(AdsType adsType)
	{
		return false;
	}

	public override void ShowBanner()
	{
	}

	public override void HideBanner()
	{
	}

	public override int Show(AdsType adsType, AdsIntegration.AdsMessage del, string arg = "")
	{
		return 0;
	}

	private void AdsResult()
	{
	}

	private void SdkInitializationCompletedEvent()
	{
	}

	private void RewardedVideoAdClosedEvent()
	{
	}

	private void RewardedVideoAdRewardedEvent(IronSourcePlacement placement)
	{
	}

	private void RewardedVideoAdShowFailedEvent(IronSourceError error)
	{
	}

	private void RewardedVideoAdEndedEvent()
	{
	}

	private void RewardedVideoAdOpenedEvent()
	{
	}

	private void RewardedVideoAvailabilityChangedEvent(bool available)
	{
	}

	private void RewardedVideoAdStartedEvent()
	{
	}

	private void RewardedVideoAdClickedEvent(IronSourcePlacement placement)
	{
	}

	private void RewardedVideoOnAdAvailable(IronSourceAdInfo adInfo)
	{
	}

	private void RewardedVideoOnAdUnavailable()
	{
	}

	private void RewardedVideoOnAdOpenedEvent(IronSourceAdInfo adInfo)
	{
	}

	private void RewardedVideoOnAdClosedEvent(IronSourceAdInfo adInfo)
	{
	}

	private void RewardedVideoOnAdRewardedEvent(IronSourcePlacement placement, IronSourceAdInfo adInfo)
	{
	}

	private void RewardedVideoOnAdShowFailedEvent(IronSourceError error, IronSourceAdInfo adInfo)
	{
	}

	private void RewardedVideoOnAdClickedEvent(IronSourcePlacement placement, IronSourceAdInfo adInfo)
	{
	}

	private void InterstitialAdShowFailedEvent(IronSourceError error)
	{
	}

	private void InterstitialAdClosedEvent()
	{
	}

	public static string Md5Sum(string strToEncrypt)
	{
		return null;
	}

	public static string GetAndroidAdMobID()
	{
		return null;
	}

	private void SetAdmobTestDevice()
	{
	}
}
