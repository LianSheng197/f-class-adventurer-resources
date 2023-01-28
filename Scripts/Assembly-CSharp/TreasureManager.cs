using System.Collections.Generic;

public class TreasureManager
{
	private static TreasureManager _Instance;

	private List<TreasureData> _list;

	private List<ContentsFunctionData> _contentsFunctionData;

	private int _defaultTreasureCount;

	public static TreasureManager Instance => null;

	public void Init()
	{
	}

	public List<TreasureData> GetList()
	{
		return null;
	}

	public void SetList(List<TreasureData> list)
	{
	}

	public void SetTreasure(TreasureData treasure)
	{
	}

	public void DelTreasure(int treasureId)
	{
	}

	public TreasureData GetTreasure(int id)
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

	public bool IsNew()
	{
		return false;
	}

	public int MaxTreasureCount()
	{
		return 0;
	}

	public bool IsLevelUp(int id)
	{
		return false;
	}

	public DesignTreasurePrice.Data GetPrice()
	{
		return null;
	}

	public Dictionary<int, long> LevelUpPrice(int id)
	{
		return null;
	}
}
