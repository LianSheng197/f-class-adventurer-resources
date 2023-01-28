using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class DenseSvd : Svd
	{
		public static DenseSvd Create(DenseMatrix matrix, bool computeVectors)
		{
			return null;
		}

		private DenseSvd(Vector<System.Numerics.Complex> s, Matrix<System.Numerics.Complex> u, Matrix<System.Numerics.Complex> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
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
