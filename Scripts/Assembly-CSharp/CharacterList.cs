using System.Collections.Generic;
using UnityEngine;

public class CharacterList : MonoBehaviour
{
	public delegate void SelectDelegate(UIButton btn, Character data);

	private SelectDelegate _selectDelegate;

	private GameObject _prefabRow;

	private UIScrollView _scrollView;

	private GameObject _topButton;

	private UILabel _count;

	private CharacterSort _sort;

	private int _lineCount;

	private long _targetIdx;

	private bool _isShowSelect;

	private bool _isInfoBtn;

	private int _selectCount;

	private Dictionary<long, BaseObject> _selectList;

	private BaseCard.LongTouchDelegate _longTouchDelegate;

	public static CharacterList Add(GameObject parent, SelectDelegate selectDelegate, long targetIdx = 0L, bool isShowSelect = false, bool isInfoBtn = false)
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

	public void SetLongTouch(BaseCard.LongTouchDelegate del)
	{
	}

	private void TopMessage(UIButton btn)
	{
	}

	private void SelectObject(UIButton btn)
	{
	}

	private void CheckItem(CharacterCard card)
	{
	}

	public void UpdateCount()
	{
	}

	public void UpdateList()
	{
	}

	public void UpdateSortView()
	{
	}

	public void UpdateViewList()
	{
	}

	private void UpdateViewList(GameObject obj, int wrapIndex, int realIndex)
	{
	}

	public void DisableScrollView()
	{
	}

	private void ChangeSortDelegate(bool isChangeFilter)
	{
	}

	public void ChangeSelectCount(int count)
	{
	}

	public void ChangeTargetIdx(long idx)
	{
	}

	public void ChangeShowSelect(bool isShow)
	{
	}

	public void ChangeInfoBtn(bool infoBtn)
	{
	}

	public void FirstSelect()
	{
	}

	public Dictionary<long, BaseObject> GetSelectList()
	{
		return null;
	}

	public Character GetViewIndexData(int index)
	{
		return null;
	}
}
