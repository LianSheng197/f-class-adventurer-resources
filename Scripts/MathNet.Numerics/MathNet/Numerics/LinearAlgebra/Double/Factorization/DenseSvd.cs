namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseSvd : Svd
	{
		public static DenseSvd Create(DenseMatrix matrix, bool computeVectors)
		{
			return null;
		}

		private DenseSvd(Vector<double> s, Matrix<double> u, Matrix<double> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
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
