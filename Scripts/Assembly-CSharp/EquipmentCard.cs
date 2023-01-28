using UnityEngine;

public class EquipmentCard : BaseCard
{
	protected DesignItem.Data _designItem;

	protected DesignItemGrade.Data _designItemGrade;

	protected DesignItemSubGrade.Data _designItemSubGrade;

	protected DesignEquipment.Data _designEquipment;

	protected int _level;

	protected int _enchant;

	private GameObject _new;

	public static EquipmentCard Add(GameObject parent, int itemId)
	{
		return null;
	}

	public static EquipmentCard Set(EquipmentCard card, int itemId)
	{
		return null;
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

	public int GetLevel()
	{
		return 0;
	}

	public void SetLevel(int level)
	{
	}

	public int GetEnchant()
	{
		return 0;
	}

	public void SetEnchant(int enchant)
	{
	}

	public void SetHaveCount()
	{
	}

	public void NotHave(bool isNotHave)
	{
	}

	public void Equip(bool isEquip)
	{
	}

	public void SetNew(bool isNew)
	{
	}

	public bool IsNew()
	{
		return false;
	}

	public DesignItem.Data GetDesignItem()
	{
		return null;
	}

	public DesignEquipment.Data GetDesignEquipment()
	{
		return null;
	}

	public UIWidget GetRenderTarget()
	{
		return null;
	}

	private void ToolTip()
	{
	}
}
