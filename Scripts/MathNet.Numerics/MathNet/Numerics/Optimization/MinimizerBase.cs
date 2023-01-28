using System.Runtime.CompilerServices;

namespace MathNet.Numerics.Optimization
{
	public abstract class MinimizerBase
	{
		protected const double VerySmall = 1E-15;

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

		public double ParameterTolerance
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

		public double FunctionProgressTolerance
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

		protected MinimizerBase(double gradientTolerance, double parameterTolerance, double functionProgressTolerance, int maximumIterations)
		{
		}

		protected ExitCondition ExitCriteriaSatisfied(IObjectiveFunctionEvaluation candidatePoint, IObjectiveFunctionEvaluation lastPoint, int iterations)
		{
			return default(ExitCondition);
		}

		protected virtual double GetProjectedGradient(IObjectiveFunctionEvaluation candidatePoint, int ii)
		{
			return 0.0;
		}

		protected void ValidateGradientAndObjective(IObjectiveFunctionEvaluation eval)
		{
		}
	}
}
