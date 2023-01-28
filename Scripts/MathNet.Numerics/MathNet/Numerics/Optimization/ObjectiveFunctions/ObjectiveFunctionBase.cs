using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	public abstract class ObjectiveFunctionBase : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
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

		public Vector<double> Point
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

		public double Value
		{
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public Vector<double> Gradient
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

		public Matrix<double> Hessian
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

		protected ObjectiveFunctionBase(bool isGradientSupported, bool isHessianSupported)
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

		protected abstract void Evaluate();
	}
}
