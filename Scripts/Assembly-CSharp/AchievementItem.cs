using UnityEngine;

public class AchievementItem : MonoBehaviour
{
	private DesignAchievement.Data _designAchievement;

	private Transform _itemCard;

	private bool _isShowAds;

	public void Init(int stepGroup, int step)
	{
	}

	private void OnDestroy()
	{
	}

	public void GetBtn(UIButton btn)
	{
	}

	public void AdsBtn(UIButton btn)
	{
	}

	private DesignAchievement.Data CheckNextStep(AchievementData progressData)
	{
		return null;
	}

	public void UpdateProgress()
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}
}
