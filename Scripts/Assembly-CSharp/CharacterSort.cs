using System.Collections.Generic;
using UnityEngine;

public class CharacterSort : MonoBehaviour
{
	public delegate void ChangeSortDelegate(bool isChangeFilter);

	public enum FilterAttribute
	{
		ALL = 0,
		Fire = 1,
		Water = 2,
		Moon = 3,
		Sun = 4,
		Heal = 5,
		Max = 6
	}

	public enum FilterNation
	{
		ALL = 0,
		Akeatalos = 1,
		Grana = 2,
		Liberuna = 3,
		ErnenMora = 4,
		Mion = 5,
		Max = 6
	}

	public enum Sort
	{
		Grade = 0,
		Name = 1,
		Fame = 2,
		Max = 3
	}

	private ChangeSortDelegate _changeDelegate;

	public List<Character> _viewList;

	public bool _isFilterAttribute;

	public FilterAttribute _filterAttribute;

	public FilterNation _filterNation;

	private Sort _sort;

	private Dictionary<Sort, bool> _ascending;

	private RadioGroup _radioFilterAttribute;

	private RadioGroup _radioFilterNation;

	private Dictionary<Sort, List<GameObject>> _sortBtn;

	private bool _isChangeFilter;

	public long _targetIdx;

	public int _fameFilter;

	public int _levelFilter;

	public bool _lockShow;

	public List<Character> _customList;

	public void Init(ChangeSortDelegate changeDelegate)
	{
	}

	private void ChangeSort(Sort sort)
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

	private int SortByGrade(Character a, Character b)
	{
		return 0;
	}

	private int SortByName(Character a, Character b)
	{
		return 0;
	}

	private int SortByFame(Character a, Character b)
	{
		return 0;
	}
}
