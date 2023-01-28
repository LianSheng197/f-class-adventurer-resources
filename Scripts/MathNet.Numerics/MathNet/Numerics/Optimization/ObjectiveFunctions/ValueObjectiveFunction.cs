using System;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class ValueObjectiveFunction : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
		private readonly Func<Vector<double>, double> _function;

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

		public Matrix<double> Hessian => null;

		public Vector<double> Gradient => null;

		public ValueObjectiveFunction(Func<Vector<double>, double> function)
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
