using UnityEngine;

[AddComponentMenu("Popup/PopupShopDetail")]
public class PopupShopDetail : PopupBase
{
	public delegate bool BuyDelegate(int count = 1);

	private BuyDelegate _del;

	protected bool _monthlyState;

	private int _buyCount;

	private int _buyMaxCount;

	private UISlider _countSlider;

	private EventDelegate _sliderEvent;

	protected DesignShop.Data _data;

	public void InitPopup(DesignShop.Data data, BuyDelegate del)
	{
	}

	protected virtual void UpdateUI()
	{
	}

	private int GetValidMaxCount()
	{
		return 0;
	}

	private void UpdateSlider(UISlider slider)
	{
	}

	private void UpdateBuyCount()
	{
	}

	public void OnSlider(UIButton btn)
	{
	}

	private void UpdateTime()
	{
	}

	private void UpdateMonthlyTimeLabel()
	{
	}

	private void UpdateItemList()
	{
	}

	private void UpdateItemData()
	{
	}

	private void UpdateMonthlyItemData()
	{
	}

	private void UpdatePrice()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
