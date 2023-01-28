using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorldTowerSelect")]
public class PopupWorldTowerSelect : PopupBase
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

	private Transform _startNoNeedBtn;

	private bool _isShowAds;

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

	private void RefreshWorldList(GameObject obj, UIButton btn)
	{
	}

	private void AdsResult(AdsIntegration.eState state)
	{
	}
}
