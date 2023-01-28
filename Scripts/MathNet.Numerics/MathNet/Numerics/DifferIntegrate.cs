using System;

namespace MathNet.Numerics
{
	public static class DifferIntegrate
	{
		public static double DoubleExponential(Func<double, double> f, double x, double order, double x0 = 0.0, double targetAbsoluteError = 1E-10)
		{
			return 0.0;
		}

		public static double GaussLegendre(Func<double, double> f, double x, double order, double x0 = 0.0, int gaussLegendrePoints = 128)
		{
			return 0.0;
		}

		public static double GaussKronrod(Func<double, double> f, double x, double order, double x0 = 0.0, double targetRelativeError = 1E-10, int gaussKronrodPoints = 15)
		{
			return 0.0;
		}
	}
}
