using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class MinimizationResult
	{
		public Vector<double> MinimizingPoint => null;

		public IObjectiveFunction FunctionInfoAtMinimum
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

		public MinimizationResult(IObjectiveFunction functionInfo, int iterations, ExitCondition reasonForExit)
		{
		}
	}
}
