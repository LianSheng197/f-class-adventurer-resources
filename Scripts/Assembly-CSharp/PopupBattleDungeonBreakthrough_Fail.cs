using UnityEngine;

[AddComponentMenu("Popup/PopupBattleDungeonBreakthrough_Fail")]
public class PopupBattleDungeonBreakthrough_Fail : PopupBase
{
	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private int _time;

	private UILabel _timeLabel;

	private bool _isNext;

	public void InitPopup(WWWData wwwData, BattleData battleData)
	{
	}

	private void NextTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void GotoMain()
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
