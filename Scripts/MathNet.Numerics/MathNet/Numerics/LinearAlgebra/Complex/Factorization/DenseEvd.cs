using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseEvd : Evd
	{
		public static DenseEvd Create(DenseMatrix matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private DenseEvd(Matrix<System.Numerics.Complex> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<System.Numerics.Complex> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		public override void Solve(Matrix<System.Numerics.Complex> input, Matrix<System.Numerics.Complex> result)
		{
		}

		public override void Solve(Vector<System.Numerics.Complex> input, Vector<System.Numerics.Complex> result)
		{
		}
	}
}
