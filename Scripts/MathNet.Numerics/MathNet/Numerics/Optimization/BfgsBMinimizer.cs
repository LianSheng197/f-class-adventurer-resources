using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class BfgsBMinimizer : BfgsMinimizerBase
	{
		private Vector<double> _lowerBound;

		private Vector<double> _upperBound;

		public BfgsBMinimizer(double gradientTolerance, double parameterTolerance, double functionProgressTolerance, int maximumIterations = 1000)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objective, Vector<double> lowerBound, Vector<double> upperBound, Vector<double> initialGuess)
		{
			return null;
		}

		protected override Vector<double> CalculateSearchDirection(ref Matrix<double> pseudoHessian, out double maxLineSearchStep, out double startingStepSize, IObjectiveFunction previousPoint, IObjectiveFunction candidatePoint, Vector<double> step)
		{
			maxLineSearchStep = default(double);
			startingStepSize = default(double);
			return null;
		}

		private static Vector<double> ReducedToFull(List<int> reducedMap, Vector<double> reducedVector, Vector<double> fullVector)
		{
			return null;
		}

		private static double FindMaxStep(Vector<double> startingPoint, Vector<double> searchDirection, Vector<double> lowerBound, Vector<double> upperBound)
		{
			return 0.0;
		}

		private static void CreateReducedData(Vector<double> initialPoint, Vector<double> cauchyPoint, List<bool> isFixed, Vector<double> lowerBound, Vector<double> upperBound, Vector<double> gradient, Matrix<double> pseudoHessian, Vector<double> reducedInitialPoint, Vector<double> reducedCauchyPoint, Vector<double> reducedGradient, Matrix<double> reducedHessian, List<int> reducedMap)
		{
		}

		protected override double GetProjectedGradient(IObjectiveFunctionEvaluation candidatePoint, int ii)
		{
			return 0.0;
		}
	}
}
