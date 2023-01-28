using UnityEngine;

public class CompKeepMark : MonoBehaviour
{
	private DesignKeepMark.Data _designKeepMark;

	private DesignItem.Data _needDesignItem;

	private KeepMark _keepMark;

	private UILabel _name;

	private UILabel _description;

	private Transform _notOpen;

	private UILabel _openCondition;

	private UILabel _successRate;

	private UILabel _plusSuccessRate;

	private GameObject _effectPosition;

	private GameObject _effectKeepMarkEnchant;

	private GameObject _effectKeepMarkEnchantFail;

	private GameObject _new;

	private Transform _lvUpBtn;

	private Transform _lvUpOn;

	private Transform _lvUpOff;

	private UILabel _lvUpOnCost;

	private Transform _sellBtn;

	private Transform _sellOn;

	private Transform _sellOff;

	private UILabel _sellOnCost;

	private int _levelUpCount;

	public void Init(DesignKeepMark.Data designKeepMark)
	{
	}

	public void UpdateView()
	{
	}

	public void UpdateNew()
	{
	}

	public bool CheckNotOpen()
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

	private void Message(UIButton btn)
	{
	}

	public void LevelUp(bool isSuccess)
	{
	}

	private void EndLevelUpEffect(GameObject obj)
	{
	}
}
