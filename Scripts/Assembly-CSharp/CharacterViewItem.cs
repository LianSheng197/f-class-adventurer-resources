using UnityEngine;

public class CharacterViewItem : MonoBehaviour
{
	private DesignUpgrade.Data _designUpgrade;

	private CharacterViewBase _viewBase;

	private UILabel _lvLabel;

	private Transform _state;

	private Transform _notOpen;

	private Transform _normal;

	private Transform _max;

	private UILabel _needLabel;

	private UILabel _normalBefore;

	private UILabel _normalAfter;

	private Transform _useOn;

	private Transform _useOff;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private UILabel _maxBefore;

	private GameObject _new;

	private GameObject _upgradeEffect;

	private int _upgradeCount;

	private bool _isAsyncLevelUp;

	public void Init(DesignUpgrade.Data designUpgrade, CharacterViewBase viewBase)
	{
	}

	public void ChangeUpgradeCount(int count)
	{
	}

	public void UpdateItem()
	{
	}

	public void AckUpgrade()
	{
	}

	public bool UpdateNew()
	{
		return false;
	}

	private void AutoPushCall(UIButton btn, AutoButtonPush.DelegateState state)
	{
	}

	private bool AsyncLevelUp()
	{
		return false;
	}

	private void RequestAsync(UIButton btn)
	{
	}

	private void Upgrade(UIButton btn)
	{
	}

	private void EndLevelUpEffect(GameObject obj)
	{
	}
}
