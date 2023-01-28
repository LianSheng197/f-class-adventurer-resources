using System;
using System.Numerics;

namespace MathNet.Numerics
{
	public static class FindRoots
	{
		public static double OfFunction(Func<double, double> f, double lowerBound, double upperBound, double accuracy = 1E-08, int maxIterations = 100)
		{
			return 0.0;
		}

		public static double OfFunctionDerivative(Func<double, double> f, Func<double, double> df, double lowerBound, double upperBound, double accuracy = 1E-08, int maxIterations = 100)
		{
			return 0.0;
		}

		public static (Complex, Complex) Quadratic(double c, double b, double a)
		{
			return default((Complex, Complex));
		}

		public static (Complex, Complex, Complex) Cubic(double d, double c, double b, double a)
		{
			return default((Complex, Complex, Complex));
		}

		public static Complex[] Polynomial(double[] coefficients)
		{
			return null;
		}

		public static Complex[] Polynomial(Polynomial polynomial)
		{
			return null;
		}

		public static double[] ChebychevPolynomialFirstKind(int degree, double intervalBegin = -1.0, double intervalEnd = 1.0)
		{
			return null;
		}

		public static double[] ChebychevPolynomialSecondKind(int degree, double intervalBegin = -1.0, double intervalEnd = 1.0)
		{
			return null;
		}
	}
}
