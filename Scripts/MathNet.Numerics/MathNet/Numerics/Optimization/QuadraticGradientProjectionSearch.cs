using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra;

namespace MathNet.Numerics.Optimization
{
	public static class QuadraticGradientProjectionSearch
	{
		public readonly struct GradientProjectionResult
		{
			public Vector<double> CauchyPoint
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public int FixedCount
			{
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			public List<bool> IsFixed
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public GradientProjectionResult(Vector<double> cauchyPoint, int fixedCount, List<bool> isFixed)
			{
			}
		}

		public static GradientProjectionResult Search(Vector<double> x0, Vector<double> gradient, Matrix<double> hessian, Vector<double> lowerBound, Vector<double> upperBound)
		{
			return default(GradientProjectionResult);
		}
	}
}
