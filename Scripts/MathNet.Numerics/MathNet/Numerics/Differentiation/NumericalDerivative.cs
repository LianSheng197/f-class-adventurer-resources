using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Differentiation
{
	public class NumericalDerivative
	{
		private readonly int _points;

		private int _center;

		private double _stepSize;

		private double _epsilon;

		private double _baseStepSize;

		private readonly FiniteDifferenceCoefficients _coefficients;

		public double StepSize
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double BaseStepSize
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double Epsilon
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public int Center
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Evaluations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StepType StepType
		{
			[CompilerGenerated]
			get
			{
				return default(StepType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public NumericalDerivative()
		{
		}

		public NumericalDerivative(int points, int center)
		{
		}

		public double EvaluateDerivative(double[] points, int order, double stepSize)
		{
			return 0.0;
		}

		public double EvaluateDerivative(Func<double, double> f, double x, int order, double? currentValue = null)
		{
			return 0.0;
		}

		public Func<double, double> CreateDerivativeFunctionHandle(Func<double, double> f, int order)
		{
			return null;
		}

		public double EvaluatePartialDerivative(Func<double[], double> f, double[] x, int parameterIndex, int order, double? currentValue = null)
		{
			return 0.0;
		}

		public double[] EvaluatePartialDerivative(Func<double[], double>[] f, double[] x, int parameterIndex, int order, double?[] currentValue = null)
		{
			return null;
		}

		public Func<double[], double> CreatePartialDerivativeFunctionHandle(Func<double[], double> f, int parameterIndex, int order)
		{
			return null;
		}

		public Func<double[], double[]> CreatePartialDerivativeFunctionHandle(Func<double[], double>[] f, int parameterIndex, int order)
		{
			return null;
		}

		public double EvaluateMixedPartialDerivative(Func<double[], double> f, double[] x, int[] parameterIndex, int order, double? currentValue = null)
		{
			return 0.0;
		}

		public double[] EvaluateMixedPartialDerivative(Func<double[], double>[] f, double[] x, int[] parameterIndex, int order, double?[] currentValue = null)
		{
			return null;
		}

		public Func<double[], double> CreateMixedPartialDerivativeFunctionHandle(Func<double[], double> f, int[] parameterIndex, int order)
		{
			return null;
		}

		public Func<double[], double[]> CreateMixedPartialDerivativeFunctionHandle(Func<double[], double>[] f, int[] parameterIndex, int order)
		{
			return null;
		}

		public void ResetEvaluations()
		{
		}

		private double CalculateStepSize(int points, double x, double order)
		{
			return 0.0;
		}
	}
}
