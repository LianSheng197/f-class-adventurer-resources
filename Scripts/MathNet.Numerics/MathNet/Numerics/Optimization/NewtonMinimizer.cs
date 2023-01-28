using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public sealed class NewtonMinimizer : IUnconstrainedMinimizer
	{
		public double GradientTolerance
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

		public int MaximumIterations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool UseLineSearch
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public NewtonMinimizer(double gradientTolerance, int maximumIterations, bool useLineSearch = false)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objective, Vector<double> initialGuess)
		{
			return null;
		}

		public static MinimizationResult Minimum(IObjectiveFunction objective, Vector<double> initialGuess, double gradientTolerance = 1E-08, int maxIterations = 1000, bool useLineSearch = false)
		{
			return null;
		}

		private static void ValidateGradient(IObjectiveFunctionEvaluation eval)
		{
		}

		private static void ValidateHessian(IObjectiveFunctionEvaluation eval)
		{
		}
	}
}
