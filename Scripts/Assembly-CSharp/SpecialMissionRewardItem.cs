using UnityEngine;

public class SpecialMissionRewardItem : MonoBehaviour
{
	public enum RewardState
	{
		InActive = -1,
		Active = 0,
		Completed = 1
	}

	private RewardState _normalState;

	private RewardState _premiumState;

	private GameObject _normalObj;

	private GameObject _premiumObj;

	private UISlider _sliderGraph;

	public DesignSpecialMission.Data _designSpecialMission;

	public DesignSpecialMission.RewardData _rewardData;

	private int _index;

	public void Init(DesignSpecialMission.Data designSpecialMission, DesignSpecialMission.RewardData rewardData, int index)
	{
	}

	public void UpdateItem()
	{
	}

	private void UpdateGraph()
	{
	}

	public bool IsActiveNormal()
	{
		return false;
	}

	public bool IsInActiveNormal()
	{
		return false;
	}

	public bool IsActivePremium()
	{
		return false;
	}

	public bool IsInActivePremium()
	{
		return false;
	}

	public void ChangeStateNormal(RewardState state)
	{
	}

	public void ChangeStatePremium(RewardState state)
	{
	}
}
