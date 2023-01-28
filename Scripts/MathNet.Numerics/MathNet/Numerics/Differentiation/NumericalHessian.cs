using System;

namespace MathNet.Numerics.Differentiation
{
	public class NumericalHessian
	{
		private readonly NumericalDerivative _df;

		public int FunctionEvaluations => 0;

		public NumericalHessian()
		{
		}

		public NumericalHessian(int points, int center)
		{
		}

		public double[] Evaluate(Func<double, double> f, double x)
		{
			return null;
		}

		public double[,] Evaluate(Func<double[], double> f, double[] x)
		{
			return null;
		}

		public void ResetFunctionEvaluations()
		{
		}
	}
}
