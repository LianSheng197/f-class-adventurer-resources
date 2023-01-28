using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public sealed class NelderMeadSimplex : IUnconstrainedMinimizer
	{
		private sealed class SimplexConstant
		{
			public double Value
			{
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
			}

			public double InitialPerturbation
			{
				[CompilerGenerated]
				get
				{
					return 0.0;
				}
			}

			private SimplexConstant(double value, double initialPerturbation)
			{
			}

			public static SimplexConstant[] CreateSimplexConstantsFromVectors(Vector<double> initialGuess, Vector<double> initialPertubation)
			{
				return null;
			}
		}

		private sealed class ErrorProfile
		{
			public int HighestIndex
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

			public int NextHighestIndex
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

			public int LowestIndex
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
		}

		private static readonly double JITTER;

		public double ConvergenceTolerance
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

		public NelderMeadSimplex(double convergenceTolerance, int maximumIterations)
		{
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objectiveFunction, Vector<double> initialGuess)
		{
			return null;
		}

		public MinimizationResult FindMinimum(IObjectiveFunction objectiveFunction, Vector<double> initialGuess, Vector<double> initalPertubation)
		{
			return null;
		}

		public static MinimizationResult Minimum(IObjectiveFunction objectiveFunction, Vector<double> initialGuess, double convergenceTolerance = 1E-08, int maximumIterations = 1000)
		{
			return null;
		}

		public static MinimizationResult Minimum(IObjectiveFunction objectiveFunction, Vector<double> initialGuess, Vector<double> initalPertubation, double convergenceTolerance = 1E-08, int maximumIterations = 1000)
		{
			return null;
		}

		private static double[] InitializeErrorValues(Vector<double>[] vertices, IObjectiveFunction objectiveFunction)
		{
			return null;
		}

		private static bool HasConverged(double convergenceTolerance, ErrorProfile errorProfile, double[] errorValues)
		{
			return false;
		}

		private static ErrorProfile EvaluateSimplex(double[] errorValues)
		{
			return null;
		}

		private static Vector<double>[] InitializeVertices(SimplexConstant[] simplexConstants)
		{
			return null;
		}

		private static double TryToScaleSimplex(double scaleFactor, ref ErrorProfile errorProfile, Vector<double>[] vertices, double[] errorValues, IObjectiveFunction objectiveFunction)
		{
			return 0.0;
		}

		private static void ShrinkSimplex(ErrorProfile errorProfile, Vector<double>[] vertices, double[] errorValues, IObjectiveFunction objectiveFunction)
		{
		}

		private static Vector<double> ComputeCentroid(Vector<double>[] vertices, ErrorProfile errorProfile)
		{
			return null;
		}
	}
}
