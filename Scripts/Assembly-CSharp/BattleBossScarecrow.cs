using UnityEngine;

public class BattleBossScarecrow : MonoBehaviour
{
	private BattleData _battleData;

	private DesignWorld.Data _designWorld;

	private DesignStage.Data _designStage;

	private GameObject _bossHPObj;

	private UILabel _pointLabel;

	private UILabel _maxPointLabel;

	private double _score;

	private BattleBossScarecrowGraph _battleBossScarecrowGraph;

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
