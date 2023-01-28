using System;

namespace MathNet.Numerics.RootFinding
{
	public static class Secant
	{
		public static double FindRoot(Func<double, double> f, double guess, double secondGuess, double lowerBound = double.MinValue, double upperBound = double.MaxValue, double accuracy = 1E-08, int maxIterations = 100)
		{
			return 0.0;
		}

		public static bool TryFindRoot(Func<double, double> f, double guess, double secondGuess, double lowerBound, double upperBound, double accuracy, int maxIterations, out double root)
		{
			root = default(double);
			return false;
		}
	}
}
