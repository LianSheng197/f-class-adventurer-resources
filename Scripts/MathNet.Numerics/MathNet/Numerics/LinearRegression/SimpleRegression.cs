using System;
using System.Collections.Generic;

namespace MathNet.Numerics.LinearRegression
{
	public static class SimpleRegression
	{
		public static (double, double) Fit(double[] x, double[] y)
		{
			return default((double, double));
		}

		public static (double, double) Fit(IEnumerable<Tuple<double, double>> samples)
		{
			return default((double, double));
		}

		public static (double, double) Fit(IEnumerable<(double, double)> samples)
		{
			return default((double, double));
		}

		public static double FitThroughOrigin(double[] x, double[] y)
		{
			return 0.0;
		}

		public static double FitThroughOrigin(IEnumerable<Tuple<double, double>> samples)
		{
			return 0.0;
		}
	}
}
