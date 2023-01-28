using System;

[Serializable]
public class BlockInfo
{
	public enum eType
	{
		NONE = 0,
		SERVER_MAINTERNANCE = 1,
		INVALID_CLIENT_FOCED_VERSION = 2,
		INVALID_XML_VERSION = 3,
		INVALID_CLIENT_MAJOR_VERSION = 4,
		INVALID_CLIENT_MIDDLE_VERSION = 5,
		INVALID_CLIENT_MINOR_VERSION = 6,
		USER_BLOCK = 7,
		USER_KICK = 8,
		USER_KICK_DEVICE = 9,
		SIZE = 10
	}

	public eType _type;

	public string _reason;

	public DateTime _dueDate;
}
