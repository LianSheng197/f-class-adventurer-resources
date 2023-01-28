using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupAdventureStageInfo")]
public class PopupAdventureStageInfo : PopupBase
{
	private DesignWorld.Data _designWorld;

	private GameObject _prefab;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private Dictionary<int, GameObject> _stageObjList;

	private Dictionary<int, GameObject> _stageSelectList;

	private UILabel _stageName;

	private UILabel _stageDesc;

	private int _selectStage;

	private Transform _startBtn;

	private UIGrid _rewardGrid;

	public void InitPopup(int worldId)
	{
	}

	private void MakeList()
	{
	}

	public void FocusStage(int stage)
	{
	}

	private void SelectStage(UIButton btn)
	{
	}

	private void UpdateSelectInfo()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
