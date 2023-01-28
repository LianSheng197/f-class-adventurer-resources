using UnityEngine;

[AddComponentMenu("Popup/PopupWorldSweep")]
public class PopupWorldSweep : PopupBase
{
	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private UISlider _slider;

	private UILabel _countLabel;

	private int _sweepCount;

	private int _sweepCountMax;

	private bool _isShowAds;

	private bool _isAdsPlay;

	public void InitPopup(int worldId)
	{
	}

	private void SliderChange()
	{
	}

	private void UpdateCount()
	{
	}

	private void Request(UIButton btn)
	{
	}

	private void WWWResultTower(WWWData www)
	{
	}

	private void WWWResultBoss(WWWData www)
	{
	}

	private void WWWResultBossDeal(WWWData www)
	{
	}

	private void WWWResultBattle(WWWData www)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}
}
