using System.Collections.Generic;
using UnityEngine;

public class AutoCurrency : MonoBehaviour
{
	public enum Type
	{
		Currency = 0,
		CurrencyNoPlus = 1,
		AP = 2,
		APNoPlus = 3
	}

	public Type _type;

	public int _designId;

	public int _labelSizeX;

	public int _labelSizeY;

	public bool _isValueCount;

	private GameObject _currencyObj;

	private UILabel _count;

	private long _countValue;

	private UILabel _apTime;

	private bool _isLinkButton;

	private bool _isButtonLock;

	private UnitNumberLabel _unitNumberLabel;

	private Dictionary<int, long> _checkUpgradeCurrency;

	private void Update()
	{
	}

	public void SetCurrency(int designID = 0, long count = 0L)
	{
	}

	private void LinkButton()
	{
	}

	public void Change(long value)
	{
	}

	public void UpdateCurrency()
	{
	}

	public void SetUpgradeCurrency()
	{
	}

	public GameObject GetImageObj()
	{
		return null;
	}

	public void HotTime(bool isShow = true)
	{
	}

	private void Buy(UIButton btn)
	{
	}

	public static void ShowMoveShop(int designItemId, out DesignShopCategory.Data shop, out DesignShopCategory.Data popupShop, MsgBox.PopupMessage callBack, bool IsMsgBox = true)
	{
		shop = null;
		popupShop = null;
	}

	public static void ShowMoveShop(DesignItem.Data designItem, out DesignShopCategory.Data shop, out DesignShopCategory.Data popupShop, MsgBox.PopupMessage callBack, bool IsMsgBox = true)
	{
		shop = null;
		popupShop = null;
	}

	public static bool IsMoveShop(int designItemId, out DesignShopCategory.Data shop, out DesignShopCategory.Data popupShop)
	{
		shop = null;
		popupShop = null;
		return false;
	}

	public static void MoveShop(DesignItem.Data designItem)
	{
	}

	public static void MoveShop(int designId)
	{
	}

	public void EnableButtonLock(bool isLock)
	{
	}
}
