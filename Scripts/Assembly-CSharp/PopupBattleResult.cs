using UnityEngine;

[AddComponentMenu("Popup/PopupBattleResult")]
public class PopupBattleResult : PopupBase
{
	private const float REWARD_SHOW_TIME = 0.1f;

	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private BattleStageAck _battleAck;

	private FinishBossBattleAck _finishBossBattleAck;

	private FinishBossDealBattleAck _finishBossDealBattleAck;

	private FinishBattleAck _finishBattleAck;

	private int _rewardShow;

	private int _rewardCount;

	private int _firstRewardCount;

	private UIGrid _rewardGrid;

	private UIGrid _firstRewardGrid;

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
