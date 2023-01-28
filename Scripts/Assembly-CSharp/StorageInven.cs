using System.Collections.Generic;

public class StorageInven
{
	private List<Storage> _list;

	private long _lastIdx;

	public virtual void SetList(List<Storage> list)
	{
	}

	public virtual void Set(Storage data)
	{
	}

	public virtual List<Storage> GetList()
	{
		return null;
	}

	public virtual bool Remove(List<Storage> list)
	{
		return false;
	}

	public virtual void Remove()
	{
	}

	public virtual void SetLastIndex(long index)
	{
	}

	public virtual long GetLastIndex()
	{
		return 0L;
	}

	public int GetCount()
	{
		return 0;
	}
}
