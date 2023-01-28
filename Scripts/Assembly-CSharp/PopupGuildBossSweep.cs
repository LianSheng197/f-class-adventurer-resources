using UnityEngine;

[AddComponentMenu("Popup/PopupGuildBossSweep")]
public class PopupGuildBossSweep : PopupBase
{
	private UISlider _countSlider;

	private UILabel _countLabel;

	private long _sweepCount;

	private long _itemCount;

	private long _maxSweepCount;

	private DesignStage.Data _designStage;

	private bool _isShowAds;

	private bool _isAdsPlay;

	public void InitPopup(int stageId)
	{
	}

	private void UpdateCount()
	{
	}

	private void SetSweepCount()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}
}
