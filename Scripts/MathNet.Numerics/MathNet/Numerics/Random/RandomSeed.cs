using System.Security.Cryptography;

namespace MathNet.Numerics.Random
{
	public static class RandomSeed
	{
		private static readonly object Lock;

		private static readonly RandomNumberGenerator MasterRng;

		public static int Time()
		{
			return 0;
		}

		public static int Guid()
		{
			return 0;
		}

		public static int Robust()
		{
			return 0;
		}
	}
}
