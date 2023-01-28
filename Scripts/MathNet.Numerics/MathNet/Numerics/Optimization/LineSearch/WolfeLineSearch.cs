using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.LineSearch
{
	public abstract class WolfeLineSearch
	{
		protected double C1
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		protected double C2
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		protected double ParameterTolerance
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		protected int MaximumIterations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		protected abstract ExitCondition WolfeExitCondition { get; }

		public WolfeLineSearch(double c1, double c2, double parameterTolerance, int maxIterations = 10)
		{
		}

		public LineSearchResult FindConformingStep(IObjectiveFunctionEvaluation startingPoint, Vector<double> searchDirection, double initialStep)
		{
			return null;
		}

		public LineSearchResult FindConformingStep(IObjectiveFunctionEvaluation startingPoint, Vector<double> searchDirection, double initialStep, double upperBound)
		{
			return null;
		}

		protected abstract bool WolfeCondition(double stepDd, double initialDd);

		protected virtual void ValidateGradient(IObjectiveFunctionEvaluation objective)
		{
		}

		protected virtual void ValidateValue(IObjectiveFunctionEvaluation objective)
		{
		}

		protected virtual void ValidateInputArguments(IObjectiveFunctionEvaluation startingPoint, Vector<double> searchDirection, double initialStep, double upperBound)
		{
		}
	}
}
