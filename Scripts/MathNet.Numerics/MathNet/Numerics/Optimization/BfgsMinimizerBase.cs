using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Optimization.LineSearch;

namespace MathNet.Numerics.Optimization
{
	public abstract class BfgsMinimizerBase : MinimizerBase
	{
		protected BfgsMinimizerBase(double gradientTolerance, double parameterTolerance, double functionProgressTolerance, int maximumIterations)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		protected int DoBfgsUpdate(ref ExitCondition currentExitCondition, WolfeLineSearch lineSearcher, ref Matrix<double> inversePseudoHessian, ref Vector<double> lineSearchDirection, ref IObjectiveFunction previousPoint, ref LineSearchResult lineSearchResult, ref IObjectiveFunction candidate, ref Vector<double> step, ref int totalLineSearchSteps, ref int iterationsWithNontrivialLineSearch)
		{
			return 0;
		}

		protected abstract Vector<double> CalculateSearchDirection(ref Matrix<double> inversePseudoHessian, out double maxLineSearchStep, out double startingStepSize, IObjectiveFunction previousPoint, IObjectiveFunction candidate, Vector<double> step);
	}
}
