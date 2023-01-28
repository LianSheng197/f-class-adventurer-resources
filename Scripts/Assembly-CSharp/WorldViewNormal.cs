using System.Collections.Generic;
using UnityEngine;

public class WorldViewNormal : WorldViewBase
{
	private DesignWorld.Data.NormalWorldType _curFilter;

	private RadioGroup _worldFilter;

	private UITexture _mapTexture;

	private GameObject _left;

	private GameObject _right;

	private Transform _worldDesc;

	private Transform _stageDetailInfo;

	private DesignWorld.Data.NormalWorldType _curNormalWorldType;

	private int _curStageId;

	private int _curWorldId;

	private int _selectStageId;

	private int _selectWorldId;

	private int _selectInfoStageId;

	private Dictionary<int, GameObject> _stageSelectList;

	private List<ItemCharacterCard> _characterCardList;

	private UIGrid _characterCardGrid;

	private Transform _characterStat;

	private Transform _drop;

	private GameObject _moveBtn;

	private GameObject _conquestStartBtn;

	private List<int> _contentsOpenStageId;

	private List<int> _promotionOpenStageId;

	private List<int> _newGearOpenStageId;

	private List<int> _altarOpenStageId;

	public override void Init()
	{
	}

	public override void MakeList()
	{
	}

	public override void UpdateView()
	{
	}

	private void InitWorldFilter()
	{
	}

	private void UpdateWorldOpenAlert()
	{
	}

	private void SelectFilter(string select)
	{
	}

	public override void Message(UIButton btn)
	{
	}

	private void UpdateStageSelect()
	{
	}

	private void SelectStage(UIButton btn)
	{
	}

	private void ShowDetailInfo(bool isShow)
	{
	}

	private void SelectCharacterCard(UIButton btn)
	{
	}

	private void UpdateStageDetailInfo(Character character)
	{
	}

	private void Move()
	{
	}
}
