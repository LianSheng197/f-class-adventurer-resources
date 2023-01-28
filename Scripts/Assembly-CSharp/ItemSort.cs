using System.Collections.Generic;
using UnityEngine;

public class ItemSort : MonoBehaviour
{
	public delegate void ChangeSortDelegate(bool isChangeFilter);

	public enum Filter
	{
		Normal = 0,
		Max = 1
	}

	public enum Sort
	{
		Fame = 0,
		Max = 1
	}

	private ItemList _itemList;

	private ChangeSortDelegate _changeDelegate;

	public List<Item> _viewList;

	public Filter _filter;

	private Sort _sort;

	private Dictionary<Sort, bool> _ascending;

	private RadioGroup _radioFilter;

	private Dictionary<Sort, UIButton> _sortBtn;

	private Dictionary<Sort, UISprite> _sortArrow;

	private bool _isChangeFilter;

	public void Init(ItemList itemList, ChangeSortDelegate changeDelegate, int initFilter = 0, int initEquipFilter = 0)
	{
	}

	private void ChangeTab(Filter filter)
	{
	}

	private void ChangeSort(Sort sort)
	{
	}

	public void FixFilter(Filter filter)
	{
	}

	public void ReleaseFixFilter()
	{
	}

	public void ShowFilter(bool isShow)
	{
	}

	public void UpdateList()
	{
	}

	public void UpdateViewList()
	{
	}

	private void SelectFilter(string select)
	{
	}

	private void Message(UIButton btn)
	{
	}

	public static int SortByItemNormal(Item a, Item b)
	{
		return 0;
	}
}
