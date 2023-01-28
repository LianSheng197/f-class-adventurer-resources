using System;
using System.Reflection;

namespace MathNet.Numerics
{
	[Serializable]
	[DefaultMember("Item")]
	public class Permutation
	{
		private readonly int[] _indices;

		public int Dimension => 0;

		public int Item => 0;

		public Permutation(int[] indices)
		{
		}

		public Permutation Inverse()
		{
			return null;
		}

		public static Permutation FromInversions(int[] inv)
		{
			return null;
		}

		public int[] ToInversions()
		{
			return null;
		}

		private static bool CheckForProperPermutation(int[] indices)
		{
			return false;
		}
	}
}
