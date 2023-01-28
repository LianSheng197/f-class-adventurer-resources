using System.Numerics;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex.Factorization
{
	internal sealed class UserQR : QR
	{
		public static UserQR Create(Matrix<System.Numerics.Complex> matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private UserQR(Matrix<System.Numerics.Complex> q, Matrix<System.Numerics.Complex> rFull, QRMethod method)
			: base(null, null, default(QRMethod))
		{
		}

		private static System.Numerics.Complex[] GenerateColumn(Matrix<System.Numerics.Complex> a, int row, int column)
		{
			return null;
		}

		private static void ComputeQR(System.Numerics.Complex[] u, Matrix<System.Numerics.Complex> a, int rowStart, int rowDim, int columnStart, int columnDim, int availableCores)
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
