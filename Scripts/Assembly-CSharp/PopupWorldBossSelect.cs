using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupWorldBossSelect")]
public class PopupWorldBossSelect : PopupBase
{
	protected DesignWorld.Data _designWorld;

	private List<DesignStage.Data> _stageList;

	private UISprite _bossImg;

	private UIGrid _firstClearReward;

	private UIGrid _clearReward;

	private UILabel _stageName;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private GameObject _clear;

	private GameObject _noTry;

	private Transform _startBtn;

	private Transform _startNoNeedBtn;

	private int _selectStage;

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
