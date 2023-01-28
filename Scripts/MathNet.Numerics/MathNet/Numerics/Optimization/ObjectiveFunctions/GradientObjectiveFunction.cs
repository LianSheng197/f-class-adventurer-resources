using System;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class GradientObjectiveFunction : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
		private readonly Func<Vector<double>, (double, Vector<double>)> _function;

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
			private set
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
			private set
			{
			}
		}

		public Matrix<double> Hessian => null;

		public GradientObjectiveFunction(Func<Vector<double>, (double, Vector<double>)> function)
		{
		}

		public IObjectiveFunction CreateNew()
		{
			return null;
		}

		public IObjectiveFunction Fork()
		{
			return null;
		}

		public void EvaluateAt(Vector<double> point)
		{
		}
	}
}
