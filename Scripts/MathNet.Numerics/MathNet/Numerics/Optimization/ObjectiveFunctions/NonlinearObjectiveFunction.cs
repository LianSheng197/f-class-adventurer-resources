using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization.ObjectiveFunctions
{
	internal class NonlinearObjectiveFunction : IObjectiveModel, IObjectiveModelEvaluation
	{
		private readonly Func<Vector<double>, Vector<double>, Vector<double>> _userFunction;

		private readonly Func<Vector<double>, Vector<double>, Matrix<double>> _userDerivative;

		private readonly int _accuracyOrder;

		private Vector<double> _coefficients;

		private bool _hasFunctionValue;

		private double _functionValue;

		private Vector<double> _residuals;

		private bool _hasJacobianValue;

		private Matrix<double> _jacobianValue;

		private Vector<double> _gradientValue;

		private Matrix<double> _hessianValue;

		private Vector<double> L;

		public Vector<double> ObservedX
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

		public Vector<double> ObservedY
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

		public Matrix<double> Weights
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

		public List<bool> IsFixed
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

		public int NumberOfObservations => 0;

		public int NumberOfParameters => 0;

		public int DegreeOfFreedom => 0;

		public int FunctionEvaluations
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

		public int JacobianEvaluations
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

		public Vector<double> Point => null;

		public Vector<double> ModelValues
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

		public double Value => 0.0;

		public Vector<double> Gradient => null;

		public Matrix<double> Hessian => null;

		public bool IsGradientSupported => false;

		public bool IsHessianSupported => false;

		public NonlinearObjectiveFunction(Func<Vector<double>, Vector<double>, Vector<double>> function, Func<Vector<double>, Vector<double>, Matrix<double>> derivative = null, int accuracyOrder = 2)
		{
		}

		public IObjectiveModel Fork()
		{
			return null;
		}

		public IObjectiveModel CreateNew()
		{
			return null;
		}

		public void SetObserved(Vector<double> observedX, Vector<double> observedY, Vector<double> weights = null)
		{
		}

		public void SetParameters(Vector<double> initialGuess, List<bool> isFixed = null)
		{
		}

		public void EvaluateAt(Vector<double> parameters)
		{
		}

		public IObjectiveFunction ToObjectiveFunction()
		{
			return null;
		}

		private void EvaluateFunction()
		{
		}

		private void EvaluateJacobian()
		{
		}

		private Matrix<double> NumericalJacobian(Vector<double> parameters, Vector<double> currentValues, int accuracyOrder = 2)
		{
			return null;
		}
	}
}
