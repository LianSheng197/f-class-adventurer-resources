using System;

namespace MathNet.Numerics.RootFinding
{
	public static class RobustNewtonRaphson
	{
		public static double FindRoot(Func<double, double> f, Func<double, double> df, double lowerBound, double upperBound, double accuracy = 1E-08, int maxIterations = 100, int subdivision = 20)
		{
			return 0.0;
		}

		public static bool TryFindRoot(Func<double, double> f, Func<double, double> df, double lowerBound, double upperBound, double accuracy, int maxIterations, int subdivision, out double root)
		{
			root = default(double);
			return false;
		}

		private static bool TryScanForCrossingsWithRoots(Func<double, double> f, Func<double, double> df, double lowerBound, double upperBound, double accuracy, int maxIterations, int subdivision, out double root)
		{
			root = default(double);
			return false;
		}
	}
}
