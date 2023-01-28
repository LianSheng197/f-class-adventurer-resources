using System.Collections.Generic;
using UnityEngine;

public class BattleData : MonoBehaviour
{
	public enum BattleType
	{
		Stage = 1,
		Test = 2,
		Max = 3
	}

	public enum BattlePlay
	{
		Pause = 0,
		Play = 1,
		WaitNetwork = 2,
		End = 3
	}

	public static bool _drawLine;

	private const float _bossKillTimeScale = 0.5f;

	private Battle _battle;

	public BattleCalcData _battleCalcData;

	public BattleType _battleType;

	public bool _result;

	public DesignWorld.Data _designWorld;

	public DesignStage.Data _designStage;

	public BattlePlay _battlePlay;

	public bool _fieldBossKill;

	private GameObject _battleZoneScale;

	private GameObject _battleZoneRoot;

	private GameObject _shaking;

	private BattleTileMap _battleTileMap;

	private UIScrollView _scrollView;

	private GameObject _damageRoot;

	private Dictionary<GameObject, List<GameObject>> _damageLabelPool;

	private BattleThrowManager _throwManager;

	private GameObject _battleZoneEffectRoot;

	private GameObject _screenEffectRoot;

	private UIWidget _renderTarget;

	public BattleObjectHeroPool _heroPool;

	public EffectPool _effectPool;

	public List<BattleObjectBase> _userList;

	private BattleRespawnManager _battleRespawnManager;

	private List<BattleObjectBase> _cancelAttackSchedule;

	private List<BattleObjectBase> _cancelAttackScheduleCheckList;

	private Vector3 _userPos;

	private BattleDPad _battleDPad;

	private BattleCharacterSkill _battleCharacterSkill;

	private BattleVictoryChecker _battleVictoryChecker;

	private BattleBoss _battleBoss;

	private BattleBossGuild _battleBossGuild;

	private BattleBossScarecrow _battleBossScarecrow;

	private BattleCalcPosition _battleCalcPosition;

	private BattleStageMove _battleStageMove;

	public Dictionary<int, int> _deadMonsterList;

	private GameObject _bossKillEffect;

	public UIPanel _panelBattleZone;

	public UIPanel _panelUI;

	private void Update()
	{
	}

	public void Init(Battle battle)
	{
	}

	public GameObject GetBattleZoneRoot()
	{
		return null;
	}

	public GameObject GetBattleZoneEffectRoot()
	{
		return null;
	}

	public GameObject GetScreenEffectRoot()
	{
		return null;
	}

	public UIWidget GetRenderTarget()
	{
		return null;
	}

	public BattleDPad GetBattleDPad()
	{
		return null;
	}

	public void ScenarioActive(bool isActive)
	{
	}

	public void ScreenShaking(float time)
	{
	}

	public void ScreenShakingAni(string ani)
	{
	}

	private void EndShakingAni(GameObject obj)
	{
	}

	public Vector3 GetViewCenterPos()
	{
		return default(Vector3);
	}

	public void ShowDrawLine()
	{
	}

	public void RefreshUser()
	{
	}

	public void RefreshUserEquip()
	{
	}

	public void UserSummon()
	{
	}

	public BattleObjectBase UserSkillSummon(Character character, Vector3 pos, float summonTime)
	{
		return null;
	}

	public BattleCalcPosition GetBattleCalcPosition()
	{
		return null;
	}

	public BattleStageMove GetBattleStageMove()
	{
		return null;
	}

	public BattleTileMap GetBattleTileMap()
	{
		return null;
	}

	private void MakeBattleRespawn()
	{
	}

	public void BattleRespawnReset()
	{
	}

	public List<BattleObjectBase> GetEnemyList()
	{
		return null;
	}

	public void EnemyCounterattack(BattleObjectBase target, int respawnIndex)
	{
	}

	public void RemoveHero(bool isUser, BattleObjectBase battleObject)
	{
	}

	public void KillBossClearFieldMonster()
	{
	}

	public void ClearCancelAttackSchedule()
	{
	}

	public void AddCancelAttackSchedule(BattleObjectBase target)
	{
	}

	public void CancelAttackSchedule()
	{
	}

	private void CancelAttackSchedule(BattleObjectBase target)
	{
	}

	public BattleThrowManager.ArrowData ArrowDataPool()
	{
		return null;
	}

	public void ArrowFire(BattleObjectHero attacker, BattleThrowManager.ArrowData arrowData)
	{
	}

	public void UserFocus()
	{
	}

	public void UpdateSkillInfo()
	{
	}

	public void SetChangeCharacterSkillCoolTime(int skillId)
	{
	}

	public void ToggleSkillAuto()
	{
	}

	public void Play(BattlePlay play)
	{
	}

	public void GamePause(bool isPause)
	{
	}

	public void AddDamageLabel(GameObject prefab, string value, Vector3 worldPos, float centerPosY, Vector3 hitOffset, float scale)
	{
	}

	private void EndDamageLabel(GameObject obj)
	{
	}

	public bool IsEnemySummon()
	{
		return false;
	}

	public void AddBossDamage(double damage)
	{
	}

	public void AddBossHP(BattleObjectHero boss)
	{
	}

	public double GetBossScore()
	{
		return 0.0;
	}

	public void ResetVictoryChecker()
	{
	}

	public void GameEndPrev(bool isWin)
	{
	}

	public void KillBossEffect(BattleObjectBase boss, bool isFieldBoss)
	{
	}

	private void FieldBossSlowEnd()
	{
	}

	private void EndProcess()
	{
	}
}
