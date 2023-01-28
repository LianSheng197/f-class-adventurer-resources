using System.Collections.Generic;

public class LegendManager
{
	private static LegendManager _Instance;

	private Dictionary<int, Legend> _legendList;

	private int _legendEquip;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static LegendManager Instance => null;

	public void SetLegendList(List<Legend> list)
	{
	}

	public void SetLegend(Legend legend, bool contentsFunctionDataUpdate = true)
	{
	}

	public List<Legend> GetLegend()
	{
		return null;
	}

	public Legend GetLegend(int legendId)
	{
		return null;
	}

	public int GetLegendLevel(int legendId)
	{
		return 0;
	}

	public int GetLegendFame(int legendId)
	{
		return 0;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public DesignLegend.Data GetDesignLegendEquip()
	{
		return null;
	}

	public int GetLegendEquip()
	{
		return 0;
	}

	public void SetLegendEquip(int legendId)
	{
	}

	public bool IsEquip(int legendId)
	{
		return false;
	}

	public bool IsNew()
	{
		return false;
	}

	public bool IsNew(DesignLegend.Data.Category category)
	{
		return false;
	}

	public bool IsCategoryNew(DesignLegend.Data.Category category)
	{
		return false;
	}

	public bool IsGet(int legendId)
	{
		return false;
	}

	public bool IsFameUp(int legendId)
	{
		return false;
	}

	public long GetBattlePoint()
	{
		return 0L;
	}

	public Dictionary<int, long> GetSellList(int legendId)
	{
		return null;
	}

	public Dictionary<int, long> GetSellList()
	{
		return null;
	}
}
