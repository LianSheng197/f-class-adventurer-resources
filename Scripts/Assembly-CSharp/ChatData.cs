using System;
using System.Collections.Generic;

[Serializable]
public class ChatData
{
	public enum eOwnerType
	{
		otherUser = 0,
		my = 1,
		system = 2
	}

	public enum ConditionValue
	{
		normal = 0,
		userName = 1,
		userCode = 2,
		honorName = 3,
		guildName = 4,
		rank = 5
	}

	public string _constString;

	public int _type;

	public string _channel;

	public bool _bForced;

	public bool _bByServer;

	public int _designChatId;

	public string _guildId;

	public Dictionary<int, string> _conditionValue;

	public ChatData(string channel, string userName, string userCode, long rank, int chatId, string guidId)
	{
	}

	public ChatData()
	{
	}

	public bool IsBBCode()
	{
		return false;
	}

	public eOwnerType GetOwnerType()
	{
		return default(eOwnerType);
	}

	public string GetMsg()
	{
		return null;
	}

	public void SetConditionString(ConditionValue conditionKey, string value)
	{
	}

	public string GetConditionString(int conditionKey)
	{
		return null;
	}

	public bool CheckChatData(int curTab)
	{
		return false;
	}
}
