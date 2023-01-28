using CodeStage.AntiCheat.Common;

namespace CodeStage.AntiCheat.Storage
{
	internal class DeviceUniqueIdentifierException : BackgroundThreadAccessException
	{
		public DeviceUniqueIdentifierException()
			: base(null)
		{
		}
	}
}
