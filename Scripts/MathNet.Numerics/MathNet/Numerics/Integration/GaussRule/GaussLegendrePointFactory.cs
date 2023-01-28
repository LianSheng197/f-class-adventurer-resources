using System;

namespace MathNet.Numerics.Integration.GaussRule
{
	internal static class GaussLegendrePointFactory
	{
		[ThreadStatic]
		private static GaussPoint _gaussLegendrePoint;

		public static GaussPoint GetGaussPoint(int order)
		{
			return null;
		}

		public static GaussPoint GetGaussPoint(double intervalBegin, double intervalEnd, int order)
		{
			return null;
		}

		private static GaussPoint Map(double intervalBegin, double intervalEnd, GaussPoint gaussPoint)
		{
			return null;
		}
	}
}
