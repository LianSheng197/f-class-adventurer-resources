using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class LevenbergMarquardtMinimizer : NonlinearMinimizerBase
	{
		public double InitialMu
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

		public LevenbergMarquardtMinimizer(double initialMu = 0.001, double gradientTolerance = 1E-15, double stepTolerance = 1E-15, double functionTolerance = 1E-15, int maximumIterations = -1)
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

		public NonlinearMinimizationResult Minimum(IObjectiveModel objective, Vector<double> initialGuess, Vector<double> lowerBound = null, Vector<double> upperBound = null, Vector<double> scales = null, List<bool> isFixed = null, double initialMu = 0.001, double gradientTolerance = 1E-15, double stepTolerance = 1E-15, double functionTolerance = 1E-15, int maximumIterations = -1)
		{
			return null;
		}
	}
}
