using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupSkill")]
public class PopupSkill : PopupBase
{
	private UIScrollView _scrollView;

	private UIGrid _grid;

	private UISprite _drag;

	private SkillCard _selectCard;

	private Dictionary<int, SkillCard> _cardList;

	private Transform _detailInfo;

	private Transform _itemCardPosition;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private UILabel _skillName;

	private UILabel _skillGrade;

	private UILabel _skillLevel;

	private UISprite _skillFame;

	private UILabel _skillMP;

	private UILabel _skillCoolTime;

	private UILabel _skillDescription;

	private Transform _haveDescription;

	private Transform _needItem;

	private UIGrid _btnGrid;

	private Transform _fameUpBtn;

	private GameObject _fameUpBtnNew;

	private Transform _sellBtn;

	private Transform _sellOn;

	private Transform _sellOff;

	private Transform _lvUpBtn;

	private Transform _lvUpOn;

	private Transform _lvUpOff;

	private Transform _lvUpMax;

	private Transform _evolutionBtn;

	private UISprite _onCostSprite;

	private UILabel _onCostLabel;

	private UISprite _offCostSprite;

	private UILabel _offCostLabel;

	private GameObject _prefabStat;

	private UIScrollView _descScrollView;

	private UIGrid _descGrid;

	private GameObject _evolutionPreviewBtn;

	private GameObject _evolutionPreviewRoot;

	private GameObject _getBtnNew;

	private GameObject _haveTitleLabel;

	private GameObject _evolutionTitleLabel;

	private AutoButtonPush _autoPush;

	private GameObject _effectPosition;

	private GameObject _LvUPEffectPosition;

	private GameObject _levelUpEffect;

	private Dictionary<int, long> _checkNeedItem;

	private Skill _prevSkill;

	public void InitPopup()
	{
	}

	public void InitAutoCurrency(bool isEvolution)
	{
	}

	private void MakeList()
	{
	}

	public override void UpdateNew()
	{
	}

	public override void UpdateItem()
	{
	}

	private void UpdateItemList()
	{
	}

	public void UpdateCard()
	{
	}

	public int GetSiblingIndex(int skillId)
	{
		return 0;
	}

	public SkillCard GetSkillCard(int index)
	{
		return null;
	}

	public int GetGridCount()
	{
		return 0;
	}

	public void UpdateSelectCard(SkillCard card)
	{
	}

	private void SelectSkill(UIButton btn)
	{
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private void UpdateHaveDesc()
	{
	}

	public void LearnSkill(Skill skill)
	{
	}

	public void LevelUpSkill(Skill skill)
	{
	}

	private void EndLevelUpEffect(GameObject obj)
	{
	}

	public void FameUpSkill(Skill skill)
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

	public override void Message(UIButton btn)
	{
	}

	public override void PopupCloseCall()
	{
	}
}
