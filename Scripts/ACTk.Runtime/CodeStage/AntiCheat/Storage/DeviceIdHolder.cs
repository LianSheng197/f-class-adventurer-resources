using System.Runtime.CompilerServices;

namespace CodeStage.AntiCheat.Storage
{
	public class DeviceIdHolder
	{
		internal delegate byte[] HashCheckSumModifierDelegate(string input);

		private static string deviceId;

		private readonly uint deviceIdHashSeed;

		private uint deviceIdHash;

		private HashCheckSumModifierDelegate hashCheckSumModifierDelegate;

		public static string DeviceId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool MigratingFromACTkV1
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal uint DeviceIdHash => 0u;

		public static void ForceLockToDeviceInit()
		{
		}

		private static string GetDeviceId()
		{
			return null;
		}

		internal DeviceIdHolder(uint deviceIdHashSeed = 0u)
		{
		}

		internal void SetHashCheckSumModifierDelegate(HashCheckSumModifierDelegate method)
		{
		}

		internal void SetMigrationMode(bool enabled)
		{
		}

		internal void ResetHash()
		{
		}

		private uint CalculateChecksum(string input)
		{
			return 0u;
		}
	}
}
