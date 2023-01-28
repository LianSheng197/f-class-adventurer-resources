using System;
using System.Numerics;
using MathNet.Numerics.Integration.GaussRule;

namespace MathNet.Numerics.Integration
{
	public class GaussKronrodRule
	{
		private readonly GaussPointPair _gaussKronrodPoint;

		public int Order => 0;

		public double[] KronrodAbscissas => null;

		public double[] KronrodWeights => null;

		public double[] GaussWeights => null;

		public GaussKronrodRule(int order)
		{
		}

		public static double Integrate(Func<double, double> f, double intervalBegin, double intervalEnd, out double error, out double L1Norm, double targetRelativeError = 1E-10, int maximumDepth = 15, int order = 15)
		{
			error = default(double);
			L1Norm = default(double);
			return 0.0;
		}

		public static Complex ContourIntegrate(Func<double, Complex> f, double intervalBegin, double intervalEnd, out double error, out double L1Norm, double targetRelativeError = 1E-10, int maximumDepth = 15, int order = 15)
		{
			error = default(double);
			L1Norm = default(double);
			return default(Complex);
		}

		private static double integrate_non_adaptive_m1_1(Func<double, double> f, out double error, out double pL1, GaussPointPair gaussKronrodPoint)
		{
			error = default(double);
			pL1 = default(double);
			return 0.0;
		}

		private static Complex contour_integrate_non_adaptive_m1_1(Func<double, Complex> f, out double error, out double pL1, GaussPointPair gaussKronrodPoint)
		{
			error = default(double);
			pL1 = default(double);
			return default(Complex);
		}

		private static double recursive_adaptive_integrate(Func<double, double> f, double a, double b, int maxLevels, double relTol, double absTol, out double error, out double L1, GaussPointPair gaussKronrodPoint)
		{
			error = default(double);
			L1 = default(double);
			return 0.0;
		}

		private static Complex contour_recursive_adaptive_integrate(Func<double, Complex> f, double a, double b, int maxLevels, double relTol, double absTol, out double error, out double L1, GaussPointPair gaussKronrodPoint)
		{
			error = default(double);
			L1 = default(double);
			return default(Complex);
		}
	}
}
