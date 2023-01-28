using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public class NonlinearMinimizationResult
	{
		public IObjectiveModel ModelInfoAtMinimum
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Vector<double> MinimizingPoint => null;

		public Vector<double> StandardErrors
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector<double> MinimizedValues => null;

		public Matrix<double> Covariance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Matrix<double> Correlation
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int Iterations
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public ExitCondition ReasonForExit
		{
			[CompilerGenerated]
			get
			{
				return default(ExitCondition);
			}
		}

		public NonlinearMinimizationResult(IObjectiveModel modelInfo, int iterations, ExitCondition reasonForExit)
		{
		}

		private void EvaluateCovariance(IObjectiveModel objective)
		{
		}
	}
}
