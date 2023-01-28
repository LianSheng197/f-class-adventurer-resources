using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	public abstract class LazyObjectiveFunctionBase : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
		private Vector<double> _point;

		protected bool HasFunctionValue
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

		protected double FunctionValue
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

		protected bool HasGradientValue
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

		protected Vector<double> GradientValue
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

		protected bool HasHessianValue
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

		protected Matrix<double> HessianValue
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

		public bool IsGradientSupported
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool IsHessianSupported
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public Vector<double> Point => null;

		public double Value
		{
			get
			{
				return 0.0;
			}
			protected set
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

		public Matrix<double> Hessian
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected LazyObjectiveFunctionBase(bool gradientSupported, bool hessianSupported)
		{
		}

		public abstract IObjectiveFunction CreateNew();

		public virtual IObjectiveFunction Fork()
		{
			return null;
		}

		public void EvaluateAt(Vector<double> point)
		{
		}

		protected abstract void EvaluateValue();

		protected virtual void EvaluateGradient()
		{
		}

		protected virtual void EvaluateHessian()
		{
		}
	}
}
