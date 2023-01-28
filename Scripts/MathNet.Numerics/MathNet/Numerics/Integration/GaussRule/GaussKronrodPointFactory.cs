using System;

namespace MathNet.Numerics.Integration.GaussRule
{
	internal static class GaussKronrodPointFactory
	{
		[ThreadStatic]
		private static GaussPointPair _gaussKronrodPoint;

		public static GaussPointPair GetGaussPoint(int order)
		{
			return null;
		}
	}
}
