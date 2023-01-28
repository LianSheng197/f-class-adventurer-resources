using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public class EncryptionSettings
	{
		public ObscurationMode ObscurationMode
		{
			[CompilerGenerated]
			get
			{
				return default(ObscurationMode);
			}
		}

		public byte[] Password
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EncryptionSettings(string password)
		{
		}

		public EncryptionSettings(byte[] password = null)
		{
		}
	}
}
