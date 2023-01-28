using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseEvd : Evd
	{
		public static DenseEvd Create(DenseMatrix matrix, Symmetricity symmetricity)
		{
			return null;
		}

		private DenseEvd(Matrix<double> eigenVectors, Vector<System.Numerics.Complex> eigenValues, Matrix<double> blockDiagonal, bool isSymmetric)
			: base(null, null, null, isSymmetric: false)
		{
		}

		public override void Solve(Matrix<double> input, Matrix<double> result)
		{
		}

		public override void Solve(Vector<double> input, Vector<double> result)
		{
		}
	}
}
