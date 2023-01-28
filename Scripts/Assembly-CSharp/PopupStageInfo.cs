using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Popup/PopupStageInfo")]
public class PopupStageInfo : PopupBase
{
	private DesignWorld.Data _designWorld;

	private List<DesignStage.Data> _stageList;

	private Transform _artifact;

	private Transform _item;

	private Transform _artifactCardPosition;

	private UIGrid _itemIconPosition;

	private UILabel _rewardDesc;

	private int _selectStage;

	private UILabel _battleStatLimit;

	private UILabel _stageNameLabel;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	public void InitPopup(int worldId)
	{
	}

	private void InitStageInfo()
	{
	}

	private void UpdateSelectStage()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
