using UnityEngine;

public class WorldViewDungeon : WorldViewBase
{
	private UILabel _stageName;

	private GameObject _selectLeft;

	private GameObject _selectRight;

	private DesignWorld.Data _designWorld;

	private Transform _rewardBtn;

	private Transform _rewardOn;

	private Transform _rewardOff;

	private GameObject _clearMark;

	private int _curStage;

	public override void Init()
	{
	}

	public override void MakeList()
	{
	}

	public override void UpdateView()
	{
	}

	public override bool UpdateNew()
	{
		return false;
	}

	public override void Message(UIButton btn)
	{
	}

	public override void InitSelect(int worldId, int stage)
	{
	}

	public override void UpdateLevelUp()
	{
	}

	public void Request(int sweepCount)
	{
	}

	private void WWWResultBattle(WWWData www)
	{
	}
}
