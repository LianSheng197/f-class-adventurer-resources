using System.Collections.Generic;

public class EquipmentManager
{
	private static EquipmentManager _Instance;

	private Dictionary<int, Equipment> _equipmentList;

	private Dictionary<DesignEquipment.Data.Slot, EquipmentEquip> _equipmentEquipList;

	private List<ContentsFunctionData> _contentsFunctionData;

	private List<ContentsFunctionData> _contentsFunctionEquipData;

	private static DesignEquipment _designEquipment;

	public static EquipmentManager Instance => null;

	public void SetEquipmentList(List<Equipment> list)
	{
	}

	public void SetEquipment(Equipment equipment, bool contentsFunctionDataUpdate = true)
	{
	}

	public List<Equipment> GetEquipment()
	{
		return null;
	}

	public Equipment GetEquipment(int itemId)
	{
		return null;
	}

	public int GetEquipmentLevel(int itemId)
	{
		return 0;
	}

	public int GetEquipmentEnchant(int itemId)
	{
		return 0;
	}

	public bool IsMaxLevel(int itemId)
	{
		return false;
	}

	public int GetMaxLevel(int itemId)
	{
		return 0;
	}

	public bool IsExpandLevel(int itemId)
	{
		return false;
	}

	public DesignEquipmentEnchant.Data GetNextDesignEnchant(int itemId)
	{
		return null;
	}

	public void CheckUpdateContentsFunction(List<ItemMoney> checkList)
	{
	}

	public void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public void SetEquipmentEquipList(List<EquipmentEquip> list)
	{
	}

	public void SetEquipmentEquip(EquipmentEquip equipmentEquip, bool contentsFunctionDataUpdate = true)
	{
	}

	public bool IsEquip(int itemId)
	{
		return false;
	}

	public EquipmentEquip GetEquipmentEquip(DesignEquipment.Data.Slot slot)
	{
		return null;
	}

	public int GetEquipmentEquipItemId(DesignEquipment.Data.Slot slot)
	{
		return 0;
	}

	public void UpdateContentsFunctionEquip()
	{
	}

	public List<ContentsFunctionData> GetEquipContentsFunctionList()
	{
		return null;
	}

	public bool IsNew(DesignEquipment.Data.Slot checkSlot)
	{
		return false;
	}

	private bool IsNewCheck(DesignEquipment.Data.Slot checkSlot)
	{
		return false;
	}
}
