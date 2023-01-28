using System;

namespace SocketIOUnity
{
	public class Packet
	{
		[Serializable]
		public class System
		{
			public string data;
		}

		[Serializable]
		public class Chat
		{
			public string name;

			public string data;
		}

		[Serializable]
		public class Pvp
		{
			public string data;
		}

		[Serializable]
		public class MoveChannel
		{
			public string prevChannel;

			public string prevGuildChannel;

			public string afterChannel;

			public string afterGuildChannel;

			public string initChannel;
		}

		[Serializable]
		public class KickGuildUser
		{
			public string kickUserName;

			public string data;
		}
	}
}
