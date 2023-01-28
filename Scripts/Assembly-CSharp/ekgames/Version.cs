using System;

namespace ekgames
{
	[Serializable]
	public class Version
	{
		public int CLIENT_FORCED_VERSION;

		public byte CLIENT_MAJOR_VERSION;

		public byte CLIENT_MIDDLE_VERSION;

		public byte CLIENT_MINOR_VERSION;

		public uint XML_CRC;

		public uint XML_CRC_ANDROID;

		public uint XML_CRC_IOS;
	}
}
