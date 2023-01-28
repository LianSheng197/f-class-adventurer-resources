using UnityEngine;

public class BattleBossGuild : MonoBehaviour
{
	private BattleData _battleData;

	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private GameObject _bossHPObj;

	private GameObject _pointObj;

	private UILabel _pointLabel;

	private double _bossScoreScaleValue;

	private BattleObjectHero _boss;

	private double _score;

	private BattleBossHPGraph _battleBossHPGraph;

	public void Init(BattleData battleData, Transform uiForm)
	{
	}

	public void AddDamage(double damage)
	{
	}

	public double GetScore()
	{
		return 0.0;
	}

	private void UpdateScore()
	{
	}
}
