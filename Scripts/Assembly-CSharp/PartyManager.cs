using System.Collections.Generic;

public class PartyManager
{
	private static PartyManager _Instance;

	private Dictionary<int, Party> _partyList;

	private double _criticalPercentage;

	private double _criticalDamage;

	private double _critical2Percentage;

	private double _critical2Damage;

	private double _critical3Percentage;

	private double _critical3Damage;

	private double _minDamage;

	private double _maxDamage;

	private double _attackValue;

	private double _attackValue2;

	private double _defenceValue;

	private double _defenceValue2;

	private double _defenceGrowValue;

	private double _defenceGrowValue2;

	private double _hpRegain;

	private double _hpRegainMaxPercentage;

	private double _hpMonsterKillRegain;

	private double _hpMonsterKillRegainMaxPercentage;

	private double _mpRegain;

	private double _mpRegainMaxPercentage;

	private double _mpMonsterKillRegain;

	private double _mpMonsterKillRegainMaxPercentage;

	private double _battlepoint_HpValue;

	private double _battlepoint_MpValue1;

	private double _battlepoint_MpValue2;

	public static PartyManager Instance => null;

	public void Init()
	{
	}

	public void SetParty(List<Party> partyList)
	{
	}

	public void SetParty(Party party)
	{
	}

	public Party GetParty(int slot)
	{
		return null;
	}

	public int GetPartyPlayer(int slot)
	{
		return 0;
	}

	public Party GetCurrentParty()
	{
		return null;
	}

	public int GetCurrentPartySlot()
	{
		return 0;
	}

	public double GetCurrentPartyBattleStat()
	{
		return 0.0;
	}

	public double GetBattlePointAttack()
	{
		return 0.0;
	}

	public double GetBattlePointDefence()
	{
		return 0.0;
	}

	public double GetBattlePointMagic()
	{
		return 0.0;
	}

	public Character GetCurrentPartyBattleCharacter()
	{
		return null;
	}
}
