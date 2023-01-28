using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorldEventSelect")]
public class PopupWorldEventSelect : PopupBase
{
	private DesignWorld.Data _designWorld;

	private GameObject _prefab;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private Transform _stageDetailInfo;

	private int _curStageId;

	private int _curWorldId;

	private int _selectStageId;

	private int _selectWorldId;

	private Dictionary<int, GameObject> _stageSelectList;

	private List<ItemCharacterCard> _characterCardList;

	private UIGrid _characterCardGrid;

	private Transform _characterStat;

	private Transform _drop;

	public void InitPopup(StageManager.ScheduleData data)
	{
	}

	private void MakeList()
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

	public override void Message(UIButton btn)
	{
	}

	private void RefreshWorldList(GameObject obj, UIButton btn)
	{
	}
}
