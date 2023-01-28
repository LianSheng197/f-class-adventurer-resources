namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserSvd : Svd
	{
		public static UserSvd Create(Matrix<float> matrix, bool computeVectors)
		{
			return null;
		}

		private UserSvd(Vector<float> s, Matrix<float> u, Matrix<float> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
		{
		}

		private static float Dsign(float z1, float z2)
		{
			return 0f;
		}

		private static void Dswap(Matrix<float> a, int rowCount, int columnA, int columnB)
		{
		}

		private static void DscalColumn(Matrix<float> a, int rowCount, int column, int rowStart, float z)
		{
		}

		private static void DscalVector(float[] a, int start, float z)
		{
		}

		private static void Drotg(ref float da, ref float db, out float c, out float s)
		{
			c = default(float);
			s = default(float);
		}

		private static float Dnrm2Column(Matrix<float> a, int rowCount, int column, int rowStart)
		{
			return 0f;
		}

		private static float Dnrm2Vector(float[] a, int rowStart)
		{
			return 0f;
		}

		private static float Ddot(Matrix<float> a, int rowCount, int columnA, int columnB, int rowStart)
		{
			return 0f;
		}

		private static void Drot(Matrix<float> a, int rowCount, int columnA, int columnB, float c, float s)
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
