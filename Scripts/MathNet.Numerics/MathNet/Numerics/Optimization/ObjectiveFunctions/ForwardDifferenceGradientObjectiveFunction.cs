using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	public class ForwardDifferenceGradientObjectiveFunction : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
		private Vector<double> _gradient;

		public IObjectiveFunction InnerObjectiveFunction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected Vector<double> LowerBound
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected Vector<double> UpperBound
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected bool ValueEvaluated
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

		protected bool GradientEvaluated
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

		public double MinimumIncrement
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

		public double RelativeIncrement
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

		public Vector<double> Gradient
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Matrix<double> Hessian => null;

		public bool IsGradientSupported => false;

		public bool IsHessianSupported => false;

		public Vector<double> Point
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public double Value => 0.0;

		public ForwardDifferenceGradientObjectiveFunction(IObjectiveFunction valueOnlyObj, Vector<double> lowerBound, Vector<double> upperBound, double relativeIncrement = 1E-05, double minimumIncrement = 1E-08)
		{
		}

		protected void EvaluateValue()
		{
		}

		protected void EvaluateGradient()
		{
		}

		public IObjectiveFunction CreateNew()
		{
			return null;
		}

		public void EvaluateAt(Vector<double> point)
		{
		}

		public IObjectiveFunction Fork()
		{
			return null;
		}
	}
}
