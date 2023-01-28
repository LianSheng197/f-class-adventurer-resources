namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseSvd : Svd
	{
		public static DenseSvd Create(DenseMatrix matrix, bool computeVectors)
		{
			return null;
		}

		private DenseSvd(Vector<float> s, Matrix<float> u, Matrix<float> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
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
