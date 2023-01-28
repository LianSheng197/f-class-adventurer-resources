using System.Collections.Generic;

namespace MathNet.Numerics.Integration.GaussRule
{
	internal static class GaussKronrodPoint
	{
		internal static readonly Dictionary<int, GaussPointPair> PreComputed;

		internal static GaussPointPair Generate(int order, double eps)
		{
			return null;
		}

		private static double[] StieltjesP(int order)
		{
			return null;
		}

		private static (double, double) LegendreSeries(double[] a, double x)
		{
			return default((double, double));
		}

		private static (double, double) LegendreP(int order, double x)
		{
			return default((double, double));
		}
	}
}
