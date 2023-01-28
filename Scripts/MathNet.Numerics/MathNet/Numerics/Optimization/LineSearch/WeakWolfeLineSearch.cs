using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.LineSearch
{
	public class WeakWolfeLineSearch : WolfeLineSearch
	{
		protected override ExitCondition WolfeExitCondition => default(ExitCondition);

		public WeakWolfeLineSearch(double c1, double c2, double parameterTolerance, int maxIterations = 10)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		protected override bool WolfeCondition(double stepDd, double initialDd)
		{
			return false;
		}

		protected override void ValidateValue(IObjectiveFunctionEvaluation eval)
		{
		}

		protected override void ValidateInputArguments(IObjectiveFunctionEvaluation startingPoint, Vector<double> searchDirection, double initialStep, double upperBound)
		{
		}

		protected override void ValidateGradient(IObjectiveFunctionEvaluation eval)
		{
		}

		private static bool IsFinite(double x)
		{
			return false;
		}
	}
}
