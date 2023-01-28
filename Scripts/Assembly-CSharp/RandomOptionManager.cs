using System.Collections.Generic;

public class RandomOptionManager
{
	private static RandomOptionManager _Instance;

	private Dictionary<RandomOption.eType, Dictionary<int, Dictionary<int, RandomOption>>> _data;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static RandomOptionManager Instance => null;

	public void SetList(List<RandomOption> list, bool isClear)
	{
	}

	public void SetData(RandomOption data, bool contentsFunctionDataUpdate = true)
	{
	}

	public RandomOption GetData(RandomOption.eType type, int itemId, int slot)
	{
		return null;
	}

	public List<RandomOption> GetList(RandomOption.eType type, int itemId)
	{
		return null;
	}

	public int LockCount(RandomOption.eType type, int itemId)
	{
		return 0;
	}

	public bool IsActiveHaveEffect(RandomOption.eType type, int itemId)
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
}
