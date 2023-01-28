using System;
using MathNet.Numerics.Differentiation;

namespace MathNet.Numerics
{
	public static class Differentiate
	{
		public static NumericalDerivative Points(int points, int center)
		{
			return null;
		}

		public static NumericalDerivative Order(int order)
		{
			return null;
		}

		public static double Derivative(Func<double, double> f, double x, int order)
		{
			return 0.0;
		}

		public static Func<double, double> DerivativeFunc(Func<double, double> f, int order)
		{
			return null;
		}

		public static double FirstDerivative(Func<double, double> f, double x)
		{
			return 0.0;
		}

		public static Func<double, double> FirstDerivativeFunc(Func<double, double> f)
		{
			return null;
		}

		public static double SecondDerivative(Func<double, double> f, double x)
		{
			return 0.0;
		}

		public static Func<double, double> SecondDerivativeFunc(Func<double, double> f)
		{
			return null;
		}

		public static double PartialDerivative(Func<double[], double> f, double[] x, int parameterIndex, int order)
		{
			return 0.0;
		}

		public static Func<double[], double> PartialDerivativeFunc(Func<double[], double> f, int parameterIndex, int order)
		{
			return null;
		}

		public static double FirstPartialDerivative(Func<double[], double> f, double[] x, int parameterIndex)
		{
			return 0.0;
		}

		public static Func<double[], double> FirstPartialDerivativeFunc(Func<double[], double> f, int parameterIndex)
		{
			return null;
		}

		public static double PartialDerivative2(Func<double, double, double> f, double x, double y, int parameterIndex, int order)
		{
			return 0.0;
		}

		public static Func<double, double, double> PartialDerivative2Func(Func<double, double, double> f, int parameterIndex, int order)
		{
			return null;
		}

		public static double FirstPartialDerivative2(Func<double, double, double> f, double x, double y, int parameterIndex)
		{
			return 0.0;
		}

		public static Func<double, double, double> FirstPartialDerivative2Func(Func<double, double, double> f, int parameterIndex)
		{
			return null;
		}
	}
}
