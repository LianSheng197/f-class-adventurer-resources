using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupRandomOptionAutoSetting")]
public class PopupRandomOptionAutoSetting : PopupBase
{
	private PopupRandomOption _popupRandomOption;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private GameObject _prefab;

	private Transform _randomOptionBtnOn;

	private Transform _randomOptionBtnOff;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private int _curGrade;

	private Dictionary<int, List<DesignRandomOptionMagic.Data>> _dataList;

	private Dictionary<int, GameObject> _checkObjList;

	private List<int> _selectContentsFunctionIds;

	public void InitPopup(PopupRandomOption popupRandomOption, int randomOptionType)
	{
	}

	public override void UpdateItem()
	{
	}

	private void SelectFilter(string name)
	{
	}

	private void UpdateView()
	{
	}

	private void UpdateBtnState()
	{
	}

	private void UpdateCheck()
	{
	}

	private void OnSelect(UIButton btn)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
