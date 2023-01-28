using System.Collections.Generic;

public class EventCardOpenManager
{
	public Dictionary<int, EventRandomCardInfo> _list;

	public bool _isChangeCardSelect;

	public List<Item> _beforeChangeItem;

	public void Init()
	{
	}

	public void SetData(List<EventRandomCardInfo> list)
	{
	}

	public EventRandomCardInfo GetData(int designId)
	{
		return null;
	}

	public bool IsEmptyPage(int designId)
	{
		return false;
	}

	public bool CheckNext(int designId)
	{
		return false;
	}

	public bool IsAllReward(int designId)
	{
		return false;
	}

	public int GetLimitCount(int designId, int index)
	{
		return 0;
	}
}
