using System;

namespace MathNet.Numerics.RootFinding
{
	public static class Bisection
	{
		public static double FindRootExpand(Func<double, double> f, double guessLowerBound, double guessUpperBound, double accuracy = 1E-08, int maxIterations = 100, double expandFactor = 1.6, int maxExpandIteratons = 100)
		{
			return 0.0;
		}

		public static double FindRoot(Func<double, double> f, double lowerBound, double upperBound, double accuracy = 1E-14, int maxIterations = 100)
		{
			return 0.0;
		}

		public static bool TryFindRoot(Func<double, double> f, double lowerBound, double upperBound, double accuracy, int maxIterations, out double root)
		{
			root = default(double);
			return false;
		}
	}
}
