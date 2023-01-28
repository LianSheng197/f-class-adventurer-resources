using System;

namespace MathNet.Numerics
{
	public static class Integrate
	{
		public static double OnClosedInterval(Func<double, double> f, double intervalBegin, double intervalEnd, double targetAbsoluteError)
		{
			return 0.0;
		}

		public static double OnClosedInterval(Func<double, double> f, double intervalBegin, double intervalEnd)
		{
			return 0.0;
		}

		public static double OnRectangle(Func<double, double, double> f, double invervalBeginA, double invervalEndA, double invervalBeginB, double invervalEndB, int order)
		{
			return 0.0;
		}

		public static double OnRectangle(Func<double, double, double> f, double invervalBeginA, double invervalEndA, double invervalBeginB, double invervalEndB)
		{
			return 0.0;
		}

		public static double DoubleExponential(Func<double, double> f, double intervalBegin, double intervalEnd, double targetAbsoluteError = 1E-08)
		{
			return 0.0;
		}

		public static double GaussLegendre(Func<double, double> f, double intervalBegin, double intervalEnd, int order = 128)
		{
			return 0.0;
		}

		public static double GaussKronrod(Func<double, double> f, double intervalBegin, double intervalEnd, double targetRelativeError = 1E-08, int maximumDepth = 15, int order = 15)
		{
			return 0.0;
		}

		public static double GaussKronrod(Func<double, double> f, double intervalBegin, double intervalEnd, out double error, out double L1Norm, double targetRelativeError = 1E-08, int maximumDepth = 15, int order = 15)
		{
			error = default(double);
			L1Norm = default(double);
			return 0.0;
		}
	}
}
