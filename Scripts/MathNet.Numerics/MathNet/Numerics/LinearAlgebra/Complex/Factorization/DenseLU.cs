using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseLU : LU
	{
		public static DenseLU Create(DenseMatrix matrix)
		{
			return null;
		}

		private DenseLU(Matrix<System.Numerics.Complex> factors, int[] pivots)
			: base(null, null)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}

		public override Matrix<System.Numerics.Complex> Inverse()
		{
			return null;
		}
	}
}
