using System;
using MathNet.Numerics.LinearRegression;

namespace MathNet.Numerics
{
	public static class Fit
	{
		public static (double, double) Line(double[] x, double[] y)
		{
			return default((double, double));
		}

		public static Func<double, double> LineFunc(double[] x, double[] y)
		{
			return null;
		}

		public static double LineThroughOrigin(double[] x, double[] y)
		{
			return 0.0;
		}

		public static Func<double, double> LineThroughOriginFunc(double[] x, double[] y)
		{
			return null;
		}

		public static (double, double) Exponential(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return default((double, double));
		}

		public static Func<double, double> ExponentialFunc(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		public static (double, double) Logarithm(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return default((double, double));
		}

		public static Func<double, double> LogarithmFunc(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		public static (double, double) Power(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return default((double, double));
		}

		public static Func<double, double> PowerFunc(double[] x, double[] y, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		public static double[] Polynomial(double[] x, double[] y, int order, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		public static Func<double, double> PolynomialFunc(double[] x, double[] y, int order, DirectRegressionMethod method = DirectRegressionMethod.QR)
		{
			return null;
		}

		public static double[] PolynomialWeighted(double[] x, double[] y, double[] w, int order)
		{
			return null;
		}

		public static double[] LinearCombination(double[] x, double[] y, params Func<double, double>[] functions)
		{
			return null;
		}

		public static Func<double, double> LinearCombinationFunc(double[] x, double[] y, params Func<double, double>[] functions)
		{
			return null;
		}

		public static double[] LinearCombination(double[] x, double[] y, DirectRegressionMethod method, params Func<double, double>[] functions)
		{
			return null;
		}

		public static Func<double, double> LinearCombinationFunc(double[] x, double[] y, DirectRegressionMethod method, params Func<double, double>[] functions)
		{
			return null;
		}

		public static double[] MultiDim(double[][] x, double[] y, bool intercept = false, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations)
		{
			return null;
		}

		public static Func<double[], double> MultiDimFunc(double[][] x, double[] y, bool intercept = false, DirectRegressionMethod method = DirectRegressionMethod.NormalEquations)
		{
			return null;
		}

		public static double[] MultiDimWeighted(double[][] x, double[] y, double[] w)
		{
			return null;
		}

		public static double[] LinearMultiDim(double[][] x, double[] y, params Func<double[], double>[] functions)
		{
			return null;
		}

		public static Func<double[], double> LinearMultiDimFunc(double[][] x, double[] y, params Func<double[], double>[] functions)
		{
			return null;
		}

		public static double[] LinearMultiDim(double[][] x, double[] y, DirectRegressionMethod method, params Func<double[], double>[] functions)
		{
			return null;
		}

		public static Func<double[], double> LinearMultiDimFunc(double[][] x, double[] y, DirectRegressionMethod method, params Func<double[], double>[] functions)
		{
			return null;
		}

		public static double[] LinearGeneric<T>(T[] x, double[] y, params Func<T, double>[] functions)
		{
			return null;
		}

		public static Func<T, double> LinearGenericFunc<T>(T[] x, double[] y, params Func<T, double>[] functions)
		{
			return null;
		}

		public static double[] LinearGeneric<T>(T[] x, double[] y, DirectRegressionMethod method, params Func<T, double>[] functions)
		{
			return null;
		}

		public static Func<T, double> LinearGenericFunc<T>(T[] x, double[] y, DirectRegressionMethod method, params Func<T, double>[] functions)
		{
			return null;
		}

		public static double Curve(double[] x, double[] y, Func<double, double, double> f, double initialGuess, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return 0.0;
		}

		public static (double, double) Curve(double[] x, double[] y, Func<double, double, double, double> f, double initialGuess0, double initialGuess1, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double));
		}

		public static (double, double, double) Curve(double[] x, double[] y, Func<double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double));
		}

		public static (double, double, double, double) Curve(double[] x, double[] y, Func<double, double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double, double));
		}

		public static (double, double, double, double, double) Curve(double[] x, double[] y, Func<double, double, double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double initialGuess4, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return default((double, double, double, double, double));
		}

		public static Func<double, double> CurveFunc(double[] x, double[] y, Func<double, double, double> f, double initialGuess, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Func<double, double> CurveFunc(double[] x, double[] y, Func<double, double, double, double> f, double initialGuess0, double initialGuess1, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Func<double, double> CurveFunc(double[] x, double[] y, Func<double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Func<double, double> CurveFunc(double[] x, double[] y, Func<double, double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		public static Func<double, double> CurveFunc(double[] x, double[] y, Func<double, double, double, double, double, double, double> f, double initialGuess0, double initialGuess1, double initialGuess2, double initialGuess3, double initialGuess4, double tolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}
	}
}
