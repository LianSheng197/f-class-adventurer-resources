namespace socket.io
{
	public enum EnginePacketTypes
	{
		UNKNOWN = -1,
		OPEN = 0,
		CLOSE = 1,
		PING = 2,
		PONG = 3,
		MESSAGE = 4,
		UPGRADE = 5,
		NOOP = 6
	}
}
