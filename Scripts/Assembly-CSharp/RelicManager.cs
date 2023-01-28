using System.Collections.Generic;

public class RelicManager
{
	private static RelicManager _Instance;

	private Dictionary<int, Relic> _relicList;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static RelicManager Instance => null;

	public void SetRelicList(List<Relic> relicList)
	{
	}

	public void SetRelic(Relic relic, bool contentsFunctionDataUpdate = true)
	{
	}

	public Relic GetRelic(int relicId)
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

	public float GetRelicGroupPercent(int relicGroup)
	{
		return 0f;
	}

	public float GetRelicPercent(int relicId)
	{
		return 0f;
	}

	public bool IsNew()
	{
		return false;
	}

	public bool IsGroupNew(int relicGroup)
	{
		return false;
	}

	public bool IsGet(int relicId)
	{
		return false;
	}

	public bool IsLevelUp(int relicId)
	{
		return false;
	}

	public Dictionary<int, long> GetSellList(int relicId)
	{
		return null;
	}

	public Dictionary<int, long> GetSellList()
	{
		return null;
	}
}
