using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class ScalarObjectiveFunction : IScalarObjectiveFunction
	{
		public Func<double, double> Objective
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<double, double> Derivative
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Func<double, double> SecondDerivative
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsDerivativeSupported => false;

		public bool IsSecondDerivativeSupported => false;

		public ScalarObjectiveFunction(Func<double, double> objective)
		{
		}

		public ScalarObjectiveFunction(Func<double, double> objective, Func<double, double> derivative)
		{
		}

		public ScalarObjectiveFunction(Func<double, double> objective, Func<double, double> derivative, Func<double, double> secondDerivative)
		{
		}

		public IScalarObjectiveFunctionEvaluation Evaluate(double point)
		{
			return null;
		}
	}
}
