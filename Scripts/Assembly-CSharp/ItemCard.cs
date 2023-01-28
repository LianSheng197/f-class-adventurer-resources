using UnityEngine;

public class ItemCard : BaseCard
{
	protected DesignItem.Data _designItem;

	private GameObject _addInfo;

	private bool _isTouchLock;

	public bool _isCondition;

	public static ItemCard Add(GameObject parent, int itemId)
	{
		return null;
	}

	public static ItemCard Add(GameObject parent, Item data = null, bool baseTouch = true, bool isCondtion = false)
	{
		return null;
	}

	public virtual void SetCount(long a, long b)
	{
	}

	public virtual void SetCount(long a)
	{
	}

	public static void Remove(GameObject parent)
	{
	}

	protected override void InitData()
	{
	}

	public override void UpdateInfo()
	{
	}

	protected override void Touch()
	{
	}

	protected override bool LongTouch()
	{
		return false;
	}

	protected virtual void SetName()
	{
	}

	public DesignItem.Data GetDesignItem()
	{
		return null;
	}

	public UIWidget GetRenderTarget()
	{
		return null;
	}

	public void New()
	{
	}

	public bool IsProhibition()
	{
		return false;
	}

	public void Prohibition(bool isShow)
	{
	}

	public void Hidden(bool isShow)
	{
	}

	public void SoldOut(bool isShow)
	{
	}

	public bool IsSoldOut()
	{
		return false;
	}

	public void Check(bool isShow)
	{
	}

	public void Sell()
	{
	}

	public void NeedCount()
	{
	}

	public void NeedCountValue()
	{
	}

	public void Select(bool select)
	{
	}

	public void HighSelect(bool select)
	{
	}

	public void Bonus(bool isShow = true)
	{
	}

	public void HotTime(bool isShow = true)
	{
	}

	public void Sale(bool isShow = true)
	{
	}

	public void NewSummon(bool isShow)
	{
	}

	public void NeedMaterial(bool isShow)
	{
	}

	public void RandomReward(bool isShow)
	{
	}

	public void FirstReward(bool isShow)
	{
	}

	public void IsGet(bool isGet)
	{
	}

	public void EnchantCharacter(bool isShow, int count = 0)
	{
	}

	public void EnchantCharacterItem(int count)
	{
	}

	public void SetImageBlind(bool isBlind)
	{
	}

	public void SetRandomBox(EventRandomBox.Data randomBox)
	{
	}

	public void SellInfo(bool isSell, long count)
	{
	}

	public void SetAltar(DesignEquipment.Data designEquipment)
	{
	}

	public void SetAltarEnable()
	{
	}

	private void ToolTip()
	{
	}

	public void EnableTouchLock(bool isLock)
	{
	}
}
