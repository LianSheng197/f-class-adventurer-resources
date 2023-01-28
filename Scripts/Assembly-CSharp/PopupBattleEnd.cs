using UnityEngine;

[AddComponentMenu("Popup/PopupBattleEnd")]
public class PopupBattleEnd : PopupBase
{
	private BattleData _battleData;

	private BattleData.BattleType _battleType;

	private GameObject _wait;

	public void InitPopup(BattleData battleData)
	{
	}

	private void ShowWait()
	{
	}

	private void WWWResult(WWWData www)
	{
	}

	public override void Message(UIButton btn)
	{
	}
}
