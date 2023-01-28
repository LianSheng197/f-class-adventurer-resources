using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public class DeviceLockSettings
	{
		public DeviceLockLevel Level
		{
			[CompilerGenerated]
			get
			{
				return default(DeviceLockLevel);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DeviceLockTamperingSensitivity Sensitivity
		{
			[CompilerGenerated]
			get
			{
				return default(DeviceLockTamperingSensitivity);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public DeviceLockSettings(DeviceLockLevel level = DeviceLockLevel.None, DeviceLockTamperingSensitivity sensitivity = DeviceLockTamperingSensitivity.Normal)
		{
		}
	}
}
