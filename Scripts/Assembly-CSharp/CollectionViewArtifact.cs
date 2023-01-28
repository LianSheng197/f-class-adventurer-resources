using System.Collections.Generic;
using UnityEngine;

public class CollectionViewArtifact : CollectionViewBase
{
	private UIGrid _moneyPosition;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UISprite _drag;

	private EquipmentCard _selectCard;

	private Dictionary<int, EquipmentCard> _cardList;

	private Transform _detailInfo;

	private Transform _itemCardPosition;

	private GameObject _left;

	private GameObject _right;

	private UILabel _itemName;

	private UILabel _itemGrade;

	private GameObject _prefabHaveStat;

	private UIScrollView _haveStatScrollView;

	private UIGrid _haveStatGrid;

	private Transform _lvUpOn;

	private Transform _lvUpOff;

	private Transform _lvUpMax;

	private Transform _expand;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private AutoButtonPush _autoPush;

	private GameObject _effectPosition;

	private GameObject _levelUpEffect;

	private GameObject _expandEffect;

	private Transform _divideOn;

	private Transform _divideOff;

	private bool _isInit;

	private Dictionary<int, long> _checkNeedItem;

	private Transform _gachaRoot;

	private GachaCard _gachaCard;

	private int _gachaIdx;

	private List<int> _gachaSellType;

	public override void Init()
	{
	}

	public override void EnterView()
	{
	}

	public override void ExitView()
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

	public void InitAutoCurrency(Dictionary<int, long> needItem)
	{
	}

	private void MakeList()
	{
	}

	public void UpdateCardList()
	{
	}

	public int GetSiblingIndex(int id)
	{
		return 0;
	}

	public EquipmentCard GetEquipCard(int index)
	{
		return null;
	}

	public int GetGridCount()
	{
		return 0;
	}

	public void UpdateSelectCard(EquipmentCard card)
	{
	}

	private void SelectItem(UIButton btn)
	{
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private bool CheckUpgradeAllNew()
	{
		return false;
	}

	private void AutoPushCall(UIButton btn, AutoButtonPush.DelegateState state)
	{
	}

	private bool AsyncLevelUp()
	{
		return false;
	}

	public void AckLevelUp()
	{
	}

	private void RequestAsync(UIButton btn)
	{
	}

	public void AckExpandLevel()
	{
	}

	private void EndEffect(GameObject obj)
	{
	}

	private void LvUp(UIButton btn)
	{
	}

	private void InitGachaList()
	{
	}

	public void BuyGacha(UIButton btn)
	{
	}
}
