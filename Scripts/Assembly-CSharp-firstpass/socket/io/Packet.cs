namespace socket.io
{
	public class Packet
	{
		public EnginePacketTypes enginePktType;

		public SocketPacketTypes socketPktType;

		public int id;

		public string nsp;

		public string body;

		public static string Ping => null;

		public static string Pong => null;

		public static string Probe => null;

		public static string ProbeAnswer => null;

		public bool IsMessage => false;

		public bool IsBinary => false;

		public bool HasNamespace => false;

		public bool HasId => false;

		public bool HasBody => false;

		public override string ToString()
		{
			return null;
		}

		public Packet(EnginePacketTypes enginePktType, SocketPacketTypes socketPktType, int id, string nsp, string json)
		{
		}

		public Packet(EnginePacketTypes enginePktType, SocketPacketTypes socketPktType, string nsp, string json)
		{
		}

		public Packet(EnginePacketTypes enginePktType, SocketPacketTypes socketPktType, string json)
		{
		}

		public Packet(EnginePacketTypes enginePktType, SocketPacketTypes socketPktType)
		{
		}

		public Packet(EnginePacketTypes enginePktType)
		{
		}

		public Packet()
		{
		}
	}
}
