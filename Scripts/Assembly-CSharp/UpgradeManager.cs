using System.Collections.Generic;

public class UpgradeManager
{
	private static UpgradeManager _Instance;

	private DesignUpgrade _designUpgrade;

	private Dictionary<DesignUpgrade.Data.Type, Dictionary<int, Dictionary<byte, UpgradeData>>> _upgrades;

	public List<int> _upgradeNewData;

	private Dictionary<DesignUpgrade.Data.Type, byte> _curSlot;

	private Dictionary<DesignUpgrade.Data.Type, Dictionary<int, long>> _upgradeRefundValue;

	private List<ContentsFunctionData> _contentsFunctionData;

	private Dictionary<DesignUpgrade.Data.Type, List<byte>> _openSlot;

	private int _lvUpUpgradeId;

	public static UpgradeManager Instance => null;

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public byte GetSlot(DesignUpgrade.Data.Type type)
	{
		return 0;
	}

	public void ChangeSlot(DesignUpgrade.Data.Type type, byte slot)
	{
	}

	public void SetUpgradeList(List<UpgradeData> list, DesignUpgrade.Data.Type resetType)
	{
	}

	public void SetUpgrade(UpgradeData upgradeData, bool contentsFunctionDataUpdate = true, bool refundValueUpdate = true)
	{
	}

	public void GetUpgradeList(ref List<UpgradeData> list)
	{
	}

	public UpgradeData GetUpgrade(int id)
	{
		return null;
	}

	public bool IsPossibleReset(DesignUpgrade.Data.Type type)
	{
		return false;
	}

	public void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public bool IsOpenUpgrade(int id)
	{
		return false;
	}

	public bool IsNewUpgrade()
	{
		return false;
	}

	public bool IsNewUpgrade(DesignUpgrade.Data.Type type)
	{
		return false;
	}

	public bool IsNewUpgrade(int designId)
	{
		return false;
	}

	public void CheckUpgradeNew(int designId)
	{
	}

	public void RemoveUpgradeNew(List<int> removeIds)
	{
	}

	public void GetRefundValue(ref Dictionary<int, long> sum)
	{
	}

	public void UpdateRefundValue(DesignUpgrade.Data.Type type)
	{
	}

	public bool CheckConsumeResult(DesignUpgrade.Data.Type type, Dictionary<int, long> needItem)
	{
		return false;
	}

	public void LoadOpenSlot()
	{
	}

	public void UpdateOpenSlot(DesignUpgrade.Data.Type type, byte slot)
	{
	}

	public bool IsOpenSlot(DesignUpgrade.Data.Type type, byte slot)
	{
		return false;
	}

	public void SetLevelUpUpgrade(int upgradeId)
	{
	}

	public bool PossibleLevelUp(int upgradeId)
	{
		return false;
	}
}
