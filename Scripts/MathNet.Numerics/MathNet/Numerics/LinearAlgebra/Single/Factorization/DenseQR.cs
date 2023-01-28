using System.Runtime.CompilerServices;
using MathNet.Numerics.LinearAlgebra.Factorization;

namespace MathNet.Numerics.LinearAlgebra.Single.Factorization
{
	internal sealed class DenseQR : QR
	{
		private float[] Tau
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

		private DenseQR(Matrix<float> q, Matrix<float> rFull, QRMethod method, float[] tau)
			: base(null, null, default(QRMethod))
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
