using System.Collections.Generic;

public class PowerStoneManager
{
	private static PowerStoneManager _Instance;

	private Dictionary<int, PowerStone> _powerStoneList;

	private Dictionary<int, PowerStoneMaterial> _powerStoneMaterialList;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static PowerStoneManager Instance => null;

	public void SetPowerStoneList(List<PowerStone> powerStoneList)
	{
	}

	public void SetPowerStone(PowerStone powerStone, bool contentsFunctionDataUpdate = true)
	{
	}

	public PowerStone GetPowerStone(int powerStoneId)
	{
		return null;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public bool CheckPowerStoneAllMax()
	{
		return false;
	}

	public void SetPowerStoneMaterialList(List<PowerStoneMaterial> powerStoneMaterialList)
	{
	}

	public void SetPowerStoneMaterial(PowerStoneMaterial powerStoneMaterial)
	{
	}

	public PowerStoneMaterial GetPowerStoneMaterial(int slot)
	{
		return null;
	}

	public bool IsNew()
	{
		return false;
	}

	public bool IsMaterial(int slot)
	{
		return false;
	}
}
