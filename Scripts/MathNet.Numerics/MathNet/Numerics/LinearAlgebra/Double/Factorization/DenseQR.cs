using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Double.Factorization
{
	internal sealed class DenseQR : QR
	{
		private double[] Tau
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static DenseQR Create(DenseMatrix matrix, QRMethod method = QRMethod.Full)
		{
			return null;
		}

		private DenseQR(Matrix<double> q, Matrix<double> rFull, QRMethod method, double[] tau)
			: base(null, null, default(QRMethod))
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
