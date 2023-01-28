using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseEvd : Evd
	{
		public static DenseEvd Create(DenseMatrix matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private DenseEvd(Matrix<MathNet.Numerics.Complex32> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<MathNet.Numerics.Complex32> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		public override void Solve(Matrix<MathNet.Numerics.Complex32> input, Matrix<MathNet.Numerics.Complex32> result)
		{
		}

		public override void Solve(Vector<MathNet.Numerics.Complex32> input, Vector<MathNet.Numerics.Complex32> result)
		{
		}
	}
}
