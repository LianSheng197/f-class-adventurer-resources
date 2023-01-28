using System.Collections.Generic;
using UnityEngine;

public class CollectionViewTreasure : CollectionViewBase
{
	private GameObject _prefabCard;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UISprite _drag;

	private UILabel _countLabel;

	private Transform _makeBtn;

	private UISprite _onMakeCostSprite;

	private UILabel _onMakeCostLabel;

	private UISprite _offMakeCostSprite;

	private UILabel _offMakeCostLabel;

	private Transform _detailInfo;

	private GameObject _left;

	private GameObject _right;

	private Dictionary<int, GameObject> _treasureCardList;

	private Transform _cardPosition;

	private UILabel _namelabel;

	private UILabel _lvlabel;

	private UILabel _description;

	private UILabel _maxDescription;

	private UILabel _afterDescription;

	private GameObject _afterArrow;

	private UILabel _levelCondition;

	private Transform _lvUp;

	private Transform _lvUpMax;

	private Transform _lvOn;

	private Transform _lvOff;

	private UISprite _onLvCostSprite;

	private UISprite _offLvCostSprite;

	private UILabel _onLvCostLabel;

	private UILabel _offLvCostLabel;

	private Transform _rubyOn;

	private Transform _rubyOff;

	private UILabel _onRubyCostLabel;

	private UILabel _offRubyCostLabel;

	private GameObject _effectPosition;

	private int _selectTreasureId;

	private long _rubyCost;

	private GameObject _noHave;

	public override void Init()
	{
	}

	public override void UpdateView()
	{
	}

	public override void Ack(AckState ackState, int id = 0)
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

	private void MakeTreasure()
	{
	}

	private void SelectTreasure(UIButton btn)
	{
	}

	public int GetSiblingIndex(int id)
	{
		return 0;
	}

	public int GetIndexId(int index)
	{
		return 0;
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private void LvUpConfirm(bool confirm)
	{
	}
}
