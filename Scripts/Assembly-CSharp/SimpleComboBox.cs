using System.Collections.Generic;
using UnityEngine;

public class SimpleComboBox : MonoBehaviour
{
	public delegate void ComboBoxMessage(int selectIndex);

	private ComboBoxMessage _delegate;

	private int _curIndex;

	public GameObject _prefabObj;

	private float _height;

	private UIButton _curButton;

	private UILabel _curButtonLabel;

	private bool _isListShow;

	private GameObject _listRoot;

	private Dictionary<int, GameObject> _list;

	private Dictionary<int, int> _nameList;

	private Dictionary<int, string> _nameListString;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void InitComboBox(List<int> comboList, ComboBoxMessage del, int initIndex = 0)
	{
	}

	public void InitComboBox(List<string> comboList, ComboBoxMessage del, int initIndex = 0)
	{
	}

	private void AddItem(int index, int languageID)
	{
	}

	private void AddItem(int index, string name)
	{
	}

	public void SetItem(int index)
	{
	}

	public void SetItem(string name)
	{
	}

	public int GetItem(int index)
	{
		return 0;
	}

	public void ShowList(bool isShow)
	{
	}

	private void onCurButton()
	{
	}

	private void onListSel(UIButton selectObj)
	{
	}
}
