using System.Collections.Generic;

public class KeepMarkManager
{
	private static KeepMarkManager _Instance;

	private Dictionary<int, KeepMark> _list;

	private List<ContentsFunctionData> _contentsFunctionData;

	public static KeepMarkManager Instance => null;

	public void SetList(List<KeepMark> list)
	{
	}

	public void Set(KeepMark keepMark, bool contentsFunctionDataUpdate = true)
	{
	}

	public KeepMark Get(int id)
	{
		return null;
	}

	public bool IsOpen(int id)
	{
		return false;
	}

	public bool IsNew()
	{
		return false;
	}

	public bool IsNew(int id)
	{
		return false;
	}

	private void UpdateContentsFunction()
	{
	}

	public List<ContentsFunctionData> GetContentsFunctionList()
	{
		return null;
	}

	public Dictionary<int, long> GetSellList(int id)
	{
		return null;
	}

	public Dictionary<int, long> GetSellList()
	{
		return null;
	}
}
