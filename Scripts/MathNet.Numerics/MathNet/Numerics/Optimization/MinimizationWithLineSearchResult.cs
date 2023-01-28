using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization
{
	public class MinimizationWithLineSearchResult : MinimizationResult
	{
		public int TotalLineSearchIterations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public int IterationsWithNonTrivialLineSearch
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public MinimizationWithLineSearchResult(IObjectiveFunction functionInfo, int iterations, ExitCondition reasonForExit, int totalLineSearchIterations, int iterationsWithNonTrivialLineSearch)
			: base(null, 0, default(ExitCondition))
		{
		}
	}
}
