namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class DenseSvd : Svd
	{
		public static DenseSvd Create(DenseMatrix matrix, bool computeVectors)
		{
			return null;
		}

		private DenseSvd(Vector<MathNet.Numerics.Complex32> s, Matrix<MathNet.Numerics.Complex32> u, Matrix<MathNet.Numerics.Complex32> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
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
