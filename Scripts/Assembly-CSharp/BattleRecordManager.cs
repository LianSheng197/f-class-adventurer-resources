public class BattleRecordManager
{
	public enum State
	{
		Reward = 0,
		Damage = 1
	}

	private static BattleRecordManager _Instance;

	public bool _isShow;

	public State _state;

	public BattleRewardRecord _rewardRecord;

	public BattleDamageRecord _damageRecord;

	public BattleKillRecord _killRecord;

	public static BattleRecordManager Instance => null;
}
