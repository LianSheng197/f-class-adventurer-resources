using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseEvd : Evd
	{
		public static DenseEvd Create(DenseMatrix matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private DenseEvd(Matrix<float> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<float> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		public override void Solve(Matrix<float> input, Matrix<float> result)
		{
		}

		public override void Solve(Vector<float> input, Vector<float> result)
		{
		}
	}
}
