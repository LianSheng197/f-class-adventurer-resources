using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.TrustRegion
{
	public abstract class TrustRegionMinimizerBase : NonlinearMinimizerBase
	{
		public ITrustRegionSubproblem Subproblem;

		public double RadiusTolerance
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TrustRegionMinimizerBase(ITrustRegionSubproblem subproblem, double gradientTolerance = 1E-08, double stepTolerance = 1E-08, double functionTolerance = 1E-08, double radiusTolerance = 1E-08, int maximumIterations = -1)
			: base(0.0, 0.0, 0.0, 0)
		{
		}

		public NonlinearMinimizationResult FindMinimum(IObjectiveModel objective, Vector<double> initialGuess, Vector<double> lowerBound = null, Vector<double> upperBound = null, Vector<double> scales = null, List<bool> isFixed = null)
		{
			return null;
		}

		public NonlinearMinimizationResult FindMinimum(IObjectiveModel objective, double[] initialGuess, double[] lowerBound = null, double[] upperBound = null, double[] scales = null, bool[] isFixed = null)
		{
			return null;
		}

		public NonlinearMinimizationResult Minimum(ITrustRegionSubproblem subproblem, IObjectiveModel objective, Vector<double> initialGuess, Vector<double> lowerBound = null, Vector<double> upperBound = null, Vector<double> scales = null, List<bool> isFixed = null, double gradientTolerance = 1E-08, double stepTolerance = 1E-08, double functionTolerance = 1E-08, double radiusTolerance = 1E-18, int maximumIterations = -1)
		{
			return null;
		}
	}
}
