using System;
using Newtonsoft.Json;

[Serializable]
public class CUser
{
	[JsonProperty]
	public readonly int _id;

	[JsonProperty]
	public readonly DateTime _createTime;

	[JsonProperty]
	public readonly int _level;

	[JsonProperty]
	public readonly long _exp;

	[JsonProperty]
	public readonly string _name;

	[JsonProperty]
	public readonly int _itemInvenMax;

	[JsonProperty]
	public readonly int _charInvenMax;

	[JsonProperty]
	public readonly int _partySlot;

	[JsonProperty]
	public readonly bool _isCreated;

	[JsonProperty]
	public readonly DateTime _prevConnectTime;

	[JsonProperty]
	public readonly DateTime _lastConnectTime;

	private static int _prevLevel;

	private static DesignTeamLevel.Data _designTL;

	public CUser()
	{
	}

	public CUser(CUser user, long exp)
	{
	}

	public CUser(int id, DateTime createTime, int level, long exp, string name, int itemInvenMax, int charInvenMax, int partySlot, DateTime prevConnectTime, DateTime lastConnectTime, bool isCreated = false)
	{
	}

	public void UpdateUI()
	{
	}

	public void SetData(ref CUser owner, CUser ack)
	{
	}

	public DesignTeamLevel.Data GetTeamLevel()
	{
		return null;
	}

	public string GetUserCode()
	{
		return null;
	}
}
