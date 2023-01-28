using System;
using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization
{
	public class EvaluationException : OptimizationException
	{
		public IObjectiveFunctionEvaluation ObjectiveFunction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public EvaluationException(string message, IObjectiveFunctionEvaluation eval)
			: base(null)
		{
		}

		public EvaluationException(string message, IObjectiveFunctionEvaluation eval, Exception innerException)
			: base(null)
		{
		}
	}
}
