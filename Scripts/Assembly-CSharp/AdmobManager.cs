using System;
using System.Collections.Generic;
using GoogleMobileAds.Api;

public class AdmobManager : AdsObject
{
	public class AdmobRewardVideo
	{
		public string _adUnitId;

		public RewardedAd _rewardVideo;

		private bool _isTestMode;

		public void Init(string adKey, bool isTestMode = false)
		{
		}

		public bool IsLoaded()
		{
			return false;
		}

		public void Show()
		{
		}

		public void LoadAd()
		{
		}
	}

	public class AdmobInterstitialVideo
	{
		private string _adUnitId;

		public InterstitialAd _interstitial;

		private bool _isTestMode;

		public void Init(string adKey, bool isTestMode = false)
		{
		}

		public bool IsLoaded()
		{
			return false;
		}

		public void Show()
		{
		}

		public void LoadAd()
		{
		}
	}

	private AdsIntegration.AdsMessage _delegate;

	private List<AdmobRewardVideo> _rewardVideoList;

	private List<AdmobInterstitialVideo> _interstitialVideoList;

	private AdmobRewardVideo _selectRewardVideo;

	private AdmobInterstitialVideo _selectInterstitialVideo;

	private bool _showResult;

	private bool _isTestMode;

	private string _arg;

	private AdsType _adsType;

	private void OnDestroy()
	{
	}

	public override bool Initialize()
	{
		return false;
	}

	private AdmobInterstitialVideo CreateInterstitialAd(string adUnitId)
	{
		return null;
	}

	public override bool IsReady(AdsType adsType)
	{
		return false;
	}

	public bool IsReadyRewardVideo()
	{
		return false;
	}

	public bool IsReadyInterstitialVideo()
	{
		return false;
	}

	public void InitBanner()
	{
	}

	public override void ShowBanner()
	{
	}

	public override void HideBanner()
	{
	}

	private void CreateRewardVideoList()
	{
	}

	private void CreateInterstitialVideoList()
	{
	}

	private AdmobRewardVideo CreateRewardBasedVideoObj(string adUnitId)
	{
		return null;
	}

	private void AddSelectVideoHandler(AdmobRewardVideo admobRewardVideo)
	{
	}

	private void AddSelectVideoHandler(AdmobInterstitialVideo admobInterstitialVideo)
	{
	}

	public override int Show(AdsType adsType, AdsIntegration.AdsMessage del, string arg = "")
	{
		return 0;
	}

	private int ShowRewardVideo()
	{
		return 0;
	}

	private int ShowInterstitialVideo()
	{
		return 0;
	}

	private void AdsResult()
	{
	}

	public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
	{
	}

	public void HandleRewardedAdClosed(object sender, EventArgs args)
	{
	}

	public void HandleUserEarnedReward(object sender, Reward args)
	{
	}

	public static string GetAndroidAdMobID()
	{
		return null;
	}

	public static string Md5Sum(string strToEncrypt)
	{
		return null;
	}

	public void PrefabTest()
	{
	}
}
