using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupShop")]
public class PopupShop : PopupBase
{
	private static int _popupGroup;

	private static int _categoryGroup;

	private List<AutoCurrency> _autoCurrencyList;

	private UIScrollView _tabScrollView;

	private UIGrid _tabGrid;

	private UIScrollView _scrollView;

	private List<ShopForm> _curList;

	private List<int> _curSellTypeList;

	private List<GachaCard> _gachaCardList;

	private Transform _gachaForm;

	private bool _isGachaCategory;

	private bool _isMoving;

	public void InitPopup()
	{
	}

	public void InitPopup(DesignShopCategory.Data moveShopCategory)
	{
	}

	private void InitPopup(int popupGroup = 0, int popupCategoryId = 0)
	{
	}

	public void UpdateUI(bool Init)
	{
	}

	private void InitTab()
	{
	}

	private void UpdateCategoryTab()
	{
	}

	private void InitGachaList()
	{
	}

	private void InitSubCategory()
	{
	}

	public void InitCurrency()
	{
	}

	public void UpdateList(bool Init)
	{
	}

	public void InvokeTab(int categoryGroup)
	{
	}

	public void SelectTab(UIButton btn)
	{
	}

	public void OnTab()
	{
	}

	public static bool IsNew(int popupGroup, int categoryId = 0)
	{
		return false;
	}

	public static long GetReadIndex(int popupGroup, int categoryId)
	{
		return 0L;
	}

	public static void SetReadIndex(int popupGroup, int categoryId)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private GachaCard GetSelectGachaCard(UIButton btn)
	{
		return null;
	}

	public void LockGachaBtnList(WWWGachaCharacter www)
	{
	}

	public void BuyGacha(UIButton btn)
	{
	}

	public void UpdateGachaCardList()
	{
	}

	public override void PopupCloseCall()
	{
	}

	public DesignShopCategory.Data GetDesignShopCategory()
	{
		return null;
	}
}
