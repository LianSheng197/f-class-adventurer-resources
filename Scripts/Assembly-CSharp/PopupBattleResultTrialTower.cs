using UnityEngine;

[AddComponentMenu("Popup/PopupBattleResultTrialTower")]
public class PopupBattleResultTrialTower : PopupBase
{
	private const float REWARD_SHOW_TIME = 0.1f;

	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private BattleStageTrialTowerReq _battleReq;

	private BattleStageTrialTowerAck _battleAck;

	private UIGrid _rewardGrid;

	private int _time;

	private UILabel _timeLabel;

	public void InitPopup(WWWData wwwData, BattleData battleData)
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
