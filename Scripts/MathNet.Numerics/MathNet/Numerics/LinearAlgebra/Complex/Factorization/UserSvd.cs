using System.Numerics;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class UserSvd : Svd
	{
		public static UserSvd Create(Matrix<System.Numerics.Complex> matrix, bool computeVectors)
		{
			return null;
		}

		private UserSvd(Vector<System.Numerics.Complex> s, Matrix<System.Numerics.Complex> u, Matrix<System.Numerics.Complex> vt, bool vectorsComputed)
			: base(null, null, null, vectorsComputed: false)
		{
		}

		private static System.Numerics.Complex Csign(System.Numerics.Complex z1, System.Numerics.Complex z2)
		{
			return default(System.Numerics.Complex);
		}

		private static void Swap(Matrix<System.Numerics.Complex> a, int rowCount, int columnA, int columnB)
		{
		}

		private static void CscalColumn(Matrix<System.Numerics.Complex> a, int rowCount, int column, int rowStart, System.Numerics.Complex z)
		{
		}

		private static void CscalVector(System.Numerics.Complex[] a, int start, System.Numerics.Complex z)
		{
		}

		private static void Srotg(ref double da, ref double db, out double c, out double s)
		{
			c = default(double);
			s = default(double);
		}

		private static double Cnrm2Column(Matrix<System.Numerics.Complex> a, int rowCount, int column, int rowStart)
		{
			return 0.0;
		}

		private static double Cnrm2Vector(System.Numerics.Complex[] a, int rowStart)
		{
			return 0.0;
		}

		private static System.Numerics.Complex Cdotc(Matrix<System.Numerics.Complex> a, int rowCount, int columnA, int columnB, int rowStart)
		{
			return default(System.Numerics.Complex);
		}

		private static void Csrot(Matrix<System.Numerics.Complex> a, int rowCount, int columnA, int columnB, double c, double s)
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
