namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserSvd : Svd
	{
		public static UserSvd Create(Matrix<double> matrix, bool computeVectors)
		{
			return null;
		}

		private UserSvd(Vector<double> s, Matrix<double> u, Matrix<double> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
		{
		}

		private static double Dsign(double z1, double z2)
		{
			return 0.0;
		}

		private static void Dswap(Matrix<double> a, int rowCount, int columnA, int columnB)
		{
		}

		private static void DscalColumn(Matrix<double> a, int rowCount, int column, int rowStart, double z)
		{
		}

		private static void DscalVector(double[] a, int start, double z)
		{
		}

		private static void Drotg(ref double da, ref double db, out double c, out double s)
		{
			c = default(double);
			s = default(double);
		}

		private static double Dnrm2Column(Matrix<double> a, int rowCount, int column, int rowStart)
		{
			return 0.0;
		}

		private static double Dnrm2Vector(double[] a, int rowStart)
		{
			return 0.0;
		}

		private static double Ddot(Matrix<double> a, int rowCount, int columnA, int columnB, int rowStart)
		{
			return 0.0;
		}

		private static void Drot(Matrix<double> a, int rowCount, int columnA, int columnB, double c, double s)
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
