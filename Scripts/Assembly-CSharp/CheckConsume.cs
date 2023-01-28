using System.Collections.Generic;
using UnityEngine;

public class CheckConsume : MonoBehaviour
{
	public enum ConsumeResult
	{
		Complete = 0,
		Fail = 1
	}

	private Dictionary<int, long> _items;

	private Dictionary<int, ItemCard> _itemCardList;

	private bool _isTouchLock;

	public static CheckConsume Add(Transform target, Dictionary<int, long> checkItem = null)
	{
		return null;
	}

	public static CheckConsume Add(GameObject target, Dictionary<int, long> checkItem = null)
	{
		return null;
	}

	public void Init(Dictionary<int, long> checkItem)
	{
	}

	public ConsumeResult GetResult(bool isMsg = true)
	{
		return default(ConsumeResult);
	}

	public Dictionary<int, ItemCard> GetItemCardList()
	{
		return null;
	}

	public static bool CheckConsumeResult(Dictionary<int, long> needItem)
	{
		return false;
	}

	public static bool CheckConsumeResult(int itemId, long itemValue)
	{
		return false;
	}

	public void EnableTouchLock(bool isLock)
	{
	}
}
