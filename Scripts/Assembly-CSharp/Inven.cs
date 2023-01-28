using System.Collections.Generic;

public class Inven<T> where T : BaseObject
{
	private bool _isLoading;

	private bool _isLoaded;

	protected Dictionary<long, T> _list;

	protected Dictionary<int, T> _listForDesignId;

	public bool IsLoading
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLoaded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void Init()
	{
	}

	public void Clear()
	{
	}

	public void ClearCount()
	{
	}

	public virtual int Count()
	{
		return 0;
	}

	public virtual void Add(long idx, T data)
	{
	}

	public void Remove(long idx)
	{
	}

	public T Get(long idx)
	{
		return null;
	}

	public List<T> GetList()
	{
		return null;
	}

	public List<T> GetList(int designId)
	{
		return null;
	}

	public void ClearNew()
	{
	}

	public bool CheckNew()
	{
		return false;
	}

	public bool ExistItem(int designId)
	{
		return false;
	}

	public T Find(int designId)
	{
		return null;
	}
}
