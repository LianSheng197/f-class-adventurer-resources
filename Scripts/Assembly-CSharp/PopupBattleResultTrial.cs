using UnityEngine;

[AddComponentMenu("Popup/PopupBattleResultTrial")]
public class PopupBattleResultTrial : PopupBase
{
	private const float REWARD_SHOW_TIME = 0.1f;

	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private BattleStageTrialReq _battleReq;

	private BattleStageTrialAck _battleAck;

	private bool _isArtifact;

	private bool _isReward;

	private UIGrid _rewardGrid;

	private int _time;

	private UILabel _timeLabel;

	public void InitPopup(WWWData wwwData, BattleData battleData)
	{
	}

	private void NextReward()
	{
	}

	private void NextTime()
	{
	}

	private void UpdateTime()
	{
	}

	private void GotoMain()
	{
	}

	public override void Message(UIButton btn)
	{
	}

	public void MoveAbusing(GameObject obj, UIButton btn)
	{
	}
}
