using UnityEngine;

public class BattleVictoryChecker : MonoBehaviour
{
	private bool _isGameEnd;

	private BattleData _battleData;

	private DesignStage.Data _designStage;

	private DesignWorld.Data _designWorld;

	private GameObject _remainTime;

	private UILabel _remainTimeLabel;

	private UISprite _remainTimeIcon;

	private GameObject _remainMonster;

	private UISlider _remainMonsterSlider;

	private UILabel _remainCountLabel;

	private float _remainTimeDelta;

	private int _remainMonsterKill;

	private bool _isStageClear;

	private void Update()
	{
	}

	public void Init(BattleData battleData, Transform uiForm)
	{
	}

	public void AddMonsterKill()
	{
	}

	public int GetRemainMonsterKill()
	{
		return 0;
	}

	private void UpdateRemainTime()
	{
	}

	private void UpdateRemainMonster()
	{
	}

	private void CheckVictory()
	{
	}

	private void GameEnd()
	{
	}

	private void CheckEventWorldEnd()
	{
	}
}
