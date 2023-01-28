using System;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class LazyObjectiveFunction : IObjectiveFunction, IObjectiveFunctionEvaluation
	{
		private readonly Func<Vector<double>, double> _function;

		private readonly Func<Vector<double>, Vector<double>> _gradient;

		private readonly Func<Vector<double>, Matrix<double>> _hessian;

		private Vector<double> _point;

		private bool _hasFunctionValue;

		private double _functionValue;

		private bool _hasGradientValue;

		private Vector<double> _gradientValue;

		private bool _hasHessianValue;

		private Matrix<double> _hessianValue;

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

		public double Value => 0.0;

		public Vector<double> Gradient => null;

		public Matrix<double> Hessian => null;

		public LazyObjectiveFunction(Func<Vector<double>, double> function, Func<Vector<double>, Vector<double>> gradient = null, Func<Vector<double>, Matrix<double>> hessian = null)
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
