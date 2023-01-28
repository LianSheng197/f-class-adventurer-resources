using System.Collections.Generic;
using UnityEngine;

public class CharacterViewPromotion : MonoBehaviour
{
	private DesignWorld.Data _designWorld;

	private UISprite _rankingIcon;

	private GameObject _rewardPrefab;

	private UIGrid _rewardGrid;

	private UILabel _stageName;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private Transform _firstClearReward;

	private UIGrid _firstClearRewardGrid;

	private GameObject _startBtn;

	private UILabel _conditionLabel;

	private GameObject _clearLabel;

	private int _selectStage;

	private List<DesignStage.Data> _stageList;

	public void Init()
	{
	}

	public void UpdateView()
	{
	}

	private void Message(UIButton btn)
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
}
