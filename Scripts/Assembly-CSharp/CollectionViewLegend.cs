using System.Collections.Generic;
using UnityEngine;

public class CollectionViewLegend : CollectionViewBase
{
	private RadioGroup _radioGroup;

	private DesignLegend.Data.Category _curFilter;

	private Dictionary<DesignLegend.Data.Category, GameObject> _categoryNew;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UISprite _drag;

	private LegendCard _selectCard;

	private Dictionary<int, LegendCard> _cardList;

	private Transform _detailInfo;

	private Transform _itemCardPosition;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private UILabel _nameLabel;

	private UILabel _gradeLabel;

	private UILabel _levelLabel;

	private UISprite _fameSprite;

	private Transform _haveRoot;

	private Transform _needItemRoot;

	private UIGrid _btnGrid;

	private Transform _fameUpBtn;

	private GameObject _fameUpBtnNew;

	private UILabel _equipLabel;

	private Transform _sellBtn;

	private Transform _sellOn;

	private Transform _sellOff;

	private Transform _lvUpBtn;

	private Transform _lvUpOn;

	private Transform _lvUpOff;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private UIGrid _needItemGrid;

	private GameObject _getBtnNew;

	private GameObject _prefabFameItem;

	private float _fameItemSize;

	private GameObject _prefabStat;

	private ContentsRandomOptionViewLegend _randomOption;

	private GameObject _effectPosition;

	private GameObject _LvUPEffectPosition;

	private GameObject _levelUpEffect;

	private AutoButtonPush _autoPush;

	private int _openLevel;

	private GameObject _notOpen;

	private GameObject _legendDetailLeftInfo;

	private UILabel _name;

	private GameObject _characterObjectPosition;

	public override void Init()
	{
	}

	public override void EnterView()
	{
	}

	private void SelectFilter(string name)
	{
	}

	public override void UpdateView()
	{
	}

	public override void Ack(AckState ackState, int id = 0)
	{
	}

	private void EndLevelUpEffect(GameObject obj)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public override bool IsClose()
	{
		return false;
	}

	public override void UpdateItem()
	{
	}

	public override void UpdateNew()
	{
	}

	private void MakeList()
	{
	}

	public void UpdateSelectCard(LegendCard card)
	{
	}

	private void SelectLegend(UIButton btn)
	{
	}

	public int GetSiblingIndex(int legendId)
	{
		return 0;
	}

	public LegendCard GetLegendCard(int index)
	{
		return null;
	}

	public int GetGridCount()
	{
		return 0;
	}

	public void ShowDetailInfo(bool isShow)
	{
	}

	public void UpdateRandomOption()
	{
	}

	private void UpdateHaveDesc(Transform form, bool resetScrollView)
	{
	}

	private void AutoPushCall(UIButton btn, AutoButtonPush.DelegateState state)
	{
	}

	private bool AsyncLevelUp()
	{
		return false;
	}

	private void RequestAsync(UIButton btn)
	{
	}

	private void LvUp(UIButton btn)
	{
	}
}
