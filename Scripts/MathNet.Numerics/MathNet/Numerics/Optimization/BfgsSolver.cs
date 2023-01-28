using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MathNet.Numerics.Optimization
{
	public static class BfgsSolver
	{
		private const double GradientTolerance = 1E-05;

		private const int MaxIterations = 100000;

		public static Vector<double> Solve(Vector initialGuess, Func<Vector<double>, double> functionValue, Func<Vector<double>, Vector<double>> functionGradient)
		{
			return null;
		}
	}
}
