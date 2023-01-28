using System;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.RootFinding
{
	public static class Broyden
	{
		public static double[] FindRoot(Func<double[], double[]> f, double[] initialGuess, double accuracy = 1E-08, int maxIterations = 100, double jacobianStepSize = 0.0001)
		{
			return null;
		}

		public static bool TryFindRootWithJacobianStep(Func<double[], double[]> f, double[] initialGuess, double accuracy, int maxIterations, double jacobianStepSize, out double[] root)
		{
			root = null;
			return false;
		}

		public static bool TryFindRoot(Func<double[], double[]> f, double[] initialGuess, double accuracy, int maxIterations, out double[] root)
		{
			root = null;
			return false;
		}

		private static Matrix<double> CalculateApproximateJacobian(Func<double[], double[]> f, double[] x0, double[] y0, double jacobianStepSize)
		{
			return null;
		}
	}
}
