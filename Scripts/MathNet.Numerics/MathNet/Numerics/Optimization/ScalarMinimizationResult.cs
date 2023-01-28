using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization
{
	public class ScalarMinimizationResult
	{
		public double MinimizingPoint => 0.0;

		public IScalarObjectiveFunctionEvaluation FunctionInfoAtMinimum
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public int Iterations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public ExitCondition ReasonForExit
		{
			[CompilerGenerated]
			get
			{
				return default(ExitCondition);
			}
		}

		public ScalarMinimizationResult(IScalarObjectiveFunctionEvaluation functionInfo, int iterations, ExitCondition reasonForExit)
		{
		}
	}
}
