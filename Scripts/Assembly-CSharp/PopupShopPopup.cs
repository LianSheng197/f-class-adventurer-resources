using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupShopPopup")]
public class PopupShopPopup : PopupBase
{
	private static int _popupGroup;

	private static int _categoryGroup;

	private List<AutoCurrency> _autoCurrencyList;

	private UIScrollView _tabScrollView;

	private UIScrollView _scrollView;

	private List<ShopForm> _curList;

	private List<int> _curSellTypeList;

	private bool _IsOnceCategory;

	public void InitPopup(DesignShopCategory.Data moveShopCategory)
	{
	}

	public void InitPopup(DesignShopPopupButton.Data popupBtn)
	{
	}

	private void InitPopup(int popupGroup = 0, int popupCategoryId = 0, string popupName = "")
	{
	}

	public void UpdateUI(bool Init)
	{
	}

	private void InitTab()
	{
	}

	private void InitSubCategory()
	{
	}

	private void InitCurrency()
	{
	}

	public void UpdateList(bool Init)
	{
	}

	public void InvokeTab(UIButton btn)
	{
	}

	public void OnTab()
	{
	}

	private void UpdateRemainTime()
	{
	}

	public override void PopupCloseCall()
	{
	}

	public override void Message(UIButton btn)
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

	public DesignShopCategory.Data GetDesignShopCategory()
	{
		return null;
	}
}
