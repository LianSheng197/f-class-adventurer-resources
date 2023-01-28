namespace MathNet.Numerics.Optimization.LineSearch
{
	public class StrongWolfeLineSearch : WolfeLineSearch
	{
		protected override ExitCondition WolfeExitCondition => default(ExitCondition);

		public StrongWolfeLineSearch(double c1, double c2, double parameterTolerance, int maxIterations = 10)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		protected override bool WolfeCondition(double stepDd, double initialDd)
		{
			return false;
		}
	}
}
