using System.IO;
using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	internal struct ObscuredFileHeader
	{
		private const byte HeaderByte1 = 65;

		private const byte HeaderByte2 = 67;

		private const byte HeaderByte3 = 84;

		private const byte HeaderByte4 = 107;

		private const byte HeaderVersion = 0;

		private byte Byte1
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private byte Byte2
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private byte Byte3
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private byte Byte4
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public byte Version
		{
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public ObscurationMode ObscurationMode
		{
			[CompilerGenerated]
			readonly get
			{
				return default(ObscurationMode);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsValid()
		{
			return false;
		}

		public void ReadFrom(Stream stream)
		{
		}

		public static void WriteTo(Stream stream, ObscurationMode obscurationMode)
		{
		}
	}
}
