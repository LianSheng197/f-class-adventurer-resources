using System;

namespace MathNet.Numerics.Differentiation
{
	public class NumericalJacobian
	{
		private readonly NumericalDerivative _df;

		public int FunctionEvaluations => 0;

		public NumericalJacobian()
		{
		}

		public NumericalJacobian(int points, int center)
		{
		}

		public double[] Evaluate(Func<double, double> f, double x)
		{
			return null;
		}

		public double[] Evaluate(Func<double[], double> f, double[] x)
		{
			return null;
		}

		public double[] Evaluate(Func<double[], double> f, double[] x, double currentValue)
		{
			return null;
		}

		public double[,] Evaluate(Func<double[], double>[] f, double[] x)
		{
			return null;
		}

		public double[,] Evaluate(Func<double[], double>[] f, double[] x, double[] currentValues)
		{
			return null;
		}

		public void ResetFunctionEvaluations()
		{
		}
	}
}
