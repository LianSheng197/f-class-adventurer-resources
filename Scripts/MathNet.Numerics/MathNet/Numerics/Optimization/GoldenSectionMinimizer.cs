using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization
{
	public class GoldenSectionMinimizer
	{
		public double XTolerance
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

		public int MaximumExpansionSteps
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

		public double LowerExpansionFactor
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

		public double UpperExpansionFactor
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

		public GoldenSectionMinimizer(double xTolerance = 1E-05, int maxIterations = 1000, int maxExpansionSteps = 10, double lowerExpansionFactor = 2.0, double upperExpansionFactor = 2.0)
		{
		}

		public ScalarMinimizationResult FindMinimum(IScalarObjectiveFunction objective, double lowerBound, double upperBound)
		{
			return null;
		}

		public static ScalarMinimizationResult Minimum(IScalarObjectiveFunction objective, double lowerBound, double upperBound, double xTolerance = 1E-05, int maxIterations = 1000, int maxExpansionSteps = 10, double lowerExpansionFactor = 2.0, double upperExpansionFactor = 2.0)
		{
			return null;
		}

		private static void ValueChecker(double value)
		{
		}
	}
}
