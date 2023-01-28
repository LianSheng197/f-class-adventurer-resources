using System;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics
{
	public static class FindMinimum
	{
		public static double OfScalarFunctionConstrained(Func<double, double> function, double lowerBound, double upperBound, double tolerance = 1E-05, int maxIterations = 1000)
		{
			return 0.0;
		}

		public static double OfScalarFunction(Func<double, double> function, double initialGuess, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return 0.0;
		}

		public static (double, double) OfFunction(Func<double, double, double> function, double initialGuess0, double initialGuess1, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double));
		}

		public static (double, double, double) OfFunction(Func<double, double, double, double> function, double initialGuess0, double initialGuess1, double initialGuess2, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double));
		}

		public static (double, double, double, double) OfFunction(Func<double, double, double, double, double> function, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double, double));
		}

		public static (double, double, double, double, double) OfFunction(Func<double, double, double, double, double, double> function, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double initialGuess4, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double, double, double));
		}

		public static Vector<double> OfFunction(Func<Vector<double>, double> function, Vector<double> initialGuess, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionConstrained(Func<Vector<double>, double> function, Vector<double> lowerBound, Vector<double> upperBound, Vector<double> initialGuess, double gradientTolerance = 1E-05, double parameterTolerance = 1E-05, double functionProgressTolerance = 1E-05, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradient(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient, Vector<double> initialGuess, double gradientTolerance = 1E-05, double parameterTolerance = 1E-05, double functionProgressTolerance = 1E-05, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradient(Func<Vector<double>, (double, Vector<double>)> functionGradient, Vector<double> initialGuess, double gradientTolerance = 1E-05, double parameterTolerance = 1E-05, double functionProgressTolerance = 1E-05, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradientConstrained(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient, Vector<double> lowerBound, Vector<double> upperBound, Vector<double> initialGuess, double gradientTolerance = 1E-05, double parameterTolerance = 1E-05, double functionProgressTolerance = 1E-05, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradientConstrained(Func<Vector<double>, (double, Vector<double>)> functionGradient, Vector<double> lowerBound, Vector<double> upperBound, Vector<double> initialGuess, double gradientTolerance = 1E-05, double parameterTolerance = 1E-05, double functionProgressTolerance = 1E-05, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradientHessian(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient, Func<Vector<double>, Matrix<double>> hessian, Vector<double> initialGuess, double gradientTolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Vector<double> OfFunctionGradientHessian(Func<Vector<double>, (double, Vector<double>, Matrix<double>)> functionGradientHessian, Vector<double> initialGuess, double gradientTolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}
	}
}
