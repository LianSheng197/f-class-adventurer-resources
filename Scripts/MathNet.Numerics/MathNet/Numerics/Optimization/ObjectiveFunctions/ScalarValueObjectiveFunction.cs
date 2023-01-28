using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class ScalarValueObjectiveFunction : IScalarObjectiveFunction
	{
		public Func<double, double> Objective
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool IsDerivativeSupported => false;

		public bool IsSecondDerivativeSupported => false;

		public ScalarValueObjectiveFunction(Func<double, double> objective)
		{
		}

		public IScalarObjectiveFunctionEvaluation Evaluate(double point)
		{
			return null;
		}
	}
}
