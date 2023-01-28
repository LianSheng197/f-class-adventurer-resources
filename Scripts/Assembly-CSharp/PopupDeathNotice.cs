using UnityEngine;

[AddComponentMenu("Popup/PopupDeathNotice")]
public class PopupDeathNotice : PopupBase
{
	private const int AUTO_TIME = 10;

	private BattleData _battleData;

	private int _time;

	private UILabel _countLabel;

	public void InitPopup(BattleData battleData)
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
