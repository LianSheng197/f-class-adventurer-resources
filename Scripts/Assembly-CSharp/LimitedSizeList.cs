using System.Collections.Generic;

public class LimitedSizeList<T> : LinkedList<T>
{
	private readonly int _maxSize;

	public LimitedSizeList(int maxSize)
	{
		((LinkedList<T>)(object)this)._002Ector();
	}

	public void Push(T item)
	{
	}
}
