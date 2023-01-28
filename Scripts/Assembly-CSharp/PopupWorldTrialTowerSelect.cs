using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorldTrialTowerSelect")]
public class PopupWorldTrialTowerSelect : PopupBase
{
	private const int _showFloorCount = 20;

	private DesignWorld.Data _designWorld;

	private GameObject _prefab;

	private UIScrollView _scrollView;

	private UIGrid _grid;

	private Dictionary<int, GameObject> _stageObjList;

	private Dictionary<int, GameObject> _stageSelectList;

	private int _selectStage;

	private Transform _startBtn;

	private UILabel _stageName;

	private UILabel _stageDesc;

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

	private void UpdateArtifactInfo()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
