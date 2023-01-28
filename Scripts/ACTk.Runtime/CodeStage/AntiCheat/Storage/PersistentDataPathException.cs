using CodeStage.AntiCheat.Common;

namespace CodeStage.AntiCheat.Storage
{
	internal class PersistentDataPathException : BackgroundThreadAccessException
	{
		public PersistentDataPathException()
			: base(null)
		{
		}
	}
}
