using System.Collections.Generic;
using UnityEngine;

public class ItemList : MonoBehaviour
{
	public delegate void SelectDelegate(UIButton btn, Item data);

	private SelectDelegate _selectDelegate;

	private GameObject _prefabRow;

	private UIScrollView _scrollView;

	private GameObject _topButton;

	private ItemSort _sort;

	private int _lineCount;

	private int _selectCount;

	private Dictionary<long, BaseObject> _selectList;

	private Dictionary<int, long> _sellInfo;

	public static ItemList Add(GameObject parent, SelectDelegate selectDelegate)
	{
		return null;
	}

	public void Init(SelectDelegate selectDelegate)
	{
	}

	public void ChangeDepth(int baseDepth)
	{
	}

	public void ShowTopButton(bool isShow)
	{
	}

	private void TopMessage(UIButton btn)
	{
	}

	private void SelectObject(UIButton btn)
	{
	}

	private void CheckItem(ItemCard card)
	{
	}

	public void UpdateList()
	{
	}

	public void UpdateSortView()
	{
	}

	private void UpdateViewList()
	{
	}

	private void UpdateViewList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public void FixFilter(ItemSort.Filter filter)
	{
	}

	public void ReleaseFixFilter()
	{
	}

	private void ChangeSortDelegate(bool isChangeFilter)
	{
	}

	public void ChangeSelectCount(int count)
	{
	}

	public void SetSellInfo(Dictionary<int, long> sellInfo)
	{
	}

	public Dictionary<long, BaseObject> GetSelectList()
	{
		return null;
	}
}
