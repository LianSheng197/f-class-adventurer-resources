using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class UserQR : QR
	{
		public static UserQR Create(Matrix<float> matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private UserQR(Matrix<float> q, Matrix<float> rFull, QRMethod method)
			: base(null, null, default(QRMethod))
		{
		}

		private static float[] GenerateColumn(Matrix<float> a, int row, int column)
		{
			return null;
		}

		private static void ComputeQR(float[] u, Matrix<float> a, int rowStart, int rowDim, int columnStart, int columnDim, int availableCores)
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
