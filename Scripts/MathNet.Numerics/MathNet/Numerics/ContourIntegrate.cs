using System;
using System.Numerics;

namespace MathNet.Numerics
{
	public static class ContourIntegrate
	{
		public static Complex DoubleExponential(Func<double, Complex> f, double intervalBegin, double intervalEnd, double targetAbsoluteError = 1E-08)
		{
			return default(Complex);
		}

		public static Complex GaussLegendre(Func<double, Complex> f, double intervalBegin, double intervalEnd, int order = 128)
		{
			return default(Complex);
		}

		public static Complex GaussKronrod(Func<double, Complex> f, double intervalBegin, double intervalEnd, double targetRelativeError = 1E-08, int maximumDepth = 15, int order = 15)
		{
			return default(Complex);
		}

		public static Complex GaussKronrod(Func<double, Complex> f, double intervalBegin, double intervalEnd, out double error, out double L1Norm, double targetRelativeError = 1E-08, int maximumDepth = 15, int order = 15)
		{
			error = default(double);
			L1Norm = default(double);
			return default(Complex);
		}
	}
}
