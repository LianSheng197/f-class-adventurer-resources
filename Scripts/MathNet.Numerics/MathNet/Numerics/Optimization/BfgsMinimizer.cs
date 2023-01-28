using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class BfgsMinimizer : BfgsMinimizerBase, IUnconstrainedMinimizer
	{
		public BfgsMinimizer(double gradientTolerance, double parameterTolerance, double functionProgressTolerance, int maximumIterations = 1000)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objective, Vector<double> initialGuess)
		{
			return null;
		}

		protected override Vector<double> CalculateSearchDirection(ref Matrix<double> inversePseudoHessian, out double maxLineSearchStep, out double startingStepSize, IObjectiveFunction previousPoint, IObjectiveFunction candidate, Vector<double> step)
		{
			maxLineSearchStep = default(double);
			startingStepSize = default(double);
			return null;
		}
	}
}
