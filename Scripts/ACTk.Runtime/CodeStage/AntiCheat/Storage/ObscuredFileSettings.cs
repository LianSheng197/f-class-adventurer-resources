using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public class ObscuredFileSettings
	{
		public ObscuredFileLocation LocationKind
		{
			[CompilerGenerated]
			get
			{
				return default(ObscuredFileLocation);
			}
		}

		public EncryptionSettings EncryptionSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public DeviceLockSettings DeviceLockSettings
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool ValidateDataIntegrity
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ObscuredFileSettings()
		{
		}

		public ObscuredFileSettings(ObscuredFileLocation locationKind)
		{
		}

		public ObscuredFileSettings(DeviceLockSettings deviceLockSettings)
		{
		}

		public ObscuredFileSettings(EncryptionSettings encryptionSettings, DeviceLockSettings deviceLockSettings, ObscuredFileLocation locationKind = ObscuredFileLocation.PersistentData, bool validateDataIntegrity = true)
		{
		}
	}
}
