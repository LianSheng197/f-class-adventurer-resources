using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class UserQR : QR
	{
		public static UserQR Create(Matrix<double> matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private UserQR(Matrix<double> q, Matrix<double> rFull, QRMethod method)
			: base(null, null, default(QRMethod))
		{
		}

		private static double[] GenerateColumn(Matrix<double> a, int row, int column)
		{
			return null;
		}

		private static void ComputeQR(double[] u, Matrix<double> a, int rowStart, int rowDim, int columnStart, int columnDim, int availableCores)
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
