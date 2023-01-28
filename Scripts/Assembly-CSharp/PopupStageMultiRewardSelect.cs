using UnityEngine;

[AddComponentMenu("Popup/PopupStageMultiRewardSelect")]
public class PopupStageMultiRewardSelect : PopupBase
{
	public delegate void RequestDelegate(int sweepCount);

	private RequestDelegate _callBack;

	private DesignWorld.Data _designWorld;

	private UISlider _slider;

	private UILabel _countLabel;

	private int _sweepCount;

	private int _sweepCountMax;

	public void InitPopup(DesignWorld.Data designWorld, RequestDelegate del)
	{
	}

	private void SliderChange()
	{
	}

	public void UpdateCount()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
