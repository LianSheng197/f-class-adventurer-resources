using System;
using System.Numerics;

namespace MathNet.Numerics.Integration
{
	public static class DoubleExponentialTransformation
	{
		private const int NumberOfMaximumLevels = 10;

		private static readonly double[][] PrecomputedAbscissas;

		private static readonly double[][] PrecomputedWeights;

		public static double Integrate(Func<double, double> f, double intervalBegin, double intervalEnd, double targetRelativeError)
		{
			return 0.0;
		}

		public static Complex ContourIntegrate(Func<double, Complex> f, double intervalBegin, double intervalEnd, double targetRelativeError)
		{
			return default(Complex);
		}

		private static double[] EvaluateAbcissas(int level)
		{
			return null;
		}

		private static double[] EvaluateWeights(int level)
		{
			return null;
		}
	}
}
