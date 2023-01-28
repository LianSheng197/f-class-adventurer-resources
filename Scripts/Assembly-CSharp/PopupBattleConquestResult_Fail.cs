using UnityEngine;

[AddComponentMenu("Popup/PopupBattleConquestResult_Fail")]
public class PopupBattleConquestResult_Fail : PopupBase
{
	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private int _time;

	private UILabel _timeLabel;

	private bool _isRevive;

	public void InitPopup(BattleData battleData)
	{
	}

	public override void PopupCloseCall()
	{
	}

	private void NextTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void Revive()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
