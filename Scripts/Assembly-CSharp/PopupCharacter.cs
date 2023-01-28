using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupCharacter")]
public class PopupCharacter : PopupBase
{
	private DesignUpgrade.Data.Type _curTab;

	private RadioGroup _radioGroup;

	private Dictionary<DesignUpgrade.Data.Type, CharacterViewBase> _viewList;

	private List<AutoCurrency> _currencyList;

	private UIButton _resetBtn;

	private Transform _upgradeForm;

	private int _upgradeCount;

	private DesignUpgrade.Data.Type _resetType;

	private Dictionary<DesignUpgrade.Data.Type, Dictionary<int, long>> _resetCost;

	private Vector3 _presetPos;

	private RadioGroup _preSetRadioGroup;

	private byte _openSlot;

	private UIButton _openLockBtn;

	private CharacterViewCharacteristic _characteristicView;

	private CharacterViewPromotion _characterViewPromotion;

	private CharacterViewAltar _characterViewAltar;

	private UIGrid _moneyPosition;

	private int _needStageIdAltar;

	public void InitPopup(int returnStageId = 0)
	{
	}

	private void InitAutoCurrency()
	{
	}

	private void UpdateAutoCurrency()
	{
	}

	private bool CheckFilter(string select)
	{
		return false;
	}

	private void SelectFilter(string select)
	{
	}

	public void InitCurrentTab()
	{
	}

	public override void UpdateItem()
	{
	}

	public void UpdateView()
	{
	}

	public CharacterViewCharacteristic GetCharacteristicView()
	{
		return null;
	}

	public override void Message(UIButton btn)
	{
	}

	private void AskReset()
	{
	}

	private void BuyConfirm(bool buyConfirm)
	{
	}

	private void ChangeUpgradeCount(int change)
	{
	}

	public void UpdatePresetFilter()
	{
	}

	private void SelectPresetFilter(string select)
	{
	}

	private void SetSlotLockMessage()
	{
	}

	private void LockSlot(UIButton btn)
	{
	}

	private void OpenSlotBuyConfirm(bool buyConfirm)
	{
	}

	public override void PopupCloseCall()
	{
	}
}
