using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization.LineSearch
{
	public class LineSearchResult : MinimizationResult
	{
		public double FinalStep
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		public LineSearchResult(IObjectiveFunction functionInfo, int iterations, double finalStep, ExitCondition reasonForExit)
			: base(null, 0, default(ExitCondition))
		{
		}
	}
}
