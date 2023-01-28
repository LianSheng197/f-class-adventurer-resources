using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public abstract class NonlinearMinimizerBase
	{
		public double FunctionTolerance
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

		public double StepTolerance
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

		public Vector<double> LowerBound
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

		public Vector<double> UpperBound
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

		public Vector<double> Scales
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

		private bool IsBounded => false;

		protected NonlinearMinimizerBase(double gradientTolerance = 1E-18, double stepTolerance = 1E-18, double functionTolerance = 1E-18, int maximumIterations = -1)
		{
		}

		protected void ValidateBounds(Vector<double> parameters, Vector<double> lowerBound = null, Vector<double> upperBound = null, Vector<double> scales = null)
		{
		}

		protected double EvaluateFunction(IObjectiveModel objective, Vector<double> Pint)
		{
			return 0.0;
		}

		protected (Vector<double>, Matrix<double>) EvaluateJacobian(IObjectiveModel objective, Vector<double> Pint)
		{
			return default((Vector<double>, Matrix<double>));
		}

		protected Vector<double> ProjectToInternalParameters(Vector<double> Pext)
		{
			return null;
		}

		protected Vector<double> ProjectToExternalParameters(Vector<double> Pint)
		{
			return null;
		}

		protected Vector<double> ScaleFactorsOfJacobian(Vector<double> Pint)
		{
			return null;
		}
	}
}
