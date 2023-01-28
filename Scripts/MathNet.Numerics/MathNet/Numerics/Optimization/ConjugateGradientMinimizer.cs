using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class ConjugateGradientMinimizer : IUnconstrainedMinimizer
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

		public ConjugateGradientMinimizer(double gradientTolerance, int maximumIterations)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objective, Vector<double> initialGuess)
		{
			return null;
		}

		public static MinimizationResult Minimum(IObjectiveFunction objective, Vector<double> initialGuess, double gradientTolerance = 1E-08, int maxIterations = 1000)
		{
			return null;
		}

		private static void ValidateGradient(IObjectiveFunctionEvaluation objective)
		{
		}

		private static void ValidateObjective(IObjectiveFunctionEvaluation objective)
		{
		}
	}
}
