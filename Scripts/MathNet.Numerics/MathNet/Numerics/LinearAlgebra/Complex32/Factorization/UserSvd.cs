namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserSvd : Svd
	{
		public static UserSvd Create(Matrix<MathNet.Numerics.Complex32> matrix, bool computeVectors)
		{
			return null;
		}

		private UserSvd(Vector<MathNet.Numerics.Complex32> s, Matrix<MathNet.Numerics.Complex32> u, Matrix<MathNet.Numerics.Complex32> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
		{
		}

		private static MathNet.Numerics.Complex32 Csign(MathNet.Numerics.Complex32 z1, MathNet.Numerics.Complex32 z2)
		{
			return default(MathNet.Numerics.Complex32);
		}

		private static void Swap(Matrix<MathNet.Numerics.Complex32> a, int rowCount, int columnA, int columnB)
		{
		}

		private static void CscalColumn(Matrix<MathNet.Numerics.Complex32> a, int rowCount, int column, int rowStart, MathNet.Numerics.Complex32 z)
		{
		}

		private static void CscalVector(MathNet.Numerics.Complex32[] a, int start, MathNet.Numerics.Complex32 z)
		{
		}

		private static void Srotg(ref float da, ref float db, out float c, out float s)
		{
			c = default(float);
			s = default(float);
		}

		private static float Cnrm2Column(Matrix<MathNet.Numerics.Complex32> a, int rowCount, int column, int rowStart)
		{
			return 0f;
		}

		private static float Cnrm2Vector(MathNet.Numerics.Complex32[] a, int rowStart)
		{
			return 0f;
		}

		private static MathNet.Numerics.Complex32 Cdotc(Matrix<MathNet.Numerics.Complex32> a, int rowCount, int columnA, int columnB, int rowStart)
		{
			return default(MathNet.Numerics.Complex32);
		}

		private static void Csrot(Matrix<MathNet.Numerics.Complex32> a, int rowCount, int columnA, int columnB, float c, float s)
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
