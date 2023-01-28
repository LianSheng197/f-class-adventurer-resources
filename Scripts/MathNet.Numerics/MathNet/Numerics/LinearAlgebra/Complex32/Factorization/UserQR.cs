using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Complex32.Factorization
{
	internal sealed class UserQR : QR
	{
		public static UserQR Create(Matrix<MathNet.Numerics.Complex32> matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private UserQR(Matrix<MathNet.Numerics.Complex32> q, Matrix<MathNet.Numerics.Complex32> rFull, QRMethod method)
			: base(null, null, default(QRMethod))
		{
		}

		private static MathNet.Numerics.Complex32[] GenerateColumn(Matrix<MathNet.Numerics.Complex32> a, int row, int column)
		{
			return null;
		}

		private static void ComputeQR(MathNet.Numerics.Complex32[] u, Matrix<MathNet.Numerics.Complex32> a, int rowStart, int rowDim, int columnStart, int columnDim, int availableCores)
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
